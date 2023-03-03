using Appointments.Entity;
using MongoDB.Driver;

namespace Appointments.Repository
{
    public interface IPatientRepository
    {
        Task<Patient> Get(string id);

        Task<Patient> Find(FilterDefinition<Patient> filter);

        Task Update(Patient patient);
        Task Delete(Patient patient);
        Task create(Patient patient);

    }
}
