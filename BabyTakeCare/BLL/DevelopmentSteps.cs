using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class DevelopmentSteps
    {
        //properties
        private DataRow dr;
        private int stepKode;
        private int age;
        private string stepDevelop;
        private string stepSleep;
        private string stepFood;
        private string stepFive;
        private string stepCommunicate;

        //constructor
        public DevelopmentSteps() { }
        public DevelopmentSteps(DataRow dr)
        {
            this.Dr = dr;
            stepSleep = dr["stepDisSleep"].ToString();
            stepFood = dr["stepDisFood"].ToString();
            stepFive = dr["stepDisFive"].ToString();
            stepCommunicate = dr["stepDisCommunicate"].ToString();
            stepKode = Convert.ToInt32(dr["stepKode"]);
            stepDevelop = dr["stepDisM"].ToString();
            age= Convert.ToInt32(dr["stepAge"]);
        }

        public void FillDataRow()
        {
            Dr["stepDisSleep"] = stepSleep;
            Dr["stepDisFood"] = stepFood;
            Dr["stepDisFive"] = stepFive;
            Dr["stepDisCommunicate"] = stepCommunicate;
            Dr["stepKode"] = stepKode;
            Dr["stepDisM"] = stepDevelop;
            Dr["stepAge"] = age;
        }

        //Access methodes
        public DataRow Dr { get => dr; set => dr = value; }
        public int StepKode { get => stepKode; set => stepKode = value; }
        public int Age { get => age; set => age = value; }
        public string StepDevelop { get => stepDevelop; set => stepDevelop = value; }
        public string StepSleep { get => stepSleep; set => stepSleep = value; }
        public string StepFood { get => stepFood; set => stepFood = value; }
        public string StepFive { get => stepFive; set => stepFive = value; }
        public string StepCommunicate { get => stepCommunicate; set => stepCommunicate = value; }
    }
}
