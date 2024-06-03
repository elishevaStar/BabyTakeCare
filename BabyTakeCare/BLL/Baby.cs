using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class Baby
    {
        //properties
        private DataRow dr;
        private string idNumB;
        private int babyKode;
        private string privateName;
        private string familiyName;
        private double bornHigh;
        private double bornWeight;
        private string address;
        private string telNum;
        private string kind;
        private int nationalKode;
        private string privateNameMother;
        private string privateNameFather;
        private string idNumP;
        private DateTime dateOfBirth;
        private bool status;
        private int branchKode;
        private int cityKode;

        //constructor
        public Baby() { }
        
        public Baby(DataRow dr)
        {
            this.Dr = dr;
            babyKode = Convert.ToInt32(dr["babyKode"]);
            idNumB = dr["idNumB"].ToString();
            privateName = dr["firstNameB"].ToString();
            familiyName = dr["familyNameB"].ToString();
            bornHigh = Convert.ToDouble(dr["bornHigh"]);
            bornWeight = Convert.ToDouble(dr["bornWeight"]);
            address = dr["addressB"].ToString();
            telNum = dr["telephoneB"].ToString();
            Kind = dr["kindB"].ToString();
            nationalKode = Convert.ToInt32(dr["numberNa"]);
            privateNameMother = dr["firstNameM"].ToString();
            privateNameFather = dr["firstNameF"].ToString();
            idNumP = dr["idNumP"].ToString();
            dateOfBirth = Convert.ToDateTime(dr["dateOfBirth"]);
            status = Convert.ToBoolean(dr["status"]);
            branchKode = Convert.ToInt32(dr["branchKode"]);
            cityKode = Convert.ToInt32(dr["cityKode"]);

        }
        public void FillDataRow()
        {
            Dr["idNumP"] = idNumP;
            Dr["babyKode"] = babyKode;
            Dr["firstNameB"] = privateName;
            Dr["familyNameB"] = familiyName;
            Dr["bornHigh"] = bornHigh;
            Dr["bornWeight"] = bornWeight;
            Dr["addressB"] = address;
            Dr["telephoneB"] = telNum;
            Dr["kindB"] = Kind;
            Dr["numberNa"] = nationalKode;
            Dr["firstNameM"] = privateNameMother;
            Dr["firstNameF"] = privateNameFather;
            Dr["idNumB"] = idNumB;
            Dr["dateOfBirth"] = dateOfBirth;
            Dr["status"] = status;
            Dr["branchKode"] = branchKode;
            Dr["cityKode"] = cityKode;



        }
        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public string IdNumP
        {
            get => idNumP; set
            {
                if (!Validation.CheckId(value))
                    throw new Exception("תעודת זהות לא תקינה!");
                idNumP = value;
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
        public double BornHigh
        {
            get => bornHigh; set
            {
                if (!Validation.IsNumDouble(value.ToString()))
                    throw new Exception("יש להכניס מספרים!");
                bornHigh = value;
            }
        }
                
                
        public double BornWeight
        {
            get => bornWeight; set
            {
                if (!Validation.IsNumDouble(value.ToString()))
                    throw new Exception("יש להכניס מספרים!");
                bornWeight = value;
            }
        }
        public string Address { get => address; set => address = value; }
        public string TelNum { get => telNum; set
            {
                if(!Validation.IsPelepon(value.ToString()))
                    throw new Exception("מספר הפלאפון אינו תקין!");
                telNum = value;
            }
        }
        
        public int NationalKode { get => nationalKode; set => nationalKode = value; }
        public string PrivateNameMother
        {
            get => privateNameMother; set
            {

                if (!Validation.IsHebrew(value))
                    throw new Exception("יש להכניס אותיות בעברית! ");
                privateNameMother = value;
            }
        }
        public string PrivateNameFather
        {
            get => privateNameFather; set
            {

                if (!Validation.IsHebrew(value))
                    throw new Exception("יש להכניס אותיות בעברית! ");
                privateNameFather = value;
            }
        }
        public int BabyKode
        {
            get => babyKode; set
            {
                if (!Validation.IsNum(value.ToString()))
                    throw new Exception("יש להכניס מספרים!");
                babyKode = value;
            }
        }
        public string IdNumB
        {
            get => idNumB; set
            {
                if (!Validation.CheckId(value))
                    throw new Exception("תעודת זהות לא תקינה!");
                idNumB = value;
            }
        }
        public DateTime DateOfBirth
        {
            get => dateOfBirth; set
            {
                if (value > DateTime.Now)
                    throw new Exception("התאריך אינו תקין!");
                dateOfBirth = value;
            }
        }

        public string Kind { get => kind; set => kind = value; }
        public bool Status { get => status; set => status = value; }
        public int BranchKode { get => branchKode; set => branchKode = value; }
        public int CityKode { get => cityKode; set => cityKode = value; }

        //Return national as a noun
        public National NationalOfBaby()
        {
            NationalDB tblNational = new NationalDB();
            return tblNational.Find(nationalKode);
        }

        //Return branch as a noun
        public Branch BranchOfBaby()
        {
            BranchDB tblBranch = new BranchDB();
            return tblBranch.Find(branchKode);
        }
        //Return city as a noun
        public City CityOfBaby()
        {
            CityDB tblCity = new CityDB();
            return tblCity.Find(cityKode);
        }

        public override string ToString()
        {
            return privateName+" "+familiyName;
        }


    }
}
