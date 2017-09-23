using AndersonSurveySystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AndersonSurveySystem.Controllers
{
    public class ChartController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Static()
        {
            return View();
        }

        public ActionResult StaticStructured()
        {
            return View();
        }

        public ActionResult DynamicStructured()
        {
            return View();
        }

        public JsonResult DynamicStructuredData()
        {
            List<Chart> chart = new List<Chart>()
            {
                new Chart
                {
                    Series = "Series A",
                    ChartData = new List<ChartData>
                    {
                        new ChartData
                        {
                            Label = "2006",
                            Data = 65
                        },
                        new ChartData
                        {
                            Label = "2007",
                            Data = 59
                        },
                        new ChartData
                        {
                            Label = "2008",
                            Data = 80
                        },
                        new ChartData
                        {
                            Label = "2009",
                            Data = 81
                        },
                        new ChartData
                        {
                            Label = "2010",
                            Data = 56
                        },
                        new ChartData
                        {
                            Label = "2011",
                            Data = 55
                        },
                        new ChartData
                        {
                            Label = "2012",
                            Data = 40
                        }
                    }
                },

                new Chart
                {
                    Series = "Series B",
                    ChartData = new List<ChartData>
                    {
                        new ChartData
                        {
                            Label = "2006",
                            Data = 28
                        },
                        new ChartData
                        {
                            Label = "2007",
                            Data = 48
                        },
                        new ChartData
                        {
                            Label = "2008",
                            Data = 40
                        },
                        new ChartData
                        {
                            Label = "2009",
                            Data = 19
                        },
                        new ChartData
                        {
                            Label = "2010",
                            Data = 86
                        },
                        new ChartData
                        {
                            Label = "2011",
                            Data = 27
                        },
                        new ChartData
                        {
                            Label = "2012",
                            Data = 90
                        }
                    }
                }
            };
            return Json(chart);
        }
    }
}