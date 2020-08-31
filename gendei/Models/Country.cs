using System.Collections.Generic;

namespace gendei.Models
{
    public class Country
    {
        public Country()
        {
            States = new HashSet<State>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}