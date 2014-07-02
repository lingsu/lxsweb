using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin
{
    public class AdminAreaRegistration:AreaRegistration
    {
        public override void RegisterArea(AreaRegistrationContext context)
        {
            //此路由不能删除
            context.MapRoute("Admin_default",
                              "Admin/{controller}/{action}",
                              new { controller = "Home", action = "Index", area = "Admin" },
                              new[] { "Admin.Controllers" });
        }

        public override string AreaName
        {
            get { return "Admin"; }
        }
    }
}