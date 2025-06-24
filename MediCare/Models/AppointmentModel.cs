using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediCare.Data;

namespace MediCare.Models
{
    public class AppointmentModel
    {

        public int AppointmentID { get; set; }
        public string AppointmentCode { get; set; }
        public Nullable<int> PatientID { get; set; }
        public Nullable<int> DoctorID { get; set; }
        public System.DateTime AppointmentDate { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public string Notes { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }


        public string SaveAppointment(AppointmentModel model)
        {
            string Message = "successfully submit";
            HMSOrgSoftEntities db = new HMSOrgSoftEntities();
            if (model.AppointmentID == 0)
            {
                var data = new Appointment()
                {
                    AppointmentID = model.AppointmentID,
                    AppointmentCode = model.AppointmentCode,
                    PatientID = 1,
                    DoctorID = 1,
                    AppointmentDate = model.AppointmentDate,
                    StartTime = model.StartTime,
                    EndTime = model.EndTime,
                    Status = model.Status,
                    Reason = model.Reason,
                    Notes = model.Notes,
                    CreatedBy = model.CreatedBy,
                    CreatedAt = model.CreatedAt,

                };
                db.Appointments.Add(data);
                db.SaveChanges();
                Message = "User Data Added Sucessfully";
            }
            else
            {
                var regdata = db.Appointments.Where(r => r.AppointmentID == model.AppointmentID).FirstOrDefault();
                if (regdata != null)
                {
                    regdata.AppointmentID = model.AppointmentID;
                    regdata.AppointmentCode = model.AppointmentCode;
                    regdata.PatientID = model.PatientID;
                    regdata.DoctorID = model.DoctorID;
                    regdata.AppointmentDate = model.AppointmentDate;
                    regdata.StartTime = model.StartTime;
                    regdata.EndTime = model.EndTime;
                    regdata.Status = model.Status;
                    regdata.Reason = model.Reason;
                    regdata.Notes = model.Notes;
                    regdata.CreatedBy = model.CreatedBy;
                    regdata.CreatedAt = model.CreatedAt;

                }
                db.SaveChanges();
                Message = "User Data Updated";
            }
            return Message;
        }

    }
}