using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace luyenlan1.Model
{
    public class Sach
    {
        public string maSach;
        public string tenSach;
        public string nhaxb;
        public int namxb;
        public string tacgia;
        public double dongia;
        public string hinhanh;
        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string Nhaxb { get => nhaxb; set => nhaxb = value; }
        public int Namxb { get => namxb; set => namxb = value; }
        public string Tacgia { get => tacgia; set => tacgia = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }

        public Sach() { }
        public Sach(string maSach, string tenSach, string nhaxb, int namxb, string tacgia, double dongia, string hinhanh)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.nhaxb = nhaxb;
            this.namxb = namxb;
            this.tacgia = tacgia;
            this.dongia = dongia;
            this.hinhanh = hinhanh;
        }
        
        

    }
}