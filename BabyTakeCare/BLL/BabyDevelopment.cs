using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class BabyDevelopment
    {
        //properties
        private DataRow dr;
        private int developmentKode;
        private int visitKode;
        private DateTime developmentDate;
        private string result;

        //constructor
        public BabyDevelopment() { }

        public BabyDevelopment(DataRow dr)
        {
            this.Dr = dr;
            developmentKode = Convert.ToInt32(dr["numberDe"]);
            visitKode = Convert.ToInt32(dr["numVisit"]);
            developmentDate = Convert.ToDateTime(dr["dateDe"]);
            Result = dr["result"].ToString();
        }

        public void FillDataRow()
        {
            Dr["numberDe"] = developmentKode;
            Dr["numVisit"] = visitKode;
            Dr["dateDe"] = developmentDate;
            Dr["result"] = Result;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int DevelopmentKode { get => developmentKode; set => developmentKode = value; }
        public int VisitKode { get => visitKode; set => visitKode = value; }
        public DateTime Date { get => developmentDate; set => developmentDate = value; }
        public string Result { get => result; set => result = value; }
    }
}
