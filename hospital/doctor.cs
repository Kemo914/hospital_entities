using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    public class Doctor
    {
        public int Doctor_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Specialization { get; set; }
        public string Contact_Number { get; set; }

        public string Email { get; set; }
        public string Clinic_Address { get; set; }

        public Doctor(int doctor_ID, string first_Name, string last_Name, string specialization, string contact_Number, string email, string clinic_Address)
        {
            Doctor_ID = doctor_ID;
            First_Name = first_Name;
            Last_Name = last_Name;
            Specialization = specialization;
            Contact_Number = contact_Number;
            Email = email;
            Clinic_Address = clinic_Address;


        }
    }
}
