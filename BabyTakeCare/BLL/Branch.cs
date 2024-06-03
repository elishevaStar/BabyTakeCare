using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class Branch
    {
        //properties
        private DataRow dr;
        private int branchKode;
        private int city;
        private string addressBr;
        private string telNum;
        private bool status;

        //constructor
        public Branch() { }
        public Branch(DataRow dr)
        {
            this.Dr = dr;
            branchKode = Convert.ToInt32(dr["numberBr"]);
            city = Convert.ToInt32(dr["cityKode"]);
            addressBr = dr["addressBr"].ToString();
            telNum = dr["telephoneBr"].ToString();
            Status = Convert.ToBoolean(dr["status"]);
        }

        public void FillDataRow()
        {
            Dr["numberBr"] = branchKode;
            Dr["cityKode"] = city;
            Dr["addressBr"] = addressBr;
            Dr["telephoneBr"] = telNum;
            Dr["status"] = Status;

        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int BranchKode { get => branchKode; set => branchKode = value; }
        public int City { get => city; set => city = value; }
        public string AddressBr { get => addressBr; set => addressBr = value; }
        public string TelNum { get => telNum; set => telNum = value; }
        public bool Status { get => status; set => status = value; }

        //Return city as a noun
        public City CityOfBranch()
        {
            CityDB tblCity = new CityDB();
            return tblCity.Find(city);
        }

        public override string ToString()
        {
            return CityOfBranch().CityName+" "+ addressBr;
        }
    }
}
