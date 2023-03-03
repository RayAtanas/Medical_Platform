using Appointments.Entity;
using Appointments.Entity;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Appointments.Database
{
    public class Context
    {

        public IMongoDatabase database { get; }

        private IConfiguration configuration;

        public IMongoCollection<Hospital> hospitals { get; }
        public IMongoCollection<Patient> patients { get; }
        public IMongoCollection<Doctor> doctors { get; }
        public IMongoCollection<Appointment> appointments { get; }
        public Context(IConfiguration configuration)
        {
            this.configuration = configuration;

            var client = new MongoClient(
                       configuration.GetValue<string>("DataBaseSettings:ConnectionString")
                   );

            database = client.GetDatabase(
               configuration.GetValue<string>("DataBaseSettings:DatabaseName")
           );

            hospitals = database.GetCollection<Hospital>("hospitals");
            patients = database.GetCollection<Patient>("patients");
            doctors = database.GetCollection<Doctor>("doctors");
            appointments = database.GetCollection<Appointment>("appointments");

        }

    }

}

