using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{ 
    public class Lab_test
    {

        public int Test_ID { get; set; }
        public string Test_Name { get; set; }
        public string Test_Description { get; set; }
        public string Normal_Range { get; set; }
        public decimal Cost { get; set; }

        public Lab_test(int testID, string testName, string testDescription, string normalRange, decimal cost)
        {
            Test_ID = testID;
            Test_Name = testName;
            Test_Description = testDescription;
            Normal_Range = normalRange;
            Cost = cost;
        }
    }

}

