using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class BabyImmunisationDB:GeneralDB
    {
        //property
        List<BabyImmunisation> lstBabyImmunisations = new List<BabyImmunisation>();

        //constructor
        public BabyImmunisationDB():base("tbl_babys_immunisations") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstBabyImmunisations.Add(new BabyImmunisation(dr));
            }
        }

      public  List<BabyImmunisation> GetLstBabyImmunisations()
        {
            lstBabyImmunisations.Clear();
            DataTableToList();
            return lstBabyImmunisations;
        }

        //Search for babyImmunistation by immunistationKode and visitKode
        public BabyImmunisation Find(int code1,int code2)
        {
            return this.GetLstBabyImmunisations().Find(x => x.VisitKode == code1 && x.ImmunisationKode==code2);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code1,int code2)
        {
            BabyImmunisation bi = this.Find(code1,code2);
            if (bi != null)
            {
                bi.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(BabyImmunisation bi)
        {
            bi.FillDataRow();
            this.UpDate();
        }

        //Add new BabyImmunistation
        public void AddNew(BabyImmunisation bi)
        {
            bi.Dr = table.NewRow();
            bi.FillDataRow();
            this.Add(bi.Dr);
        }

    }
}
