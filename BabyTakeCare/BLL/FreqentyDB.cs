using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class FreqentyDB:GeneralDB
    {
        //property
        List<Freqenty> lstFreqent = new List<Freqenty>();

        //constructor
        public FreqentyDB() : base("tbl_freqenty") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
               lstFreqent.Add(new Freqenty(dr));
            }
        }

        public List<Freqenty> GetLstFreqenty()
        {
            lstFreqent.Clear();
            DataTableToList();
            return lstFreqent;
        }

        //Search for freqenty by freqentyKode
        public Freqenty Find(int code)
        {
            return this.GetLstFreqenty().Find(x => x.FreqentyKode == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            Freqenty f = this.Find(code);
            if (f != null)
            {
                f.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(Freqenty f)
        {
            f.FillDataRow();
            this.UpDate();
        }

        //Add new Freqenty
        public void AddNew(Freqenty f)
        {
            f.Dr = table.NewRow();
            f.FillDataRow();
            this.Add(f.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstFreqenty().Max(x => x.FreqentyKode) + 1;
        }

    }
}
