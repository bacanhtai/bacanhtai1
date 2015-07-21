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
    using S4T_HaTinh.App_GlobalResources;

    public partial class TD_LuongCongViec
    {
        [Key]
        public int LuongCongViec_ID { get; set; }

        [Display(Name = "Mã hồ sơ")]
        public string MaHoSo { get; set; }

        [Display(Name = "Người gửi")]
        public string NguoiGui { get; set; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(ModelBinders), ErrorMessageResourceName = "FieldMustBeDate")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ngày gửi")]
        public Nullable<System.DateTime> NgayGui { get; set; }

        [Required(AllowEmptyStrings = false,ErrorMessageResourceType = typeof(ModelBinders), ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Người nhận")]
        public string NguoiNhan { get; set; }
        
        //[DataType(DataType.Date, ErrorMessageResourceType = typeof(ModelBinders), ErrorMessageResourceName = "FieldMustBeDate")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ngày hẹn trả")]
        public System.DateTime NgayHenTra { get; set; }

        [Display(Name = "Người duyệt")]
        public string NganhDuyet { get; set; }

        [Display(Name = "Nội dung")]
        public string NoiDung { get; set; }

        [Display(Name = "Trạng thái")]
        public Nullable<int> TrangThai { get; set; }
        public Nullable<int> LuongCha_ID { get; set; }

        [Display(Name = "Số thứ tự")]
        public int STT { get; set; }
        public int Cap_ID { get; set; }

        [Display(Name = "Loại hình chuyển xử lý")]
        public string Prefix { get; set; }
    }
}