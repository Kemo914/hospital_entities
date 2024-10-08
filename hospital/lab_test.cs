using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{ 
    public class LabTest
    {

        public int TestID { get; set; }
        public string TestName { get; set; }
        public string TestDescription { get; set; }
        public string NormalRange { get; set; }
        public decimal Cost { get; set; }

        public LabTest(int testID, string testName, string testDescription, string normalRange, decimal cost)
        {
            TestID = testID;
            TestName = testName;
            TestDescription = testDescription;
            NormalRange = normalRange;
            Cost =  cost;
        }
    }

}

