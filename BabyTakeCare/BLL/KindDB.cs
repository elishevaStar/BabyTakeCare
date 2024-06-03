using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class KindDB:GeneralDB
    {
        //property
        List<Kind> lstKindes = new List<Kind>();

        //constructor
        public KindDB() : base("tbl_kinds") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstKindes.Add(new Kind(dr));
            }
        }

        public List<Kind> GetLstKindes()
        {
            lstKindes.Clear();
            DataTableToList();
            return lstKindes;
        }
        public Kind Find(int code)
        {
            return GetLstKindes().Find(x => x.KindKode == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            Kind k = this.Find(code);
            if (k!= null)
            {
                k.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(Kind k)
        {
            k.FillDataRow();
            this.UpDate();
        }

        //Add new Kind
        public void AddNew(Kind k)
        {
            k.Dr = table.NewRow();
            k.FillDataRow();
            this.Add(k.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstKindes().Max(x => x.KindKode) + 1;
        }

    }
}
