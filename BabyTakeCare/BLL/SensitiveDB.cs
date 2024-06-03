using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class SensitiveDB:GeneralDB
    {
        //property
        List<Sensitive> lstSensitives = new List<Sensitive>();

        //constructor
        public SensitiveDB() : base("tbl_sensitives") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstSensitives.Add(new Sensitive(dr));
            }
        }

        public List<Sensitive> GetLstSensitives()
        {
            lstSensitives.Clear();
            DataTableToList();
            return lstSensitives;
        }

        //Search for sensitive by sensitiveKode
        public Sensitive Find(int code)
        {
            return this.GetLstSensitives().Find(x => x.SensitiveKode == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            Sensitive s = this.Find(code);
            if (s != null)
            {
                s.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(Sensitive s)
        {
            s.FillDataRow();
            this.UpDate();
        }

        //Add new Sensitive
        public void AddNew(Sensitive s)
        {
            s.Dr = table.NewRow();
            s.FillDataRow();
            this.Add(s.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstSensitives().Max(x => x.SensitiveKode) + 1;
        }
    }
}
