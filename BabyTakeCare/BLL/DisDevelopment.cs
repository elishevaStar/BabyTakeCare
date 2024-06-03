using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class DisDevelopment
    {
        //properties
        private DataRow dr;
        private int disDevelopmentKode;
        private string developmentDis;

        //constructor
        public DisDevelopment() { }

        public DisDevelopment(DataRow dr)
        {
            this.Dr = dr;
            disDevelopmentKode = Convert.ToInt32(dr["numDeDis"]);
            developmentDis = dr["discrabition"].ToString();
        }

        public void FillDataRow()
        {
            Dr["numDeDis"] = disDevelopmentKode;
            Dr["discrabition"] = developmentDis;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int DisDevelopmentKode
        {
            get => disDevelopmentKode; set
            {
                if (!Validation.IsNum(value.ToString()))
                    throw new Exception("יש להכניס מספרים!");
                disDevelopmentKode = value;
            }
        }
        public string DevelopmentDis
        {
            get => developmentDis; set
            {
                if (!Validation.IsHebrew(value))
                    throw new Exception("יש להכניס אותיות בעברית! ");
               developmentDis = value;
            }
        }

        public override string ToString()
        {
            return developmentDis;
        }
    }
}
