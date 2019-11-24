using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.App.Areas.Admin.Controllers;
using MyBlog.App.Filter;

namespace MyBlog.App.Areas.Cash.Controllers
{
    [AuthorizeFilter]
    [API("角色")]
    [Area("Cash")]
    public class KendoUIController : BaseController
    {
        [API("角色页面访问")]
        public IActionResult Index()
        {
            return View();
        }
    }
}