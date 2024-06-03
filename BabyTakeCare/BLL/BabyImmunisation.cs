using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class BabyImmunisation
    {
        //properties
        private DataRow dr;
        private int immunisationKode;
        private int visitKode;
        private DateTime expirtyDate;
        private int portionNum;
        private string status;

        //constructor
        public BabyImmunisation() { }

        public BabyImmunisation(DataRow dr)
        {
            this.Dr = dr;
            status = dr["status"].ToString();
            immunisationKode = Convert.ToInt32(dr["numberI"]);
            visitKode = Convert.ToInt32(dr["visit"]);
            expirtyDate = Convert.ToDateTime(dr["expirtyDate"]);
            portionNum = Convert.ToInt32(dr["portionNum"]);
        }

        public void FillDataRow()
        {
            Dr["status"] = status;
            Dr["numberI"] = immunisationKode;
            Dr["visit"] = visitKode;
            Dr["expirtyDate"] = expirtyDate;
            Dr["portionNum"] = portionNum;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int ImmunisationKode { get => immunisationKode; set => immunisationKode = value; }
        public int VisitKode { get => visitKode; set => visitKode = value; }
        public DateTime ExpirtyDate { get => expirtyDate; set => expirtyDate = value; }
        public int PortionNum { get => portionNum; set => portionNum = value; }
        public string Status { get => status; set => status = value; }

        //Return immunistation as a noun
        public Immunisation ImmunistationOfBabyImmunistation()
        {
            ImmunisationDB tblImmunistation = new ImmunisationDB();
            return tblImmunistation.Find(immunisationKode);
        }

        //Return appointment as a noun
        public Appointment AppointmentOfBabyImmunistation()
        {
            AppointmentDB tblAppointment = new AppointmentDB();
            return tblAppointment.Find(visitKode);
        }

        //Return immunistationTime as a noun
        public ImmunisationTime ImmunstionTimeOfBabyImmunistation()
        {
            ImmunisationTimeDB tblAImmTime = new ImmunisationTimeDB();
            return tblAImmTime.Find(immunisationKode,portionNum);
        }
    }
}
