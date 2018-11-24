using System.Collections.Generic;
using System.Linq;
using QLDJPFinder.Core;

namespace QLDJPFinder.UI
{
    public class LocationsViewModel
    {
        public LocationsViewModel(IEnumerable<JPInfo> locations)
        {
            this.Locations = locations;
            this.Count = this.Locations.Count();
        }

        public int Count { get; }

        public IEnumerable<JPInfo> Locations { get; }
    }
}
