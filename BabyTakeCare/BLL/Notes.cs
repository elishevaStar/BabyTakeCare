using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class Notes
    {
        //properties
        private DataRow dr;
        private int noteKode;
        private string idNumB;
        private string idNumW;
        private string noteSubject;
        private string noteDis;
        private bool status;
        private DateTime date;

        //constructor
        public Notes() { }
        public Notes(DataRow dr)
        {
            this.Dr = dr;
            noteKode = Convert.ToInt32(dr["noteKode"]);
            idNumB = dr["idNumB"].ToString();
            idNumW = dr["idNumW"].ToString();
            noteSubject = dr["noteSubject"].ToString();
            noteDis = dr["noteDis"].ToString();
            status = Convert.ToBoolean(dr["status"]);
            date = Convert.ToDateTime(dr["dateNote"]);
        }

        public void FillDataRow()
        {
            Dr["noteKode"] = noteKode;
            Dr["idNumB"] = idNumB;
            Dr["idNumW"] = idNumW;
            Dr["noteSubject"] = noteSubject;
            Dr["noteDis"] = noteDis;
            Dr["status"] = status;
            dr["dateNote"] = date;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int NoteKode { get => noteKode; set => noteKode = value; }
        public string IdNumB { get => idNumB; set => idNumB = value; }
        public string IdNumW { get => idNumW; set => idNumW = value; }
        public string NoteSubject { get => noteSubject; set => noteSubject = value; }
        public string NoteDis { get => noteDis; set => noteDis = value; }
        public bool Status { get => status; set => status = value; }
        public DateTime Date { get => date; set => date = value; }

        //Return worker as a noun
        public Worker WorkerOfNotes()
        {
            WorkerDB tblWorker = new WorkerDB();
            return tblWorker.Find(idNumW);
        }

        //Return baby as a noun
        public Baby BabyOfNotes()
        {
            BabyDB tblBaby = new BabyDB();
            return tblBaby.Find(idNumB);
        }
    }
}
