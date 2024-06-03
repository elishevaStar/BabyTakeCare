using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class ImmunisationSideEffectDB:GeneralDB
    {
        //property
        List<ImmunisationSideEffect> lstImmunisationSideEffects = new List<ImmunisationSideEffect>();

        //constructor
        public ImmunisationSideEffectDB():base("tbl_immunisation_side_effects") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstImmunisationSideEffects.Add(new ImmunisationSideEffect(dr));
            }
        }

        public List<ImmunisationSideEffect> GetLstImmunisationSideEffects()
        {
            lstImmunisationSideEffects.Clear();
            DataTableToList();
            return lstImmunisationSideEffects;
        }

        //Search for ImmunistationSideEffect by immunistationKode and sideEffectKode
        public ImmunisationSideEffect Find(int code1,int code2)
        {
            return this.GetLstImmunisationSideEffects().Find(x => x.ImmunisationKode == code1 && x.SideEffectKode==code2);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code1,int code2)
        {
            ImmunisationSideEffect imse = this.Find(code1,code2);
            if (imse != null)
            {
                imse.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(ImmunisationSideEffect  imse)
        {
            imse.FillDataRow();
            this.UpDate();
        }

        //Add new ImmunistationSideEffect
        public void AddNew(ImmunisationSideEffect imse)
        {
            imse.Dr = table.NewRow();
            imse.FillDataRow();
            this.Add(imse.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstImmunisationSideEffects().Max(x => x.ImmunisationKode) + 1;
        }

    }
}
