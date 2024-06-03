using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class PresenceDB:GeneralDB
    {
        //property
        List<Presence> lstPresences = new List<Presence>();

        //constructor
        public PresenceDB():base("tbl_presence") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstPresences.Add(new Presence(dr));
            }
        }

        public List<Presence> GetLstPresences()
        {
            lstPresences.Clear();
            DataTableToList();
            return lstPresences;
        }

        //Search for presnce by idNumW and branchKode
        public Presence Find(string code1,int code2)
        {
            return this.GetLstPresences().Find(x => x.IdNumW==code1 && x.BranchKode==code2);
        }

        //Delete row in the table by the key
        public void DeleteRow(string code1,int code2)
        {
            Presence p = this.Find(code1,code2);
            if (p != null)
            {
                p.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(Presence p)
        {
            p.FillDataRow();
            this.UpDate();
        }

        //Add new Presence
        public void AddNew(Presence p)
        {
            p.Dr = table.NewRow();
            p.FillDataRow();
            this.Add(p.Dr);
        }
    }
}
