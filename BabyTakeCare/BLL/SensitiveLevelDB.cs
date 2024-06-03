using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class SensitiveLevelDB:GeneralDB
    {
        //property
        List<SensitiveLevel> lstSensitiveLevels = new List<SensitiveLevel>();

        //constructor
        public SensitiveLevelDB():base("tbl_sesitives_level") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstSensitiveLevels.Add(new SensitiveLevel(dr));
            }
        }

        public List<SensitiveLevel> GetLstSensitiveLevels()
        {
            lstSensitiveLevels.Clear();
            DataTableToList();
            return lstSensitiveLevels;
        }

        //Search for sensitiveLevel by levelKode
        public SensitiveLevel Find(int code)
        {
            return this.GetLstSensitiveLevels().Find(x => x.LevelKode == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            SensitiveLevel sl = this.Find(code);
            if (sl != null)
            {
                sl.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(SensitiveLevel sl)
        {
            sl.FillDataRow();
            this.UpDate();
        }

        //Add new SensitiveLevel
        public void AddNew(SensitiveLevel sl)
        {
            sl.Dr = table.NewRow();
            sl.FillDataRow();
            this.Add(sl.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstSensitiveLevels().Max(x => x.LevelKode) + 1;
        }
    }

}
