using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class AppointmentDB:GeneralDB
    {
        //property
        List<Appointment> lstAppointments = new List<Appointment>();

        //constructor
        public AppointmentDB() : base("tbl_appointments") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstAppointments.Add(new Appointment(dr));                 
            }
        }

        public List<Appointment> GetLstAppointments()
        {
            lstAppointments.Clear();
            DataTableToList();
            return lstAppointments;
        }

        //Search for appointment by visitKode
        public Appointment Find(int code)
        {
            return this.GetLstAppointments().Find(x => x.VisitKode == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            Appointment a = this.Find(code);
            if (a != null)
            {
                a.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(Appointment a)
        {
            a.FillDataRow();
            this.UpDate();
        }

        //Add new Appointment
        public void AddNew(Appointment a)
        {
            a.Dr = table.NewRow();
            a.FillDataRow();
            this.Add(a.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstAppointments().Max(x => x.VisitKode) + 1;
        }


    }
}
