using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class NotesDB:GeneralDB
    {
        //property
        List<Notes> lstNotes = new List<Notes>();

        //constructor
        public NotesDB() : base("tbl_notes") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstNotes.Add(new Notes(dr));
            }
        }

        public List<Notes> GetLstNotes()
        {
            lstNotes.Clear();
            DataTableToList();
            return lstNotes;
        }

        //Search for notes by notesKode
        public Notes Find(int code)
        {
            return this.GetLstNotes().Find(x => x.NoteKode == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            Notes n = this.Find(code);
            if (n != null)
            {
                n.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(Notes n)
        {
            n.FillDataRow();
            this.UpDate();
        }


        //Add new Notes
        public void AddNew(Notes n)
        {
            n.Dr = table.NewRow();
            n.FillDataRow();
            this.Add(n.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstNotes().Max(x => x.NoteKode) + 1;
        }

    }
}
