//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GP_for_seminar
{
    using System;
    using System.Collections.Generic;
    
    public partial class Practice_content
    {
        public int ID { get; set; }
        public string Choice1 { get; set; }
        public string Choice2 { get; set; }
        public string Choice3 { get; set; }
        public string Choice4 { get; set; }
        public string audio { get; set; }
        public string correct { get; set; }
        public Nullable<int> PracticeID { get; set; }
    
        public virtual Practice Practice { get; set; }
    }
}