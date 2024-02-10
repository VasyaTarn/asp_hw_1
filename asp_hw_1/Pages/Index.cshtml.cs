using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_hw_1.Pages
{
    public class IndexModel : PageModel
    {
        public List<Restaurant> Restaurants { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Central", Location = "Lima, Peru", Chef = "Virgilio Martinez" },
                new Restaurant { Id = 2, Name = "Disfrutar", Location = "Barcelona, ​​Spain", Chef = "Oriol Castro" },
                new Restaurant { Id = 3, Name = "Diverxo", Location = "Madrid, Spain", Chef = "David Muñoz" },
            };
        }

        public class Restaurant
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }
            public string Chef { get; set; }

        }
    }
}
