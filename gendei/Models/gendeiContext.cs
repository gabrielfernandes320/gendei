using Microsoft.EntityFrameworkCore;

namespace gendei.Models
{
    public class gendeiContext : DbContext
    {
        public gendeiContext()
        {
        }

        public gendeiContext(DbContextOptions<gendeiContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<AttendantServiceRel> AttendantServiceRel { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<ScheduleConfig> ScheduleConfig { get; set; }
        public DbSet<Session> Session { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Schedule>(entity =>
            {
                /*entity.ToTable("Schedule");

                entity.HasIndex(e => e.Id)
                    .HasName("schedule_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppointmentDate)
                    .HasColumnName("appointment_date")
                    .HasColumnType("date");

                entity.Property(e => e.AttendantId).HasColumnName("attendant_id");

                entity.Property(e => e.Canceled).HasColumnName("canceled");

                entity.Property(e => e.CanceledReason)
                    .HasColumnName("canceled_reason")
                    .HasColumnType("character varying");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Observation).HasColumnName("observation");

                entity.Property(e => e.RegisterDate)
                    .HasColumnName("register_date")
                    .HasColumnType("date");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("time without time zone");*/

                entity.HasOne(d => d.Attendant)
                    .WithMany(p => p.ScheduleAttendant)
                    .HasForeignKey(d => d.AttendantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("schedule_user_attendant_id_fk");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ScheduleClient)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("schedule_user_client_id_fk");
            });
        }
    }
}