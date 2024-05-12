using LV4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LV4.Controllers
{
    public class EventController : Controller
    {
        private static List<EventModel> events = new List<EventModel>()
        {

            new EventModel() { Id = 1, Name="Finki Party", Location = "Skopje Event Center"},
            new EventModel() { Id = 2, Name="USS Party", Location = "Pure"},
            new EventModel() { Id = 3, Name="FEIT Party", Location = "Beertija"},
        };
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult allEvents()
        {
            return View(events);
        }

        public ActionResult Create()
        {
            ViewBag.nextId = events.Last().Id + 1;
            return View();
        }

        public ActionResult EventInfo(EventModel eventModel)
        {
            if(!ModelState.IsValid)
            {
                return Content("Invalid data");
            }

            eventModel.Id = events.Last().Id + 1;
            events.Add(eventModel);


            return View(eventModel);
        }

        public ActionResult Edit(int id)
        {
            EventModel foundEvent = null;
            foreach (EventModel eventModel in events)
            {
                if(eventModel.Id == id)
                {
                    foundEvent = eventModel;
                    break;
                }
                
            }

            if(foundEvent == null)
            {
                return Content("Event not found");
            }

            return View(foundEvent);
        }

        public ActionResult UpdateEventInfo(EventModel newEventModel)
        {
            foreach (EventModel evenetModel in events)
            {
                if (evenetModel.Id == newEventModel.Id)
                {
                    evenetModel.Name = newEventModel.Name;
                    evenetModel.Location = newEventModel.Location;
                    break;

                }
            }
            return RedirectToAction("allEvents");


        }

        public ActionResult Delete(int id)
        {
            foreach (EventModel evenetModel in events.ToList())
            {
                if (evenetModel.Id == id)
                {
                    events.Remove(evenetModel);
                    break;
                }
            }

            return RedirectToAction("allEvents");
        }

    }
}