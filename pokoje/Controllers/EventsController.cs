using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace pokoje.Controllers
{
    public class EventsController : Controller
    {
            public ActionResult List()
            {
                var events = new List<Events>();
                using (Event dc = new Event())
                {
                    events = dc.Events.ToList();
                }
                return View(events);
            }
        }
    }