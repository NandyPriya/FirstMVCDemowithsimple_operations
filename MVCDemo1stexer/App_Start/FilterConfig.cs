﻿using System.Web;
using System.Web.Mvc;

namespace MVCDemo1stexer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
