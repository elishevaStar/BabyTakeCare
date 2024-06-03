using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class Presence
    {
        //properties
        private DataRow dr;
        private int branchKode;
        private string idNumW;
        private int day;
        private DateTime startHour;
        private DateTime endHour;

        //constructor
        public Presence() { }

        public Presence(DataRow dr)
        {
            this.Dr = dr;
            branchKode = Convert.ToInt32(dr["numberBr"]);
            idNumW = dr["idNumW"].ToString();
            day =Convert.ToInt32( dr["day"]);
            startHour = Convert.ToDateTime(dr["startHour"]);
            endHour = Convert.ToDateTime(dr["finishHour"]);
        }

        public void FillDataRow()
        {
            Dr["numberBr"] = branchKode;
            Dr["idNumW"] = idNumW;
            Dr["day"] = day;
            Dr["startHour"] = startHour;
            Dr["finishHour"] = endHour;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int BranchKode { get => branchKode; set => branchKode = value; }
        public string IdNumW { get => idNumW; set => idNumW = value; }
        public int Day { get => day; set => day = value; }
        public DateTime StartHour { get => startHour; set => startHour = value; }
        public DateTime EndHour { get => endHour; set => endHour = value; }

        //Return worker as a noun
        public Worker WorkerOfPresence()
        {
            WorkerDB tblWorker = new WorkerDB();
            return tblWorker.Find(idNumW);
        }

        //Return branch as a noun
        public Branch BranchOfPresence()
        {
            BranchDB tblBranch = new BranchDB();
            return tblBranch.Find(branchKode);
        }
    }
}
