using Appointments.Entity;
using Appointments.Entity.DTO;
using Appointments.Entity.Response;
using Appointments.Manager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCaching;
using System.Net;

namespace Appointments.Controller
{
    [Route("api/v1/AppointmentManager/Appointment")]
    [ApiController]
    public class AppointmentsController: ControllerBase
    {
       
        private Appointment appointment;
        private AppointmentsManager appointmentsManager;
     public AppointmentsController(AppointmentsManager _appointmentsManager)
        {

            appointmentsManager = _appointmentsManager;

        }

        [HttpPost]
        [Route("createAppointment")]

        public async Task<IActionResult> CreateAppointment(
                 [FromBody] AppointmentsDTO appointmentsDTO
            )
        {

            var result = await appointmentsManager.CreateAppointment(appointmentsDTO);
            return StatusCode(result.HttpStatus, result);
            
        }

        [HttpGet]
        [Route("getAppointment/{appointmentId}")]

        public async Task<IActionResult> getAppointmentById(
                string AppointmentId
            )
        {

            var result = await appointmentsManager.GetAppointmentsById(AppointmentId);
            return StatusCode(result.HttpStatus, result);

        }

        [HttpGet]
        [Route("getAppointmentByName/{title}")]

        public async Task<IActionResult> getAppointmentByName(
                string title
            )
        {

            var result = await appointmentsManager.FindAppointmentByName(title);
            return StatusCode(result.HttpStatus, result);

        }

        [HttpPost]
        [Route("deleteAppointment/{appointmentId}")]
        public async Task<IActionResult> DeleteAppointment(
           string AppointmentId
            )
        {

            var result = await appointmentsManager.DeleteAppointment(AppointmentId);
            return StatusCode(result.HttpStatus,result);


        }

    }
    }
