﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
   
    public class DanhMucModel
    {
        public int MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
      
        public List<ChiTietDanhMucModel> list_json_chitietdanhmuc { get; set; }
    }
    public class ChiTietDanhMucModel
    {
        public int MaChiTietDanhMuc { get; set; }
        public int MaDanhMuc { get; set; }
        public string TenChiTietDanhMuc { get; set; }
      

    }
}
