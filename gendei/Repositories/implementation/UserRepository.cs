using gendei.Entities;
using gendei.Repositories.contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gendei.Repositories.implementation
{
    public class UserRepository : IGendeiRepository<User>
    {
        private readonly gendeiContext _gendeiContext;
        private readonly IAuthRepository<User> _authRepository;

        public UserRepository(gendeiContext context, IAuthRepository<User> authRepository)
        {
            _gendeiContext = context;
            _authRepository = authRepository;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _gendeiContext.User.ToListAsync();
        }

        public async Task<User> Get(int id)
        {
            var user = await _gendeiContext.User.FindAsync(id);
            return user;
        }

        public async Task<User> Update(int id, object obj)
        {
            _gendeiContext.Entry(obj).State = EntityState.Modified;

            await _gendeiContext.SaveChangesAsync();

            return await Get(id);
        }

        public bool Exists(int id)
        {
            return _gendeiContext.User.Any(e => e.Id == id);
        }

        public async Task<User> Add(object obj)
        {
            var user = (User)obj;
            user.Password = _authRepository.GetEncryptedPassword(user.Password);

            _gendeiContext.User.Add(user);

            await _gendeiContext.SaveChangesAsync();

            return (User)obj;
        }

        public async Task<User> Delete(object obj)
        {
            _gendeiContext.User.Remove((User)obj);

            await _gendeiContext.SaveChangesAsync();
            return (User)obj;
        }

        public async Task<List<DateTime?>> GetDayAvaiableAppointments(int id, DateTime day, int dayOfWeek)
        {
            var user = await Get(id);
            var confSchedule = await _gendeiContext.ScheduleConfig.Where(x => x.UserId == id && x.DayOfWeek == dayOfWeek).FirstOrDefaultAsync();
            var availableAppointmentsList = new List<DateTime?>();
            IEnumerable<Schedule> occupedAppointments = _gendeiContext.Schedule.Where(x => x.AppointmentDate == day && x.AttendantId == id);

            DateTime dt = new DateTime(day.Year, day.Day, day.Month);
            DateTime StartTime = (DateTime)(dt + confSchedule.StartTime);
            DateTime EndTime = (DateTime)(dt + confSchedule.EndTime);
            while (StartTime != EndTime)
            {
                double minuts = (double)+confSchedule.Duration;
                StartTime = StartTime.AddMinutes(minuts);
                availableAppointmentsList.Add(StartTime);
            }

            foreach (var item in occupedAppointments)
            {
                availableAppointmentsList.RemoveAll(x => x == dt + item.StartTime);
            }

            return availableAppointmentsList;
        }
    }
}