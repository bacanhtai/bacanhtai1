﻿//------------------------------------------------------------------------------
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
    
    public partial class TN_Chuyen
    {
        [Key]
        public int Viec_ID { get; set; }
        public int Chuyen_ID { get; set; }

        [Display(Name = "Người chuyển")]
        public string NguoiChuyen_ID { get; set; }

        [Display(Name = "Người nhận")]
        public string NguoiNhan_ID { get; set; }

        [Display(Name = "Ý kiến")]
        public string Ykien { get; set; }
        public Nullable<int> LoaiChuyen { get; set; }

        [Display(Name = "Tên người chuyển")]
        public string TenNguoiChuyen { get; set; }

        [Display(Name = "Tên người nhận")]
        public string TenNguoiNhan { get; set; }
        public Nullable<int> Active { get; set; }
        public string LuongBaoCao { get; set; }
        public Nullable<int> TraLoi_ID { get; set; }
    }
}
