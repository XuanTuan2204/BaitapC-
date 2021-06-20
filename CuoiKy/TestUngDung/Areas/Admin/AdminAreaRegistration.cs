using System.Web.Mvc;

namespace TestUngDung.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
               "Create_default",
               "Admin/{controller}/{action}/{user}",
               new { controller = "User", action = "Create", user = UrlParameter.Optional }
           );

            context.MapRoute(
            "Delete_default",
            "Admin/{controller}/{action}/{user}",
            new { controller = "User", action = "Delete", user = UrlParameter.Optional }
        );

            context.MapRoute(
            "User_Index_default",
            "Admin/{controller}",
            new { controller = "User", id = UrlParameter.Optional }
        );
            //    context.MapRoute(
            //       "Create_default",
            //       "Admin/{controller}/{action}/{danhmuc}",
            //       new { controller = "DanhMuc", action = "Create", danhmuc = UrlParameter.Optional }
            //   );

            //    context.MapRoute(
            //    "Delete1_default",
            //    "Admin/{controller}/{action}/{danhmuc}",
            //    new { controller = "DanhMuc", action = "Delete", danhmuc = UrlParameter.Optional }
            //);

            //    context.MapRoute(
            //    "DanhMuc_Index_default",
            //    "Admin/{controller}",
            //    new { controller = "DanhMuc", id = UrlParameter.Optional }
            //);


            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}