using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace luyenlan2.Models
{
    public class Sach
    {
        private string masach;
        private string tensach;
        private string nhaXb;
        private int namXb;
        private string tacgia;
        private double dongia;
        private string hinhanh;

        public string Masach { get => masach; set => masach = value; }
        public string Tensach { get => tensach; set => tensach = value; }
        public string NhaXb { get => nhaXb; set => nhaXb = value; }
        public int NamXb { get => namXb; set => namXb = value; }
        public string Tacgia { get => tacgia; set => tacgia = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }

        public Sach(string masach, string tensach, string nhaXb, int namXb, string tacgia, double dongia, string hinhanh)
        {
            Masach = masach;
            Tensach = tensach;
            NhaXb = nhaXb;
            NamXb = namXb;
            Tacgia = tacgia;
            Dongia = dongia;
            Hinhanh = hinhanh;
        }
        public Sach() { }
    }
}