using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class Appointment
    {
        //properties
        private DataRow dr;
        private int visitKode;
        private string idNumB;
        private string idNumW;
        private DateTime visitDate;
        private DateTime visitHour;
        private string attendantInformation;
        private string motherInformation;
        private int visitDisKode;
        private bool status;
        private string notes;

        //constructor
        public Appointment() { }

        public Appointment(DataRow dr)
        {
            this.Dr = dr;
            visitKode = Convert.ToInt32(dr["numVisit"]);
            idNumB = dr["numIdB"].ToString();
            idNumW = dr["idnumW"].ToString();
            visitDate= Convert.ToDateTime(dr["dateV"]);
            AttendantInformation = dr["attendantInformation"].ToString();
            MotherInformation = dr["motherInformation"].ToString();
            //  visitHour= Convert.ToDateTime( dr["hourV"]);
            visitDisKode = Convert.ToInt32(dr["numVisitDis"]);
            Status = Convert.ToBoolean(dr["status"]);
            Notes = dr["notes"].ToString();
        }

        public void FillDataRow()
        {
            Dr["numVisit"] = visitKode;
            Dr["numIdB"] = idNumB;
            Dr["idnumW"] = idNumW;
            Dr["dateV"] = visitDate ;
            //  Dr["hourV"] = visitHour;
            Dr["attendantInformation"] = AttendantInformation;
            Dr["motherInformation"] = MotherInformation;
            Dr["numVisitDis"] = visitDisKode;
            Dr["status"] = Status;
            Dr["notes"] = Notes;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int VisitKode { get => visitKode; set => visitKode = value; }
        public string IdNumB { get => idNumB; set => idNumB = value; }
        public string IdNumW { get => idNumW; set => idNumW = value; }
        public DateTime Date { get => visitDate; set => visitDate = value; }
        public DateTime VisitHour { get => visitHour; set => visitHour = value; }
        public int VisitDisKode { get => visitDisKode; set => visitDisKode = value; }
        public bool Status { get => status; set => status = value; }
        public string Notes { get => notes; set => notes = value; }
        public string AttendantInformation { get => attendantInformation; set => attendantInformation = value; }
        public string MotherInformation { get => motherInformation; set => motherInformation = value; }

        //Return baby as a noun
        public Baby BabyOfBabyAppointment()
        {
            BabyDB tblBaby = new BabyDB();
            return tblBaby.Find(idNumB);
        }

        //Return disAppointment as a noun
        public DisAppointment DisAppointmentOfAppointment()
        {
            DisAppointmentDB tblDisAppointment = new DisAppointmentDB();
            return tblDisAppointment.Find(visitDisKode);
        }

        //Return worker as a noun
        public Worker WorkerOfAppointment()
        {
            WorkerDB tblWorker = new WorkerDB();
            return tblWorker.Find(idNumW);
        }




    }
}
