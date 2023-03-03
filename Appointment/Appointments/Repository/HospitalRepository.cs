
using Appointments.Entity;
using Appointments.Database;
using Appointments.Entity;
using MongoDB.Driver;

namespace Hospitals.Repository
{
    public class HospitalRepository
    {

        public readonly Context _context;

        public HospitalRepository(Context context)
        {
            _context = context;
        }

        public async Task create(Hospital hospital)
        {
            await _context.hospitals.InsertOneAsync(hospital);
        }

        public async Task Delete(Hospital hospital)
        {
            FilterDefinition<Hospital> query = Builders<Hospital>.Filter.Where(x => x.Id == hospital.Id);

            await _context.hospitals.DeleteOneAsync(query);
        }

        public async Task<Hospital> Find(FilterDefinition<Hospital> filter)
        {

            return (await _context.hospitals.FindAsync<Hospital>(filter)).FirstOrDefault();

        }

        public async Task<Hospital> Get(string id)
        {
            FilterDefinition<Hospital> query = Builders<Hospital>.Filter.Where(x => x.Id == id);

            return (await _context.hospitals.FindAsync<Hospital>(query)).FirstOrDefault();
        }

        public async Task Update(Hospital hospital)
        {

            await _context.hospitals.ReplaceOneAsync(filter: x => x.Id == hospital.Id, replacement: hospital);

        }

    }
}
