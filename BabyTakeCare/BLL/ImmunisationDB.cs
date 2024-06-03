using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class ImmunisationDB:GeneralDB
    {
        //property
        List<Immunisation> lstImmunisations = new List<Immunisation>();

        //constructor
        public ImmunisationDB() : base("tbl_immunisations") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstImmunisations.Add(new Immunisation(dr));
            }
        }

        public List<Immunisation> GetLstImmunisations()
        {

            lstImmunisations.Clear();
            DataTableToList();
            return lstImmunisations;
        }

        //Search for immunistation by immunistationKode
        public Immunisation Find(int code)
        {
            return this.GetLstImmunisations().Find(x => x.ImmunisationKode == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            Immunisation i = this.Find(code);
            if (i != null)
            {
                i.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(Immunisation i)
        {
            i.FillDataRow();
            this.UpDate();
        }

        //Delete status
        public void DeleteStatus(int code)
        {
            Immunisation i = this.Find(code);
            if (i != null)
            {
                i.Status = false;
                this.UpDateRow(i);
            }
        }

        //Add new Immunistation
        public void AddNew(Immunisation i)
        {
            i.Dr = table.NewRow();
            i.FillDataRow();
            this.Add(i.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstImmunisations().Max(x => x.ImmunisationKode) + 1;
        }
    }

   
    
}
