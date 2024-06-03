using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class SensitiveLevel
    {
        //properties
        private DataRow dr;
        private int levelKode;
        private string levelDis;

        ///constructor
        public SensitiveLevel(DataRow dr)
        {
            this.Dr = dr;
            levelKode = Convert.ToInt32(dr["levelKode"]);
            levelDis = dr["levelDis"].ToString();
        }

        public void FillDataRow()
        {
            Dr["levelKode"] = levelKode;
            Dr["levelDis"] = levelDis;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int LevelKode { get => levelKode; set => levelKode = value; }
        public string LevelDis { get => levelDis; set => levelDis = value; }

        public override string ToString()
        {
            return levelDis;
        }

    }
}
