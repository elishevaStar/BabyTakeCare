using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class Development
    {
        //properties
        private DataRow dr;
        private int developmentKode;
        private string developmentName;
        private int developmentMinAge;
        private int developmentMaxAge;
        private int developmentKind;
        private bool status;

        //constructor
        public Development() { }
        
        public Development(DataRow dr)
        {
            this.Dr = dr;
            developmentKode = Convert.ToInt32(dr["numberDe"]);
            DevelopmentName = dr["nameDe"].ToString();
            DevelopmentMinAge = Convert.ToInt32(dr["ageDeMin"]);
            DevelopmentMaxAge = Convert.ToInt32(dr["ageDeMax"]);
            developmentKind = Convert.ToInt32(dr["numKindDe"]);
            status = Convert.ToBoolean(dr["status"]);
        }

        public void FillDataRow()
        {
            Dr["numberDe"] = developmentKode;
            Dr["nameDe"] = DevelopmentName;
            Dr["ageDeMin"] = DevelopmentMinAge;
            Dr["ageDeMax"] = DevelopmentMaxAge;
            Dr["numKindDe"] = developmentKind;
            Dr["status"] = status;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int DevelopmentKode
        {
            get => developmentKode; set
            {
                if (!Validation.IsNum(value.ToString()))
                    throw new Exception("יש להכניס מספרים!");
                developmentKode = value;
            }
        }
       
        
        public int DevelopmentKind { get => developmentKind; set => developmentKind = value; }
        public bool Status { get => status; set => status = value; }
        public int DevelopmentMinAge { get => developmentMinAge; set => developmentMinAge = value; }
        public int DevelopmentMaxAge { get => developmentMaxAge; set => developmentMaxAge = value; }
        public string DevelopmentName { get => developmentName; set => developmentName = value; }

        //Return DisDevelopment as a noun
        public DisDevelopment DisDevelopmentOfDevelopment()
        {
            DisDevelopmentDB tblDisDevelopment = new DisDevelopmentDB();
            return tblDisDevelopment.Find(developmentKind);
        }
    }
}
