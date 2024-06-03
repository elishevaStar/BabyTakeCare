using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class BabyDevelopmentDB:GeneralDB
    {
        //property
        List<BabyDevelopment> lstBabyDevelopments = new List<BabyDevelopment>();

        //constructor
        public BabyDevelopmentDB():base ("tbl_babys_developments") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstBabyDevelopments.Add(new BabyDevelopment(dr));
            }
        }

        public List<BabyDevelopment> GetLstBabyDevelopments()
        {
            lstBabyDevelopments.Clear();
            DataTableToList();
            return lstBabyDevelopments;
        }

        //Search for branch by branchKode
        public BabyDevelopment Find(int code1,int code2)
        {
            return this.GetLstBabyDevelopments().Find(x => x.DevelopmentKode == code1 && x.VisitKode==code2);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code1,int code2)
        {
            BabyDevelopment bD = this.Find(code1,code2);
            if (bD != null)
            {
                bD.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(BabyDevelopment bD)
        {
            bD.FillDataRow();
            this.UpDate();
        }


        //Add new Branch
        public void AddNew(BabyDevelopment bD)
        {
            bD.Dr = table.NewRow();
            bD.FillDataRow();
            this.Add(bD.Dr);
        }



    }
}
