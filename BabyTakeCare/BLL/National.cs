using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class National
    {
        //properties
        private DataRow dr;
        private int nationalNum;
        private string nationalDescription;

        //constructor
        public National() { }

        public National(DataRow dr)
        {
            this.Dr = dr;
            nationalNum = Convert.ToInt32(dr["numberNa"]);
            nationalDescription = dr["descNa"].ToString();
        }

        public void FillDataRow()
        {
            Dr["numberNa"] = nationalNum;
            Dr["descNa"] = nationalDescription;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int NationalNum { get => nationalNum; set => nationalNum = value; }
        public string NationalDescription { get => nationalDescription; set => nationalDescription = value; }

        public override string ToString()
        {
            return nationalDescription;
        }

    }
}
