using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LuuDucDat_017.Models
{
    [Table("SinhViens")]
    public class SinhVien : LopHoc
    {
        public string  MaSinhVien { get; set; }
        public string  TenSinhVien { get; set; }
    }
}