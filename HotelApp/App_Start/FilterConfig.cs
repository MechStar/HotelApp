﻿using HotelApp.Filters;
using System.Web.Mvc;

namespace HotelApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LogAndHandleErrorAttribute());
        }
    }
}
