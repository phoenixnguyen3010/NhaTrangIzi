using System.Collections.Generic;

namespace NhaTrangIzi.ViewModel
{
    public class MainPageViewModel
    {
        public string TabName { get; set; }

        public List<string> GetListTabs()
        {
            return new List<string>()
            {
                "THE FACES OF LIFE","TOUR & TRAVEL", "GETTING HERE & AWAY", "SHOPPING", "GETTING AROUND",
                "HEALTH & SPA", "ACCOMMODATION", "MAPS", "RESTAURANT & BARS", "LIFE'S A BEACH", "LOCAL FOOD",
                "SPORTS & ADVENTURE", "WHAT TO SEE", "SCUBA DIVING", "THINGS TO DO", "EVENTS & PROMOTIONS"
            };
        } 
    }
}