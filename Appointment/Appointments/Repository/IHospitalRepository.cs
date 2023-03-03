using Appointments.Entity;
using MongoDB.Driver;

namespace Hospitals.Repository
{
    public interface IHospitalRepository
    {


        Task<Hospital> Get(string id);

        Task<Hospital> Find(FilterDefinition<Hospital> filter);

        Task Update(Hospital hospital);
        Task Delete(Hospital hospital);
        Task create(Hospital hospital);

    }
}
