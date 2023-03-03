using Appointments.Entity;
using MongoDB.Driver;

namespace Appointments.Repository
{
    public interface IDoctorRepository
    {

        Task<Doctor> Get(string id);

        Task<Doctor> Find(FilterDefinition<Doctor> filter);

        Task Update(Doctor hospital);
        Task Delete(Doctor hospital);
        Task create(Doctor hospital);


    }
}
