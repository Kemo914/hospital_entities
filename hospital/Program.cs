using System;
using System.CodeDom;
using hospital;



class program

{
    static void Main(string[] args)
    {
        Doctor doctor = new Doctor(24, "Adelaja", "Olufunwa", "Doctor", "0802367999", "AdeO@gmail.com", " Daren clinic G.A.R street");
        Patient patient = new Patient(12, "Joy", "James", 1996, "Female", "080233336667", "numb3 G.A.R street", "JoyJ@gmail.com");
        LabTest labtest = new LabTest(13, "Blood Test", "Blood analysis", "normal", 50.00m);

        {
            Console.WriteLine($"My name is {doctor.FirstName} {doctor.LastName}. I can be contacted via {doctor.ContactNumber} and {doctor.Email}.");
        
            Console.WriteLine($"I understand that your name {patient.FirstName} {patient.LastName} a patient that would be carrying out a {labtest.TestName} test. Please confirm {patient.ContactNumber} and {patient.Email} as your email address");
        }

    }
}
