using System;
using System.Collections.Generic;
using gendei.Models;

namespace gendei.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public bool IsMainContact { get; set; }
        public virtual User User { get; set; }
    }
}
