using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class NationalDB : GeneralDB
    {
        //property
        List<National> lstNationals = new List<National>();

        //constructor
        public NationalDB(): base("tbl_nationals") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstNationals.Add(new National(dr));
            }
        }

        public List<National> GetLstNationals()
        {
            lstNationals.Clear();
            DataTableToList();
            return lstNationals;
        }

        //Search for national by nationalNum
        public National Find(int code)
        {
            return this.GetLstNationals().Find(x => x.NationalNum == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            National n = this.Find(code);
            if (n != null)
            {
                n.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(National n)
        {
            n.FillDataRow();
            this.UpDate();
        }

        //Add new National
        public void AddNew(National n)
        {
            n.Dr = table.NewRow();
            n.FillDataRow();
            this.Add(n.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstNationals().Max(x => x.NationalNum) + 1;
        }

    }
}
