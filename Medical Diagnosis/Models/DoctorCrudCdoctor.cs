using System;
using System.Collections.Generic;

#nullable disable

namespace Medical_Diagnosis.Models
{
    public partial class DoctorCrudCdoctor
    {
        public int DoctorId { get; set; }
        public int CdoctorId { get; set; }

        public virtual CandidateDoctor Cdoctor { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
