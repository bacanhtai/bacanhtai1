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
    using System.ComponentModel.DataAnnotations;
    using S4T_HaTinh.App_GlobalResources;

    public partial class sp_LichNhapLieuWithOption_Result
    {
        [Display(Name = "Hình thức")]
        public Nullable<int> ChucNang_ID { get; set; }

        [Display(Name = "Đến ngày")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime DenNgay { get; set; }

        [Display(Name = "Đơn vị")]
        public int DonVi_ID { get; set; }

        [Display(Name = "Mã lịch nhập liệu")]
        public int LichNhap_ID { get; set; }

        [Display(Name = "Phân hệ")]
        public int PhanHe_ID { get; set; }

        [Display(Name = "Trạng thái")]
        public int TrangThai { get; set; }

        [Display(Name = "Từ ngày")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime TuNgay { get; set; }

        [Display(Name = "Controller")]
        public string ControllerName { get; set; }

        [Display(Name = "View")]
        public string ActionName { get; set; }

        [Display(Name = "Tên chức năng")]
        public string TenChucNang { get; set; }

        [Display(Name = "Đợt báo cáo")]
        public Nullable<int> DotBaoCao_ID { get; set; }

        [Display(Name = "Năm")]
        public Nullable<int> Nam { get; set; }
    }
}
