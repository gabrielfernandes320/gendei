using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gendei.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Neighborhood { get; set; }
        public virtual City City { get; set; }
        public string Street { get; set; }
        public int? Number { get; set; }
        public string Complement { get; set; }
        public int? Postalcode { get; set; }
        public int UserId { get; set; }
        public bool IsMainAddress { get; set; }
        public virtual User User { get; set; }
    }
}
