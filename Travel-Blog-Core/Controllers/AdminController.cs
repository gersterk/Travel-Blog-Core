﻿using Microsoft.AspNetCore.Mvc;

namespace Travel_Blog_Core.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialAppBrandDemo()
        {
            return PartialView();
        }

        public PartialViewResult PartialSideBar()
        {
            return PartialView();

        }

        public PartialViewResult PartialNavBar()
        {
            return PartialView();

        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();

        }

        public PartialViewResult PartialScript()
        {
            return PartialView();

        }
    }
}
