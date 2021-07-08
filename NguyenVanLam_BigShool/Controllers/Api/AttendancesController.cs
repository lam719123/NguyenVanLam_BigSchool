using Microsoft.AspNet.Identity;
using NguyenVanLam_BigShool.DTO;
using NguyenVanLam_BigShool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenVanLam_BigShool.Controllers.Api
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;

        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDTO)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDTO.courseId))
            {
                return BadRequest("The Attendance already exits");
            }
            var attendance = new Attendance
            {
                CourseId = attendanceDTO.courseId,
                AttendeeId = userId


            };

            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();

            return Ok();

        }
    }
}
