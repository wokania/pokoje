using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using DHTMLX.Scheduler;
using DHTMLX.Common;
using DHTMLX.Scheduler.Data;
using DHTMLX.Scheduler.Controls;

using pokoje.Models;
namespace pokoje.Controllers
{
    [Authorize(Roles ="role")]
    public class CalendarController : Controller
    {
        public ActionResult Index()
        {
            
            var scheduler = new DHXScheduler(this);
            DateTime thisDay = DateTime.Today;
            scheduler.InitialDate.ToString(thisDay.ToString());
            scheduler.LoadData = true;
            scheduler.EnableDataprocessor = true;

            return View(scheduler);
        }

        
        public ContentResult Data()
        {
            var data = new SchedulerAjaxData(
                
            new Event().Events.Select(e => new { id = e.id, start_date = e.start_date, end_date = e.end_date, text = e.text, room_id = e.room_id, color = e.color, textColor = e.textColor})
        );
            return (ContentResult)data;

        }

        public ContentResult Save(int ?id, FormCollection actionValues)
        {
            var action = new DataAction(actionValues);
           
            try
            {
                var changedEvent = (Events)DHXEventsHelper.Bind(typeof(Events), actionValues);

                switch (action.Type)
                {
                    case DataActionTypes.Insert:
                        //do insert
                        action.TargetId = changedEvent.id;
                        break;
                    case DataActionTypes.Delete:
                        //do delete
                        break;
                    default:// "update"                          
                        //do update
                        break;
                }
            }
            catch
            {
                action.Type = DataActionTypes.Error;
            }
            return (ContentResult)new AjaxSaveResponse(action);
        }
    }

}
/*
public ContentResult Data()
{ 
    var data = new SchedulerAjaxData(
    new IEnumerable<Events>()
    using (Event dc = new Event())
    {
        data = dc.Events.ToList();
    } 
    return (ContentResult)data;
}
*/
/*
                    new List<CalendarEvent>{ 
                        new CalendarEvent{
                            id = 1, 
                            text = "Sample Event", 
                            
                            start_date = new DateTime(2016, 09, 03, 6, 00, 00)., 
                            
                            end_date = new DateTime(2012, 09, 03, 8, 00, 00)
                        },
                        new CalendarEvent{
                            id = 2, 
                            text = "New Event", 
                            start_date = new DateTime(2012, 09, 05, 9, 00, 00), 
                            end_date = new DateTime(2012, 09, 05, 12, 00, 00)
                        },
                        new CalendarEvent{
                            id = 3, 
                            text = "Multiday Event", 
                            start_date = new DateTime(2012, 09, 03, 10, 00, 00), 
                            end_date = new DateTime(2012, 09, 10, 12, 00, 00)
                        */
