using System;
using System.Collections.Generic;

#nullable disable

namespace Medical_Diagnosis.Models
{
    public partial class CandidateDoctor
    {
        public CandidateDoctor()
        {
            Candidates = new HashSet<Candidate>();
            DoctorCrudCdoctors = new HashSet<DoctorCrudCdoctor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pn { get; set; }
        public string Specialize { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }
        public virtual ICollection<DoctorCrudCdoctor> DoctorCrudCdoctors { get; set; }
    }
}
