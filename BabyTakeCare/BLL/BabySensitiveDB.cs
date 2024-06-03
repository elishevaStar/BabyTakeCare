using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class BabySensitiveDB:GeneralDB
    {
        //property
        List<BabySensitive> lstBabySensitives = new List<BabySensitive>();

        //constructor
        public BabySensitiveDB() : base("tbl_sensitives_Baby") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstBabySensitives.Add(new BabySensitive(dr));
            }
        }

        public List<BabySensitive> GetLstBabySensitives()
        {
            lstBabySensitives.Clear();
            DataTableToList();
            return lstBabySensitives;
        }

        //Search for babySensitive by idNumB and sensitiveKode
        public BabySensitive Find(string code1,int code2)
        {
            return this.GetLstBabySensitives().Find(x => x.IdNumB == code1 && x.SensitiveKode==code2);
        }

        //Delete row in the table by the key
        public void DeleteRow(string code1,int code2)
        {
            BabySensitive bs = this.Find(code1,code2);
            if (bs != null)
            {
                bs.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(BabySensitive bs)
        {
            bs.FillDataRow();
            this.UpDate();
        }

        //Add new BabySensitive
        public void AddNew(BabySensitive bs)
        {
            bs.Dr = table.NewRow();
            bs.FillDataRow();
            this.Add(bs.Dr);
        }

    }
}
