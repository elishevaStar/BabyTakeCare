using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class DisDevelopmentDB : GeneralDB
    {
        //property
        List<DisDevelopment> lstDisDevelopments = new List<DisDevelopment>();

        //constructor
        public DisDevelopmentDB() : base("tbl_developments_discrabition") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstDisDevelopments.Add(new DisDevelopment(dr));


            }
        }
        public List<DisDevelopment> GetLstDisDevelopments()
        {
            lstDisDevelopments.Clear();
            DataTableToList();
            return lstDisDevelopments;
        }

        //Search for disDevelopment by disDevelopmentKode
        public DisDevelopment Find(int code)
        {
            return this.GetLstDisDevelopments().Find(x => x.DisDevelopmentKode == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            DisDevelopment dd = this.Find(code);
            if (dd != null)
            {
                dd.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(DisDevelopment dd)
        {
            dd.FillDataRow();
            this.UpDate();
        }

        //Add new DisDevelopment
        public void AddNew(DisDevelopment dd)
        {
            dd.Dr = table.NewRow();
            dd.FillDataRow();
            this.Add(dd.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstDisDevelopments().Max(x => x.DisDevelopmentKode) + 1;
        }
    }
}
