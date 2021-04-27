using System;
using System.Collections.Generic;

#nullable disable

namespace Medical_Diagnosis.Models
{
    public partial class Give
    {
        public int? DoctorId { get; set; }
        public int? PatientId { get; set; }
        public int DresultId { get; set; }
        public DateTime SendDate { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual DiagnosisResult Dresult { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
