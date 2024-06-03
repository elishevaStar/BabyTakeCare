using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class Kind
    {
        //properties
        private DataRow dr;
        private int kindKode;
        private string kindDis;

        //constructor
        public Kind() { }

        public Kind(DataRow dr)
        {
            this.Dr = dr;
            kindKode = Convert.ToInt32(dr["kindKode"]);
            kindDis = dr["kindDis"].ToString();
        }

        public void FillDataRow()
        {
            Dr["kindKode"] = kindKode;
            Dr["kindDis"] = kindDis;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int KindKode { get => kindKode; set => kindKode = value; }
        public string KindDis { get => kindDis; set => kindDis = value; }

        public override string ToString()
        {
            return kindDis;
        }
    }
}
