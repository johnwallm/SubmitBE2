//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubmitBE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CaseReport
    {
        public int CaseReportID { get; set; }
        public Nullable<int> UserInformationID { get; set; }
        public Nullable<System.DateTime> DateReported { get; set; }
        public byte[] CaseReportPhoto { get; set; }
        public string CaseLocation { get; set; }
        public Nullable<int> EnvironmentalConcernID { get; set; }
        public string XCoordinates { get; set; }
        public string YCoordinates { get; set; }
        public Nullable<int> UpdatedStatusID { get; set; }
        public Nullable<System.DateTime> UpdatedStatusDate { get; set; }
        public string Notes { get; set; }
        public Nullable<int> VolunteerID { get; set; }
    }
}
