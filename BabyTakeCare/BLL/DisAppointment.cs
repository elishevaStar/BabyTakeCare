using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class DisAppointment
    {
        //properties
        private DataRow dr;
        private int visitDisKode;
        private string visitDis;
        private double visitDuration;

        //constructor
        public DisAppointment() { }

        public DisAppointment(DataRow dr)
        {
            this.Dr = dr;
            visitDisKode = Convert.ToInt32(dr["numVisitDis"]);
            visitDis = dr["visitDiscrabition"].ToString();
            visitDuration = Convert.ToInt32(dr["duration"]);
        }

        public void FillDataRow()
        {
            Dr["numVisitDis"] = visitDisKode;
            Dr["visitDiscrabition"] = visitDis;
            Dr["duration"] = visitDuration;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int VisitDisKode { get => visitDisKode; set => visitDisKode = value; }
        public string VisitDis { get => visitDis; set => visitDis = value; }
        public double VisitDuration { get => visitDuration; set => visitDuration = value; }
    }
}
