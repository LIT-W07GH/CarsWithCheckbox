using System.Collections.Generic;

namespace CarsWithCheckbox.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public bool SortAsc { get; set; }
    }
}