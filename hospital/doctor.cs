using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; }
        public string ContactNumber { get; set; }

        public string Email { get; set; }
        public string ClinicAddress { get; set; }

        public Doctor(int doctorID, string firstName, string lastName, string specialization, string contactNumber, string email, string clinicAddress)
        {
            DoctorID = doctorID;
            FirstName = firstName;
            LastName = lastName;
            Specialization = specialization;
            ContactNumber = contactNumber;
            Email = email;
            ClinicAddress = clinicAddress;


        }
    }
}
