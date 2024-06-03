using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class DevelopmentStepsDB:GeneralDB
    {
        //property
        List<DevelopmentSteps> lstDevelopSteps = new List<DevelopmentSteps>();

        //constructor
        public DevelopmentStepsDB() : base("tbl_DevelopSteps") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstDevelopSteps.Add(new DevelopmentSteps(dr));
            }
        }

        public List<DevelopmentSteps> GetLstDevelopSteps()
        {
            lstDevelopSteps.Clear();
            DataTableToList();
            return lstDevelopSteps;
        }

        //Search for developSteps by stepKode
        public DevelopmentSteps Find(int code)
        {
            return this.GetLstDevelopSteps().Find(x => x.StepKode == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            DevelopmentSteps dS = this.Find(code);
            if (dS != null)
            {
                dS.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(DevelopmentSteps dS)
        {
            dS.FillDataRow();
            this.UpDate();
        }

        //Add new DevelopSteps
        public void AddNew(DevelopmentSteps dS)
        {
            dS.Dr = table.NewRow();
            dS.FillDataRow();
            this.Add(dS.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstDevelopSteps().Max(x => x.StepKode) + 1;
        }

    }
}
