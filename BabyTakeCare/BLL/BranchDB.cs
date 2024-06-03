using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class BranchDB:GeneralDB
    {
        //property
        List<Branch> lstBranches = new List<Branch>();

        //constructor
        public BranchDB() : base("tbl_branches") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstBranches.Add(new Branch(dr));
            }
        }

        public List<Branch> GetLstBranches()
        {
            lstBranches.Clear();
            DataTableToList();
            return lstBranches;
        }

        //Search for branch by branchKode
        public Branch Find(int code)
        {
            return this.GetLstBranches().Find(x => x.BranchKode == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            Branch b = this.Find(code);
            if (b != null)
            {
                b.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(Branch b)
        {
            b.FillDataRow();
            this.UpDate();
        }

        //Delete status
        public void DeleteStatus(int code)
        {
            Branch b = this.Find(code);
            if (b != null)
            {
                b.Status = false;
                this.UpDateRow(b);
            }
        }

        //Add new Branch
        public void AddNew(Branch b)
        {
            b.Dr = table.NewRow();
            b.FillDataRow();
            this.Add(b.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstBranches().Max(x => x.BranchKode) + 1;
        }


    }
}
