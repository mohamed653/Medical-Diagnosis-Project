using System;
using System.Collections.Generic;

#nullable disable

namespace Medical_Diagnosis.Models
{
    public partial class GdtestDresult
    {
        public int DresultId { get; set; }
        public int GdtestId { get; set; }

        public virtual DiagnosisResult Dresult { get; set; }
        public virtual GeneralDiagnosisTest Gdtest { get; set; }
    }
}
