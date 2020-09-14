using System;
using System.Collections.Generic;

namespace gendei.Entities
{
    public class User
    {
        public User()
        {
            Addresses = new HashSet<Address>();
            Contacts = new HashSet<Contact>();
            Sessions = new HashSet<Session>();
            AttendantServiceRel = new HashSet<AttendantServiceRel>();
            ScheduleAttendant = new HashSet<Schedule>();
            ScheduleClient = new HashSet<Schedule>();
            ScheduleConfig = new HashSet<ScheduleConfig>();

        }

        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public bool Active { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<AttendantServiceRel> AttendantServiceRel { get; set; }
        public virtual ICollection<Schedule> ScheduleAttendant { get; set; }
        public virtual ICollection<Schedule> ScheduleClient { get; set; }
        public virtual ICollection<ScheduleConfig> ScheduleConfig { get; set; }

    }
}