using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class Freqenty
    {
        //properties
        DataRow dr;
        private int freqentyKode;
        private string freqentyDis;

        //constructor
        public Freqenty() { }

        public Freqenty(DataRow dr)
        {
            this.Dr = dr;
            FreqentyKode = Convert.ToInt32(dr["freqentyKode"]);
            FreqentyDis = dr["freqentyDis"].ToString();
        }

        public void FillDataRow()
        {
            Dr["freqentyKode"] = FreqentyKode;
            Dr["freqentyDis"] = FreqentyDis;

        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int FreqentyKode { get => freqentyKode; set => freqentyKode = value; }
        public string FreqentyDis { get => freqentyDis; set => freqentyDis = value; }

        public override string ToString()
        {
            return freqentyDis;
        }




    }
}
