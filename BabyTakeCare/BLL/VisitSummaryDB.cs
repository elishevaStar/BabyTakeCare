using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class VisitSummaryDB:GeneralDB
    {
        List<VisitSummary> lstVisitSummaries = new List<VisitSummary>();

        //constructor
        public VisitSummaryDB():base("tbl_visit_summary") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstVisitSummaries.Add(new VisitSummary(dr));
            }
        }

        public List<VisitSummary> GetLstVisitSummaries()
        {
            lstVisitSummaries.Clear();
            DataTableToList();
            return lstVisitSummaries;
        }

        //Search for visitSummary by visitKode and developmentKode
        public VisitSummary Find(int code1,int code2)
        {
            return this.GetLstVisitSummaries().Find(x => x.VisitKodee == code1 && x.DevelopmentKode==code2);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code1,int code2)
        {
            VisitSummary vs = this.Find(code1,code2);
            if (vs != null)
            {
                vs.Dr.Delete();
                this.UpDate();
            }
        }

        //Delete status
        public void  DeleteStatus(int code1,int code2)
        {
            VisitSummary vs = this.Find(code1, code2);
            if (vs != null)
            {
                vs.Status = false;
                this.UpDateRow(vs);
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(VisitSummary vs)
        {
            vs.FillDataRow();
            this.UpDate();
        }

        //Add new VisitSummary
        public void AddNew(VisitSummary vs)
        {
            vs.Dr = table.NewRow();
            vs.FillDataRow();
            this.Add(vs.Dr);
        }





    }
}
