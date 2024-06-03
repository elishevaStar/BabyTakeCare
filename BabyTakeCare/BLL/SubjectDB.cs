using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class SubjectDB:GeneralDB
    {
        //property
        List<Subject> lstSubjects = new List<Subject>();

        //constructor
        public SubjectDB() : base("tbl_Subjects") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lstSubjects.Add(new Subject(dr));
            }
        }

        public List<Subject> GetLstSubject()
        {
            lstSubjects.Clear();
            DataTableToList();
            return lstSubjects;
        }

        //Search for subject by subjectKode
        public Subject Find(int code)
        {
            return this.GetLstSubject().Find(x => x.SubjectKode == code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            Subject s = this.Find(code);
            if (s != null)
            {
                s.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(Subject s)
        {
            s.FillDataRow();
            this.UpDate();
        }

        //Add new Subject
        public void AddNew(Subject s)
        {
            s.Dr = table.NewRow();
            s.FillDataRow();
            this.Add(s.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstSubject().Max(x => x.SubjectKode) + 1;
        }

    }
}
