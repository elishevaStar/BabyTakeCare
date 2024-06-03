using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class Worker
    {
        //properties
        private DataRow dr;
        private string idNumW;
        private string privateName;
        private string familiyName;
        private DateTime beginDate;
        private double salary;
        private string address;
        private string telNum;
        private string kind;
        private int subjectKode;
        private int age;
        private int nationalKode;
        private int branchKode;
        private int workerKode;
        private bool status;

        //constructor
        public Worker() { }

        public Worker(DataRow dr)
        {
            this.Dr = dr;
            idNumW = dr["idNumW"].ToString();
            privateName = dr["firstNameW"].ToString();
            familiyName = dr["familyNameW"].ToString();
            beginDate = Convert.ToDateTime(dr["begineWork"]);
            salary = Convert.ToDouble(dr["salary"]);
            address = dr["address"].ToString();
            telNum = dr["telephoneW"].ToString();
            kind = dr["kindW"].ToString();
            subjectKode = Convert.ToInt32(dr["numSub"]);
            age = Convert.ToInt32(dr["ageW"]);
            nationalKode = Convert.ToInt32(dr["numNaW"]);
            branchKode = Convert.ToInt32(dr["numBr"]);
            WorkerKode = Convert.ToInt32(dr["workerKode"]);
            status = Convert.ToBoolean(dr["status"]);
        }

        public void FillDataRow()
        {
            Dr["idNumW"] = idNumW;
            Dr["firstNameW"] = privateName;
            Dr["familyNameW"] = familiyName;
            Dr["begineWork"] = beginDate;
            Dr["salary"] = salary;
            Dr["address"] = address;
            Dr["telephoneW"] = telNum;
            Dr["kindW"] = kind;
            Dr["numSub"] = subjectKode;
            Dr["ageW"] = age;
            Dr["numNaW"] = nationalKode;
            Dr["numBr"] = branchKode;
            Dr["workerKode"] = WorkerKode;
            Dr["status"] = status;

        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public string IdNumW
        {
            get => idNumW; set
            {
                if (!Validation.CheckId(value))
                    throw new Exception("תעודת זהות לא תקינה!");
                idNumW = value;
            }
        }
        public string PrivateName
        {
            get => privateName; set
            {
                if (!Validation.IsHebrew(value))
                    throw new Exception("יש להכניס אותיות בעברית! ");
                privateName = value;
            }
        }
        public string FamiliyName
        {
            get => familiyName; set
            {
                if (!Validation.IsHebrew(value))
                    throw new Exception("יש להכניס אותיות בעברית! ");
                familiyName = value;
            }
        }
        public DateTime BeginDate
        {
            get => beginDate; set
            {
                if (value > DateTime.Now)
                    throw new Exception("התאריך אינו תקין!");
                beginDate = value;
            }
        }
        public double Salary
        {
            get => salary; set
            {
                if (!Validation.IsNum(value.ToString()))
                    throw new Exception("יש להכניס מספרים!");
                salary = value;
            }
        }
        public string Address { get => address; set => address = value; }
        public string TelNum
        {
            get => telNum; set
            {

                if (!Validation.IsPelepon(value.ToString()))
                    throw new Exception("מספר הפלאפון אינו תקין!");
                telNum = value;
            }
        }
        public string Kind { get => kind; set => kind = value; }
        public int SubjectKode { get => subjectKode; set => subjectKode = value; }
        public int Age
        {
            get => age; set
            {
                if (!Validation.IsNumDouble(value.ToString()))
                    throw new Exception("יש להכניס מספרים!");
                age = value;
            }
        }
        public int NationalKode { get => nationalKode; set => nationalKode = value; }
        public int BranchKode { get => branchKode; set => branchKode = value; }
        public int WorkerKode
        {
            get => workerKode; set
            {
                if (!Validation.IsNum(value.ToString()))
                    throw new Exception("יש להכניס מספרים!");
               workerKode = value;
            }
        }
        public bool Status { get => status; set => status = value; }

        //Return subject as a noun
        public Subject SubjectOfWorker()
        {
            SubjectDB tblSubject = new SubjectDB();
            return tblSubject.Find(subjectKode);
        }

        //Return national as a noun
        public National NationalOfWorker()
        {
            NationalDB tblNational = new NationalDB();
            return tblNational.Find(nationalKode);
        }

        //Return branch as a noun
        public Branch BranchOfWorker()
        {
            BranchDB tblBranch = new BranchDB();
            return tblBranch.Find(branchKode);
        }

        public override string ToString()
        {
            return privateName + " " + familiyName;
        }


    }
}
