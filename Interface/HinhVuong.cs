using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class HinhVuong : IHinhHoc
    {
        public float Canh { get; set; }
        public HinhVuong(float canh)
        {
            this.Canh = canh;
        }
        public float TinhChuVi()
        {
            return Canh * 4;
        }

        public float TinhDienTich()
        {
            return Canh * Canh;
        }
    }
}
