using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LAB01
{
    public class SinhVien
    {
        private string msv;
        private string ten;
        private string khoa;
        private double diemTB;

        public SinhVien()
        {
            this.Msv = string.Empty;
            this.Ten = string.Empty;
            this.Khoa = string.Empty;
            this.DiemTB = 0;
        }

        public SinhVien(string msv, string ten, string khoa, double diemTB)
        {
            this.Msv = msv;
            this.Ten = ten;
            this.Khoa = khoa;
            this.DiemTB = diemTB;
        }

        public string Msv
        {
            get
            {
                return msv;
            }
            set
            {
                // Regex - https://vietnix.vn/regex-la-gi/
                string regex = "^\\d{10}$";
                msv = Regex.IsMatch(value, regex) ? value : "0000000000";
            }
        }
        public string Ten
        {
            get
            {
                return toTitleCase(ten);
            }
            set
            {
                string regex = "^.{5,100}$";
                ten = Regex.IsMatch(value, regex) ? value : "No Name";
            }
        }
        public string Khoa
        {
            get
            {
                return khoa;
            }
            set
            {
                khoa = value;
            }
        }
        public double DiemTB
        {
            get
            {
                return diemTB;
            }
            set
            {
                diemTB = (value >= 0 && value <= 10) ? value : 0;
            }
        }

        public override string ToString()
        {
            return $"Ma Sinh Vien: {this.Msv}, Ten: {this.Ten}, Khoa: {this.Khoa}, Diem TB: {this.DiemTB}";
        }

        public string toTitleCase (string text)
        {
            string result = "";
            // le hoang phuc => Le Hoang Phuc
            string[] words = text.Split(" "); // Cat chuoi thanh cac tu, cat theo khoang trang

            // le => Le
            // LE => Le
            foreach (string word in words)
            {
                string kyTuDau = "";
                string cacKyTuConLai = "";
                if (word.Length >= 1)
                    kyTuDau = word.Substring(0, 1).ToUpper(); // Lay ky tu dau va chuyen sang chu hoa
                if (word.Length >= 2)
                    cacKyTuConLai = word.Substring(1).ToLower(); // Lay cac ky tu con lai va chuyen sang chu thuong
                result += kyTuDau + cacKyTuConLai + " "; // Noi ky tu dau va cac ky tu con lai, sau do them 1 khoang trang
            }
            return result.Trim(); // Xoa di khoang trang o dau va cuoi chuoi
        }

        public void nhapDuLieu()
        {
            Console.Write("Nhap ma sinh vien: ");
            this.Msv = Console.ReadLine();
            Console.Write("Nhap ten: ");
            this.Ten = Console.ReadLine();
            Console.Write("Nhap khoa: ");
            this.Khoa = Console.ReadLine();
            Console.Write("Nhap DTB: ");
            this.DiemTB= double.Parse(Console.ReadLine());

        }

        public void show()
        {
            Console.WriteLine(this);
        }
    }
}
