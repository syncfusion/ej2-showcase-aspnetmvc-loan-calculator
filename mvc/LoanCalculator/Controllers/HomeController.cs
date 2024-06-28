using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;
namespace EJ2MVCSampleBrowser.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.titleStyle = new ChartFont{ Color = "#FFFFFF", FontFamily = "Raleway, sans-serif", FontWeight="600", Size="16px", Opacity=0.62 }; 

            ViewBag.yAxisMajorGridLines = new { width = 1, dashArray = "2", color = "rgba(255,255,255,0.2)" };
           
            ViewBag.axesTitleStyle = new ChartFont { Color = "#FFFFFF", FontFamily = "Raleway, sans-serif", FontWeight = "600", Size = "16px", Opacity = 0.62 };//new { color = "#FFFFFF", fontFamily = "Raleway, sans-serif", fontWeight = "600", size = "16px", opacity = 0.62 };

            ViewBag.chartAreaBorder = new ChartBorder { Width = 0 }; //new { width = 0 };
            ViewBag.palettes = new string[] { "#FB6589", "#3AC8DC", "#FFFFFF" };

            ViewBag.legendTextStyle = new { color = "#FFFFFF", fontFamily = "Raleway, sans-serif", fontWeight = "600", size = "16px", opacity = 0.62 };
            ViewBag.childGrid = new { };
            return View();
        }
    }
}