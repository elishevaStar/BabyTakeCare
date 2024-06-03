using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class DisAppointmentDB:GeneralDB
    {
        //property
        List<DisAppointment> lstDisAppointments = new List<DisAppointment>();

        //constructor
        public DisAppointmentDB():base("tbl_appointments_discrabition") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstDisAppointments.Add(new DisAppointment(dr));
            }
        }

        public List<DisAppointment> GetLstDisAppointments()
        {
            lstDisAppointments.Clear();
            DataTableToList();
            return lstDisAppointments;
        }

        //Search for disAppointment by visitDisKode
        public DisAppointment Find(int code)
        {
            return this.GetLstDisAppointments().Find(x => x.VisitDisKode == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            DisAppointment da = this.Find(code);
            if (da != null)
            {
                da.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(DisAppointment da)
        {
            da.FillDataRow();
            this.UpDate();
        }

        //Add new DisAppointment
        public void AddNew(DisAppointment da)
        {
            da.Dr = table.NewRow();
            da.FillDataRow();
            this.Add(da.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstDisAppointments().Max(x => x.VisitDisKode) + 1;
        }
    }
}
