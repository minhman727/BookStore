//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStore.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTBaoCaoTon
    {
        public int MaBaoCao { get; set; }
        public int MaSach { get; set; }
        public int SoLuongTonDau { get; set; }
        public int SoLuongTonCuoi { get; set; }
    
        public virtual BaoCaoTon BaoCaoTon { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
