using System;
using System.Collections.Generic;

#nullable disable

namespace Medical_Diagnosis.Models
{
    public partial class DiseaseRelateDtest
    {
        public int DiseaseId { get; set; }
        public int DtestId { get; set; }

        public virtual Disease Disease { get; set; }
        public virtual DiagnosisTest Dtest { get; set; }
    }
}
