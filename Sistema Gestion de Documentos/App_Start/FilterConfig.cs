﻿using System.Web;
using System.Web.Mvc;

namespace Sistema_Gestion_de_Documentos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
