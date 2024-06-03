using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class BabyDB:GeneralDB
    {
        //property
        List<Baby> lstBabies = new List<Baby>();

        //constructor
        public BabyDB() : base("tbl_Baby") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstBabies.Add(new Baby(dr));
            }
        }

        public List<Baby> GetLstBabies()
        {
            lstBabies.Clear();
            DataTableToList();
            return lstBabies;
        }
        public Baby Find(string code)
        {
            return GetLstBabies().Find(x => x.IdNumB == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(string code)
        {
            Baby b = this.Find(code);
            if (b != null)
            {
                b.Dr.Delete();
                this.UpDate();
            }
        }

        //Delete status
        public void DeleteStatus(string code)
        {
            Baby b = this.Find(code);
            if (b != null)
            {
                b.Status = false;
                this.UpDateRow(b);
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(Baby b)
        {
            b.FillDataRow();
            this.UpDate();
        }

        //Add new Baby
        public void AddNew(Baby b)
        {
            b.Dr = table.NewRow();
            b.FillDataRow();
            this.Add(b.Dr);
        }
    }
}
