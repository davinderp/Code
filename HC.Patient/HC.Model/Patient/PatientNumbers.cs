using HC.Patient.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HC.Patient.Model.Patient
{
    public class PatientNumbers
    {
        public int PatientID { get; set; }
        public List<PhoneNumbers> PhoneNumbers { get; set; }
    }

    public class PatientLabels
    {
        public int PatientID { get; set; }
        public List<PatientCustomLabels> PatientCustomLabels { get; set; }
    }
}
