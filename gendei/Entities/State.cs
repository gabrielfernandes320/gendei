using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gendei.Entities
{
    public class State
    {
        public State()
        {
            Cities = new HashSet<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country{ get; set; }
        public virtual ICollection<City> Cities { get; set; }

}
}
