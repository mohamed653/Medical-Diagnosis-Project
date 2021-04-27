﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Medical_Diagnosis.Models
{
    public partial class DiseaseRelateGdtest
    {
        public int DiseaseId { get; set; }
        public int GdtestId { get; set; }

        public virtual Disease Disease { get; set; }
        public virtual GeneralDiagnosisTest Gdtest { get; set; }
    }
}
