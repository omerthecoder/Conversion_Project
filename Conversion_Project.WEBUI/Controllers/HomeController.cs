using Conversion_Project.Entities;
using Conversion_Project.WEBUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Conversion_Project.WEBUI.Controllers
{
    using BL.Abstract;
    public class HomeController : Controller
    {
        private IDataTextBusiness _dataTextBusiness;
        public HomeController(IDataTextBusiness dataTextBusiness)
        {
            _dataTextBusiness = dataTextBusiness;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(DataTextVM dataText)
        {
            DataText DText = new DataText();
            DText.DataId = dataText.DataId;
            DText.Text = dataText.Text;
            DText.Translated = dataText.Translated;
            DText.Translation = dataText.Translation;
            if (DText != null)
            {
                await _dataTextBusiness.Add(DText);
            }
            return View(dataText);
        }

        [HttpGet("get-all-data")]
        public IActionResult GetData()
        {
            return Json(_dataTextBusiness.GetAll().ToArray());
        }
    }
}
