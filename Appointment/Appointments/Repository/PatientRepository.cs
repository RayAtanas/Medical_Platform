using Appointments.Database;
using Appointments.Entity;
using MongoDB.Driver;

namespace Appointments.Repository
{
    public class PatientRepository
    {

        public readonly Context _context;

        public PatientRepository(Context context)
        {
            _context = context;
        }

        public async Task create(Patient patient)
        {
            await _context.patients.InsertOneAsync(patient);
        }

        public async Task Delete(Patient patient)
        {
            FilterDefinition<Patient> query = Builders<Patient>.Filter.Where(x => x.Id == patient.Id);

            await _context.patients.DeleteOneAsync(query);
        }

        public async Task<Patient> Find(FilterDefinition<Patient> filter)
        {

            return (await _context.patients.FindAsync<Patient>(filter)).FirstOrDefault();

        }

        public async Task<Patient> Get(string id)
        {
            FilterDefinition<Patient> query = Builders<Patient>.Filter.Where(x => x.Id == id);

            return (await _context.patients.FindAsync<Patient>(query)).FirstOrDefault();
        }

        public async Task Update(Patient patient)
        {

            await _context.patients.ReplaceOneAsync(filter: x => x.Id == patient.Id, replacement: patient);

        }


    }
}
