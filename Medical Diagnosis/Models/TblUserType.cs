using System;
using System.Collections.Generic;

#nullable disable

namespace Medical_Diagnosis.Models
{
    public partial class TblUserType
    {
        public TblUserType()
        {
            TblUsers = new HashSet<TblUser>();
        }

        public int UserTypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
