using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class Subject
    {
        //properties
        private DataRow dr;
        private int subjectKode;
        private string subjectDis;

        //constructor
        public Subject() { }

        public Subject(DataRow dr)
        {
            this.Dr = dr;
            subjectKode = Convert.ToInt32(dr["numberSub"]);
            subjectDis = dr["descSub"].ToString();
        }

        public void FillDataRow()
        {
            Dr["numberSub"] = subjectKode;
            Dr["descSub"] = subjectDis;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int SubjectKode { get => subjectKode; set => subjectKode = value; }
        public string SubjectDis { get => subjectDis; set => subjectDis = value; }

        public override string ToString()
        {
            return subjectDis;
        }
    }
}
