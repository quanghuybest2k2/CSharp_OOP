using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class HinhChuNhat : IHinhHoc
    {
        public float Dai { get; set; }
        public float Rong { get; set; }

        public HinhChuNhat(float dai, float rong)
        {
            this.Dai = dai;
            this.Rong = rong;
        }
        public float TinhChuVi()
        {
            return (Dai + Rong) * 2;
        }

        public float TinhDienTich()
        {
            return Dai * Rong;
        }
    }
}
