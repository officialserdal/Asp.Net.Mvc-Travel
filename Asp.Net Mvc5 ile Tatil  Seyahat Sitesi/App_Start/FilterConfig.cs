﻿using System.Web;
using System.Web.Mvc;

namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
