using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_hw_1.Pages
{
    public class RestaurantModel : PageModel
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Chef { get; set; }


        public void OnGet(int restaurantId, string name, string location, string chef)
        {
            RestaurantId = restaurantId;
            Name = name;
            Location = location;
            Chef = chef;
        }
    }
}
