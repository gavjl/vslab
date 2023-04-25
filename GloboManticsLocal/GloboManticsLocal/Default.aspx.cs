using System;
using System.Collections.Generic;
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

        }
    }
}