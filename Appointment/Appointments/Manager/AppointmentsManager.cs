using Appointments.Repository;
using Appointments.Entity.Response;
using Appointments.Entity;
using Appointments.Entity.DTO;
using System.Net;
using MongoDB.Driver;
using AutoMapper;
using System.Xml.Linq;

namespace Appointments.Manager
{
    public class AppointmentsManager
    {
        private readonly IMapper mapper;
        public MongoRepository MongoRepository { get; }

        public AppointmentsManager(MongoRepository mongoRepository,IMapper _mapper)
        {
            MongoRepository = mongoRepository;
            mapper = _mapper;   
        }

        public async Task<Response> CreateAppointment(AppointmentsDTO appointmentsDTO)
        {
            var checkAppointment = await MongoRepository.FindAsync<Appointment>(c => c.appointmentId == appointmentsDTO.AppointmentId);

            if (checkAppointment != null)
            {
                return new Response
                {
                    Message = "Appointment already exists",
                    HttpStatus = (int)HttpStatusCode.BadRequest
                };
            }

            var appointment = new Appointment
            {
                appointmentId = Guid.NewGuid().ToString(),
                startTime = appointmentsDTO.StartTime,
                endTime = appointmentsDTO.EndTime,
                location = appointmentsDTO.Location,
                status = appointmentsDTO.Status,
                title = appointmentsDTO.Title,
                
            };

            await MongoRepository.CreateAsync(appointment);

            return new Response
            {
                HttpStatus = (int)HttpStatusCode.OK,
                Message = "Success"
            };
        }

        public async Task<Response> GetAppointmentsById(string AppointmentId)
        {

            var checkAppointment = await MongoRepository.FindAsync<Appointment>(c => c.appointmentId == AppointmentId);
            
            var model = mapper.Map<AppointmentsDTO>(checkAppointment);

            if(checkAppointment == null)
            {
                return new Response()
                {
                    HttpStatus = (int)HttpStatusCode.NotFound,
                    Message = "Appointment doesn't exist"
                };

            }

            return new Response()
            {
                Message = "success",
                HttpStatus = (int)HttpStatusCode.OK,
                Data = model

            };

        }

        public async Task<Response> FindAppointmentByName(string title)
        {
            try { 
            List<Appointment> appointments = new(
              await MongoRepository.FindAllAsync<Appointment>(x =>x.title.ToLower().StartsWith(title.ToLower()))
                );

            List<AppointmentsDTO> model = mapper.Map<List<Appointment>, List<AppointmentsDTO>>(appointments);

            return new Response()
            {
                Data = model,

                HttpStatus = 200
            };
             }
            catch (Exception e)
            {
                return new Response()
             {
            Message = e.Message,

                    HttpStatus = (int)HttpStatusCode.InternalServerError
                };
              }

         }
        public async Task<Response> DeleteAppointment(string appointmentId)
        {
            try
            {
                await MongoRepository.DeleteByIdAsync<Appointment>(appointmentId);
            }
            catch (Exception e)
            {
                return new Response()
                {
                    Message = e.Message,
                    HttpStatus = (int)HttpStatusCode.InternalServerError
                };
            }

            return new Response()
            {
                HttpStatus = (int)HttpStatusCode.OK,
                Message = "Appointment Deleted"
            };
        }
    }
}
