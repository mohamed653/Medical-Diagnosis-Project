using System;
using System.Collections.Generic;

#nullable disable

namespace Medical_Diagnosis.Models
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblUserType UserType { get; set; }
    }
}
