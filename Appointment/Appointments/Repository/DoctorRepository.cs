using Appointments.Database;
using Appointments.Entity;
using MongoDB.Driver;

namespace Appointments.Repository
{
    public class DoctorRepository
    {
        public readonly Context _context;

        public DoctorRepository(Context context)
        {
            _context = context;
        }

        public async Task create(Doctor doctor)
        {
            await _context.doctors.InsertOneAsync(doctor);
        }

        public async Task Delete(Doctor doctor)
        {
            FilterDefinition<Doctor> query = Builders<Doctor>.Filter.Where(x => x.Id == doctor.Id);

            await _context.doctors.DeleteOneAsync(query);
        }

        public async Task<Doctor> Find(FilterDefinition<Doctor> filter)
        {

            return (await _context.doctors.FindAsync<Doctor>(filter)).FirstOrDefault();

        }

        public async Task<Doctor> Get(string id)
        {
            FilterDefinition<Doctor> query = Builders<Doctor>.Filter.Where(x => x.Id == id);

            return (await _context.doctors.FindAsync<Doctor>(query)).FirstOrDefault();
        }

        public async Task Update(Doctor doctor)
        {

            await _context.doctors.ReplaceOneAsync(filter: x => x.Id == doctor.Id, replacement: doctor);

        }

    }
}
