﻿using System.Web;
using System.Web.Mvc;

namespace WebAppMVC_Assignment_12
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
