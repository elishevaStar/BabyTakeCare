using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class Immunisation
    {
        //properties
        private DataRow dr;
        private int immunisationKode;
        private string immunisationName;
        private string timeEffect;
        private int numPoration;
        private bool status;
        private string way;

        //constructor
        public Immunisation() { }

        public Immunisation(DataRow dr)
        {
            this.Dr = dr;
            immunisationKode = Convert.ToInt32(dr["numIm"]);
            immunisationName = dr["nameIm"].ToString();
            timeEffect = dr["timeEffect"].ToString();
            numPoration = Convert.ToInt32(dr["numPortions"]);
            status = Convert.ToBoolean(dr["status"]);
            Way = dr["way"].ToString();
        }

        public void FillDataRow()
        {
            Dr["numIm"] = immunisationKode;
            Dr["nameIm"] = immunisationName;
            Dr["timeEffect"] = timeEffect;
            Dr["numPortions"] = numPoration;
            Dr["status"] = status;
            Dr["way"] = Way;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int ImmunisationKode
        {
            get => immunisationKode; set
            {
                if (!Validation.IsNumDouble(value.ToString()))
                    throw new Exception("יש להכניס מספרים!");
                immunisationKode = value;
            }
        }
        public string ImmunisationName
        {
            get => immunisationName; set
            {
                if (!Validation.IsHebrew(value))
                    throw new Exception("יש להכניס אותיות בעברית! ");
                immunisationName = value;
            }
        }
        public string TimeEffect { get => timeEffect; set => timeEffect = value; }
        public int NumPoration
        {
            get => numPoration; set
            {
                if (!Validation.IsNumDouble(value.ToString()))
                    throw new Exception("יש להכניס מספרים!");
               numPoration = value;
            }
        }
        public bool Status { get => status; set => status = value; }
        public string Way { get => way; set => way = value; }
    }
}
