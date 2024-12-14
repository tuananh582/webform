using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace luyenlai.Model
{
    public class Sach
    {
        private string maSach;
        private string tenSach;
        private string nhaXB;
        private int namxb;
        private string tacgia;
        private double dongia;
        private string hinhanh;
        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string NhaXB { get => nhaXB; set => nhaXB = value; }
        public int Namxb { get => namxb; set => namxb = value; }
        public string Tacgia { get => tacgia; set => tacgia = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public Sach() { }

        public Sach(string maSach, string tenSach, string nhaXB, int namxb, string tacgia, double dongia, string hinhanh)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.nhaXB = nhaXB;
            this.namxb = namxb;
            this.tacgia = tacgia;
            this.dongia = dongia;
            this.hinhanh = hinhanh;
        }
    }
}