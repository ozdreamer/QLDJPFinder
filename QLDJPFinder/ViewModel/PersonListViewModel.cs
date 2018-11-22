using System.Collections.Generic;
using System.Linq;
using QLDJPFinder.Core;

namespace QLDJPFinder
{
    public class PersonListViewModel
    {
        public PersonListViewModel(IEnumerable<JPInfo> persons)
        {
            this.Persons = persons;
            this.Count = this.Persons.Count();
        }

        public int Count { get; }

        public IEnumerable<JPInfo> Persons { get; }
    }
}
