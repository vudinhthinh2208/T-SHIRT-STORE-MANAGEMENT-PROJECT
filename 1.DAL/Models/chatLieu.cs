using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class chatLieu
    {
        public int IDChatlieu { get; set; }
        public string? ChatLieu { get; set; }
        public bool trangThai { get; set; }
        public virtual List<sanPhamChiTiet>? SanphamChitietss { get; set; }
    }
}
