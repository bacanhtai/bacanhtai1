//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S4T_HaTinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class TN_DauViec
    {
        [Key]
        public int ID { get; set; }
        public string TenDauViec { get; set; }
        public string NguoiThucHien_ID { get; set; }
        public string TenNguoiThucHien { get; set; }
        public string FileDinhKem { get; set; }
        public Nullable<System.DateTime> TuNgay { get; set; }
        public Nullable<System.DateTime> DenNgay { get; set; }
        public Nullable<int> TienDo { get; set; }
        public Nullable<int> PhamVi { get; set; }
        public Nullable<int> LoaiViec { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string NguoiDuyet_ID { get; set; }
        public string TenNguoiDuyet { get; set; }
        public string NoiDung { get; set; }
        public Nullable<int> Parent_ID { get; set; }
        public string NguoiTao_ID { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public string Display { get; set; }
        public Nullable<int> OnTime { get; set; }
    }
}
