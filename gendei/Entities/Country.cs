using System.Collections.Generic;

namespace gendei.Entities
{
    public class Country
    {
        public Country()
        {
            States = new HashSet<State>();
        }

        public int Id { get; set; }
        public string Iso { get; set; }
        public string Name { get; set; }
        public string NiceName { get; set; }
        public string Iso3 { get; set; }
        public int? NumCode { get; set; }
        public int PhoneCode { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}