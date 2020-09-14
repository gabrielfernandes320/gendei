using System;

namespace gendei.Entities
{
    public class ScheduleConfig
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int Duration { get; set; }
        public int? DayOfWeek { get; set; }

        public virtual User User { get; set; }
    }
}