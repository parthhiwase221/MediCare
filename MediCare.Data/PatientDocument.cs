//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediCare.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PatientDocument
    {
        public int DocumentID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public string DocumentType { get; set; }
        public string DocumentPath { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public string Notes { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
