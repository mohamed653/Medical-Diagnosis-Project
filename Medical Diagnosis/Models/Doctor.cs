using System;
using System.Collections.Generic;

#nullable disable

namespace Medical_Diagnosis.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            Candidates = new HashSet<Candidate>();
            DiagnosisResults = new HashSet<DiagnosisResult>();
            DiagnosisTests = new HashSet<DiagnosisTest>();
            DoctorCrudCdoctors = new HashSet<DoctorCrudCdoctor>();
            GeneralDiagnosisTests = new HashSet<GeneralDiagnosisTest>();
            Gives = new HashSet<Give>();
        }

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Pn { get; set; }
        public int? MedicalLicenseId { get; set; }
        public int? ClinicId { get; set; }

        public virtual Clinic Clinic { get; set; }
        public virtual ICollection<Candidate> Candidates { get; set; }
        public virtual ICollection<DiagnosisResult> DiagnosisResults { get; set; }
        public virtual ICollection<DiagnosisTest> DiagnosisTests { get; set; }
        public virtual ICollection<DoctorCrudCdoctor> DoctorCrudCdoctors { get; set; }
        public virtual ICollection<GeneralDiagnosisTest> GeneralDiagnosisTests { get; set; }
        public virtual ICollection<Give> Gives { get; set; }
    }
}
