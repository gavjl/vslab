using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GloboManticsLocal
{
    public class ViewStateMacDisableModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.PostMapRequestHandler += OnPostMapRequestHandler;
        }

        private void OnPostMapRequestHandler(object sender, EventArgs e)
        {
            var page = HttpContext.Current.CurrentHandler as Page;
            if (page != null)
            {
                page.EnableViewStateMac = false;
            }
        }
    }

    public partial class _Default : Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            this.Page.EnableViewStateMac = false;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;

            if (!string.IsNullOrEmpty(Request.QueryString["targetFile"]))
            {
                string downloadPath = @"C:\UserFiles\Admin\";
                string targetFile = Request.QueryString["targetFile"];
                string targetPath = Path.GetFullPath(Path.Combine(downloadPath, targetFile));

                TextBox textBox1 = new TextBox();
                textBox1.ID = "tb1";
                textBox1.Width = 800;
                textBox1.TextMode = TextBoxMode.MultiLine;
                textBox1.Rows = 20;

                if (System.IO.File.Exists(targetPath))
                {
                    textBox1.Text = System.IO.File.ReadAllText(targetPath);
                }
                else
                {
                    textBox1.Text = "File not found: " + targetPath;
                }

                fileContents.Controls.Add(textBox1);
            }
        }
    }
}