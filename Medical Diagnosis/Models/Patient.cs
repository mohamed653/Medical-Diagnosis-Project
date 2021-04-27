using System;
using System.Collections.Generic;

#nullable disable

namespace Medical_Diagnosis.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Candidates = new HashSet<Candidate>();
            Gives = new HashSet<Give>();
            Greserves = new HashSet<Greserve>();
            Reserves = new HashSet<Reserve>();
        }

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Pn { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }
        public virtual ICollection<Give> Gives { get; set; }
        public virtual ICollection<Greserve> Greserves { get; set; }
        public virtual ICollection<Reserve> Reserves { get; set; }
    }
}
