using System;


public class SinhVien
{
    // Fields
    private string maSV;
    private string hoTen;
    private int namSinh;
    private double diemToan, diemLy, diemHoa;


    // Constructors
    public SinhVien()
    {
        MaSV = "0000000000";
        HoTen = "Chưa có tên";
        NamSinh = 1900;
        diemToan = 0;
        diemLy = 0;
        diemHoa = 0;
    }

    public SinhVien(string maSV, string hoTen, int namSinh, double diemToan, double diemLy, double diemHoa)
    {
        MaSV = maSV;
        HoTen = hoTen;
        NamSinh = namSinh;
        DiemToan = diemToan;
        DiemLy = diemLy;
        DiemHoa = diemHoa;
    }




    // Getters and Setters
    public string MaSV
    {
        get
        {
            return maSV;
        }
        set
        {
            if (value.Length == 10)
            {
                maSV = value;
            }
        }
    }

    public string HoTen
    {
        get
        {
            return hoTen;
        }
        set
        {
            if (value.Length > 0 && value.Length < 250) 
                hoTen = value;
        }
    }

    public int NamSinh
    {
        get
        {
            return namSinh;
        }
        set
        {
            if (value > 1900 && value <= 2026)
                namSinh = value;
        }
    }
    public double DiemToan
    {
        get
        {
            return diemToan;
        }
        set
        {
            if (value >= 0 && value <= 10)
                diemToan = value;
        }
    }
    public double DiemLy
    {
        get
        {
            return diemLy;
        }
        set
        {
            if (value >= 0 && value <= 10)
                diemLy = value;
        }
    }
    public double DiemHoa
    {
        get
        {
            return diemHoa;
        }
        set
        {
            if (value >= 0 && value <= 10)
                diemHoa =  value;
        }
    }


    public double TinhDiemTrungBinh()
    {
        return (diemToan + diemLy + diemHoa) / 3;
    }

    public string XepLoai()
    {
        double diemTB = TinhDiemTrungBinh();
        if (diemTB >= 8)
            return "Gioi";
        else if (diemTB >= 6)
            return "Kha";
        else if (diemTB >= 5)
            return "Trung binh";
        else
            return "Yeu";
    }

    public void HienThiThongTin()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Ma SV: {MaSV}\n" +
               $"Ho Ten: {HoTen}\n" +
               $"Nam Sinh: {NamSinh}\n" +
               $"Diem Toan: {DiemToan}\n" +
               $"Diem Ly: {DiemLy}\n" +
               $"Diem Hoa: {DiemHoa}\n" +
               $"Diem Trung Binh: {TinhDiemTrungBinh()}\n" +
               $"Xep Loai: {XepLoai()}";
    }

}