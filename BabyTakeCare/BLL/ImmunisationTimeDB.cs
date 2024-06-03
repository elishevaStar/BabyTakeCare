using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class ImmunisationTimeDB:GeneralDB
    {
        //property
        List<ImmunisationTime> lstImmunisationTimes = new List<ImmunisationTime>();

        //constructor
        public ImmunisationTimeDB() : base("tbl_immunisationsTimes") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstImmunisationTimes.Add(new ImmunisationTime(dr));
            }
        }

        public List<ImmunisationTime> GetLstImmunisationTimes()
        {
            lstImmunisationTimes.Clear();
            DataTableToList();
            return lstImmunisationTimes;
        }

        //Search for ImmunistationTime by immunistationKode
        public ImmunisationTime Find(int code1,int code2)
        {
            return this.GetLstImmunisationTimes().Find(x => x.ImmunisationKode == code1 && x.NumPortion==code2);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code1,int code2)
        {
            ImmunisationTime imt = this.Find(code1, code2);
            if (imt != null)
            {
                imt.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(ImmunisationTime imt)
        {
            imt.FillDataRow();
            this.UpDate();
        }

        //Add new ImmunistationTime
        public void AddNew(ImmunisationTime imt)
        {
            imt.Dr = table.NewRow();
            imt.FillDataRow();
            this.Add(imt.Dr);
        }

    }
}
