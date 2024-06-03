using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class ImmunisationTime
    {
        //properties
        private DataRow dr;
        private int immunisationKode;
        private int age;
        private string ageKind;
        private string range;
        private int numPortion;
        private bool status;
        public int index;
        //constructor
        public ImmunisationTime() { }

        public ImmunisationTime(DataRow dr)
        {
            this.Dr = dr;
            immunisationKode = Convert.ToInt32(dr["numberIm"]);
            age =Convert.ToInt32( dr["ageI"]);
            range = dr["range"].ToString();
            numPortion = Convert.ToInt32(dr["numPortion"]);
            status = Convert.ToBoolean(dr["status"]);
            AgeKind = dr["kindAgeI"].ToString();
        }

        public void FillDataRow()
        {
            Dr["numberIm"] = immunisationKode;
            Dr["ageI"] = age;
            Dr["range"] = range;
            Dr["numPortion"] = numPortion;
            Dr["status"] = status;
            Dr["kindAgeI"] = ageKind;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int ImmunisationKode { get => immunisationKode; set => immunisationKode = value; }
        public int Age { get => age; set => age = value; }
        public int NumPortion
        {
            get => numPortion; set
            {
                if (!Validation.IsNumDouble(value.ToString()))
                    throw new Exception("יש להכניס מספרים!");
               numPortion = value;
            }
        }
        public string Range { get => range; set => range = value; }
        public bool Status { get => status; set => status = value; }
        public string AgeKind { 
            get {
                if (ageKind == "יום")
                    index = 1;
                else if (ageKind == "שבוע")
                    index = 2;
                else
                    index = 3;
               return ageKind;
            }
            set {
                ageKind = value;
                if (value == "יום")
                    index = 1;
                else if (value == "שבוע")
                    index = 2;
                else
                    index = 3;
            } 
        }

        public int AgePortionINDays()
        {
            if (age<5 && index == 1)
                return 0;
            if (index == 1)
                return age;
            if (index == 2)
                return age * 7;
            return age * 30;
        }

        public int AgePortionINDaysRange()
        {
            if (numPortion > 1)
            {
                ImmunisationTimeDB tblImmt = new ImmunisationTimeDB();
                ImmunisationTime immT = tblImmt.GetLstImmunisationTimes().FirstOrDefault(x => x.ImmunisationKode == this.immunisationKode && x.NumPortion == this.NumPortion - 1);
                if (immT != null)
                    return this.AgePortionINDays()- immT.AgePortionINDays();
                
            }
            return 0;
        }
        public override string ToString()
        {
            return age + " " + ageKind;
        }


    }


}
