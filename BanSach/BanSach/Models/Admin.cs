//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanSach.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admin
    {
        public string MaAdmin { get; set; }
        public string UserAdmin { get; set; }
        public string PassAdmin { get; set; }
        public string Hoten { get; set; }
        public string MaCV { get; set; }
    
        public virtual ChucVu ChucVu { get; set; }
    }
}
