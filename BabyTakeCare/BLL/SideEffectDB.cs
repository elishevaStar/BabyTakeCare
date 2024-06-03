using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    //property
    public class SideEffectDB:GeneralDB
    {
        List<SideEffect> lstSideEffects = new List<SideEffect>();

        //constructor
        public SideEffectDB():base("tbl_side_effects") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstSideEffects.Add(new SideEffect(dr));
            }
        }

        public List<SideEffect> GetLstSideEffects()
        {
            lstSideEffects.Clear();
            DataTableToList();
            return lstSideEffects;
        }

        //Search for sideEffect by sideEffectKode
        public SideEffect Find(int code)
        {
            return this.GetLstSideEffects().Find(x => x.SideEffectKode == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            SideEffect se = this.Find(code);
            if (se != null)
            {
                se.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(SideEffect se)
        {
            se.FillDataRow();
            this.UpDate();
        }

        //Add new SideEffect
        public void AddNew(SideEffect se)
        {
            se.Dr = table.NewRow();
            se.FillDataRow();
            this.Add(se.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstSideEffects().Max(x => x.SideEffectKode) + 1;
        }
    }


    
}
