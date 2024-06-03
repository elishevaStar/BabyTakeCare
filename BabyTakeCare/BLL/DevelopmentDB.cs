using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class DevelopmentDB:GeneralDB
    {
        //property
        List<Development> lstDevelopments = new List<Development>();

        //constructor
        public DevelopmentDB() : base("tbl_developments") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstDevelopments.Add(new Development(dr));
            }
        }

        public List<Development> GetLstDevelopments()
        {
            lstDevelopments.Clear();
            DataTableToList();
            return lstDevelopments;
        }

        //Search for development by developmentKode
        public Development Find(int code)
        {
            return this.GetLstDevelopments().Find(x => x.DevelopmentKode == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            Development d = this.Find(code);
            if (d != null)
            {
                d.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(Development d)
        {
            d.FillDataRow();
            this.UpDate();
        }

        //Delete status
        public void DeleteStatus(int code)
        {
            Development d = this.Find(code);
            if (d != null)
            {
                d.Status = false;
                this.UpDateRow(d);
            }
        }

        //Add new Development
        public void AddNew(Development d)
        {
            d.Dr = table.NewRow();
            d.FillDataRow();
            this.Add(d.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstDevelopments().Max(x => x.DevelopmentKode) + 1;
        }


    }
}
