using System;
using System.Collections.Generic;

namespace gendei.Models
{
    public partial class AttendantServiceRel
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int AttendantId { get; set; }

        public virtual User Attendant { get; set; }
        public virtual Service Service { get; set; }
    }
}
