using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class BabySensitive
    {
        //properties
        private DataRow dr;
        private int sensitiveKode;
        private string idNumB;
        private int levelKode;
        private bool status;

        //constructor
        public BabySensitive() { }

        public BabySensitive(DataRow dr)
        {
            this.Dr = dr;
            sensitiveKode = Convert.ToInt32(dr["numberSe"]);
            idNumB = dr["idNumBaby"].ToString();
            levelKode = Convert.ToInt32(dr["levelKode"]);
            status = Convert.ToBoolean(dr["status"]);
        }

        public void FillDataRow()
        {
            Dr["numberSe"] = sensitiveKode;
            Dr["idNumBaby"] = idNumB;
            Dr["levelKode"] = levelKode;
            Dr["status"] = status;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int SensitiveKode { get => sensitiveKode; set => sensitiveKode = value; }
        public string IdNumB { get => idNumB; set => idNumB = value; }
        public int LevelKode { get => levelKode; set => levelKode = value; }
        public bool Status { get => status; set => status = value; }


        //Return baby as a noun
        public Baby BabyOfBabySensitive()
        {
            BabyDB tblBaby = new BabyDB();
            return tblBaby.Find(idNumB);
        }

        //Return sensitive as a noun
        public Sensitive SensitiveOfBabySensitive()
        {
            SensitiveDB tblSensitive = new SensitiveDB();
            return tblSensitive.Find(sensitiveKode);
        }

        //Return sensitiveLevel as a noun
        public SensitiveLevel SensitiveLevelOfBabySensitive()
        {
            SensitiveLevelDB tblSensitiveLevel = new SensitiveLevelDB();
            return tblSensitiveLevel.Find(LevelKode);
        }
    }
}
