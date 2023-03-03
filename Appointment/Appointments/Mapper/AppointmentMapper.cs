using Appointments.Entity;
using Appointments.Entity.DTO;
using AutoMapper;

namespace Appointments.Mapper
{
    public class AppointmentMapper: Profile
    {
        public AppointmentMapper()
        {

            CreateMap<Appointment, AppointmentsDTO>();
            CreateMap<AppointmentsDTO, Appointment>();
            CreateMap<DoctorDTO, Appointment>();
            CreateMap<Appointment, DoctorDTO>();
            CreateMap<PatientDTO, Patient>();
            CreateMap<Patient, PatientDTO>();
            CreateMap<Patient, Appointment>();
            CreateMap<PatientDTO,Appointment>();
            CreateMap<Appointment, PatientDTO>();

        }
    }
}
