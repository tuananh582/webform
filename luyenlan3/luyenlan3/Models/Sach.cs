using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace luyenlan3.Models
{
    public class Sach
    {
        private string masach;
        private string tensach;
        private string nhaxb;
        private int namxb;
        private string tacgia;
        private double dongia;
        private string hinhanh;

        public string Masach { get => masach; set => masach = value; }
        public string Tensach { get => tensach; set => tensach = value; }
        public string Nhaxb { get => nhaxb; set => nhaxb = value; }
        public int Namxb { get => namxb; set => namxb = value; }
        public string Tacgia { get => tacgia; set => tacgia = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }

        public Sach() { }
        public Sach(string masach, string tensach, string nhaxb, int namxb, string tacgia, double dongia, string hinhanh)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.nhaxb = nhaxb;
            this.namxb = namxb;
            this.tacgia = tacgia;
            this.dongia = dongia;
            this.hinhanh = hinhanh;
        }
        
    }
}