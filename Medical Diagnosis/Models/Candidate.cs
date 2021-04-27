using System;
using System.Collections.Generic;

#nullable disable

namespace Medical_Diagnosis.Models
{
    public partial class Candidate
    {
        public int? DoctorId { get; set; }
        public int CdoctorId { get; set; }
        public int? PatientId { get; set; }
        public int DresultId { get; set; }
        public string Purpose { get; set; }

        public virtual CandidateDoctor Cdoctor { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual DiagnosisResult Dresult { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
