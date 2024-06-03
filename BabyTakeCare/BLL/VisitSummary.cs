using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class VisitSummary
    {
        //properties
        private DataRow dr;
        private int developmentKode;
        private int visitKode;
        private string attendantInformation;
        private string motherInformation;
        private string developmentResult;
        private bool status;
        private string notes;

        //constructor
        public VisitSummary() { }

        public VisitSummary(DataRow dr)
        {
            this.Dr = dr;
            developmentKode = Convert.ToInt32(dr["numberDe"]);
            visitKode = Convert.ToInt32(dr["visit"]);
            attendantInformation = dr["attendantInformation"].ToString();
            motherInformation = dr["motherInformation"].ToString();
            developmentResult = dr["resultDe"].ToString();
            status = Convert.ToBoolean(dr["status"]);
            notes = dr["notes"].ToString();
        }

        public void FillDataRow()
        {
            Dr["numberDe"] = developmentKode;
            Dr["visit"] = visitKode;
            Dr["attendantInformation"] = attendantInformation;
            Dr["motherInformation"] = motherInformation;
            Dr["resultDe"] = developmentResult;
            Dr["status"] = status;
            Dr["notes"] = notes;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int DevelopmentKode { get => developmentKode; set => developmentKode = value; }
        public int VisitKodee { get => visitKode; set => visitKode = value; }
        public string AttendantInformation { get => attendantInformation; set => attendantInformation = value; }
        public string MotherInformation { get => motherInformation; set => motherInformation = value; }
        public string DevelopmentResult { get => developmentResult; set => developmentResult = value; }
        public bool Status { get => status; set => status = value; }
        public string Notes { get => notes; set => notes = value; }

        //Return development as a noun
        public Development DevelopmentOfVisitSummary()
        {
            DevelopmentDB tblDevelopment = new DevelopmentDB();
            return tblDevelopment.Find(developmentKode);
        }

        //Return appointment as a noun
        public Appointment AppointmentOfVisitSummary()
        {
            AppointmentDB tblAppointment = new AppointmentDB();
            return tblAppointment.Find(visitKode);
        }
    }
}
