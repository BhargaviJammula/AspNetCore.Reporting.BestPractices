using System;

namespace AspNetCore.Reporting.Common.Models {
    public class StudentDetailsModel {
        public string StudentID { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }

    public class Patient
    {
        public string PatientName { get; set; }
        public string ICNo { get; set; }
        public string OldICOrPassport { get; set; }
        public string MRN { get; set; }
        public string VisitNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string BloodGroup { get; set; }
        public string WardRmBedNo { get; set; }
    }
}
