//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryOnline.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> ebook_id { get; set; }
        public Nullable<int> doc_id { get; set; }
    
        public virtual Document Document { get; set; }
        public virtual Ebook Ebook { get; set; }
    }
}
