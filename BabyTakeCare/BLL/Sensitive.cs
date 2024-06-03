using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class Sensitive
    {
        //properties
        private DataRow dr;
        private int sensitiveKode;
        private string sensitiveDis;
        private string notes;

        //constructor
        public Sensitive() { }

        public Sensitive(DataRow dr)
        {
            this.Dr = dr;
            sensitiveKode = Convert.ToInt32(dr["numberSe"]);
            sensitiveDis = dr["descSe"].ToString();
            notes = dr["notes"].ToString();
        }

        public void FillDataRow()
        {
            Dr["numberSe"] = sensitiveKode;
            Dr["descSe"] = sensitiveDis;
            Dr["notes"] = notes;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int SensitiveKode { get => sensitiveKode; set => sensitiveKode = value; }
        public string SensitiveDis { get => sensitiveDis; set => sensitiveDis = value; }
        public string Notes { get => notes; set => notes = value; }

        public override string ToString()
        {
            return sensitiveDis;
        }

    }
}
