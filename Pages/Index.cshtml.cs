using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCupSoccer.Data;
using WorldCupSoccer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WorldCupSoccer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WorldCupSoccerContext db;
        public IndexModel(WorldCupSoccerContext db) => this.db = db;
        public List<Event> eventList {get; set;} = new List<Event>();
        public Event featuredEvent {get; set;}
        public async Task OnGetAsync() {
            eventList = await db.events.ToListAsync(); 
            featuredEvent = eventList.ElementAt(0);
        }
    }
}
