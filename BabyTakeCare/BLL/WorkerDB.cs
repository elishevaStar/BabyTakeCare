using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class WorkerDB:GeneralDB
    {
        //property
        List<Worker> lstWorkers = new List<Worker>();

        //constructor
        public WorkerDB() : base("tbl_worker") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstWorkers.Add(new Worker(dr));
            }
        }

        public List<Worker> GetLstWorker()
        {
            lstWorkers.Clear();
            DataTableToList();
            return lstWorkers;
        }
        //Search for worker by idNumW
        public Worker Find(string code)
        {
            return this.GetLstWorker().Find(x => x.IdNumW == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(string code)
        {
            Worker w = this.Find(code);
            if (w!= null)
            {
                w.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(Worker w)
        {
            w.FillDataRow();
            this.UpDate();
        }

        //Delete status
        public void DeleteStatus(string code)
        {
            Worker w = this.Find(code);
            if (w != null)
            {
                w.Status = false;
                this.UpDateRow(w);
            }
        }

        //Add new Worker
        public void AddNew(Worker w)
        {
            w.Dr = table.NewRow();
            w.FillDataRow();
            this.Add(w.Dr);
        }

        
    }
}
