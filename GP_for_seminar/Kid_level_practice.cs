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
    
    public partial class Kid_level_practice
    {
        public int ID { get; set; }
        public int KidID { get; set; }
        public int practiceID { get; set; }
        public int Score { get; set; }
        public string PracticeName { get; set; }
        public string UseName { get; set; }
    
        public virtual Kid Kid { get; set; }
        public virtual Practice Practice { get; set; }
    }
}
