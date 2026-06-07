using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ThoiGian
{
    // Fields - Truong du lieu
    private int nam;
    private int thang;
    private int ngay;
    private int gio;
    private int phut;
    private int giay;

    // Properties - Thuoc tinh
    public int Nam
    {
        get { return nam; }
        set 
        {
            nam = value >= 0 ? value : 0;
        }
    }

    public int Thang
    {
        get
        {
            return thang;
        }
        set
        {
            thang = (value >= 1 && value <= 12) ? value : 0;
        }
    }
    public int Ngay
    {
        get
        {
            return ngay;
        }
        set
        {
            ngay = (value >= 1 && value <= 31) ? value : 0;
        }
    }
    public int Gio
    {
        get
        {
            return gio;
        }
        set
        {
            gio = (value >= 0 && value <= 23) ? value : 0;
        }
    }
    public int Phut
    {
        get
        {
            return phut;
        }
        set
        {
            phut = (value >= 0 && value <= 59) ? value : 0;
        }
    }
    public int Giay
    {
        get
        {
            return giay;
        }
        set
        {
            giay = (value >= 0 && value <= 59) ? value : 0;
        }
    }
    public ThoiGian()
    {
        this.Nam = 0; // this => tro toi doi tuong hien tai
        this.Thang = 0;
        this.Ngay = 0;
        this.Gio = 0;
        this.Phut = 0;
        this.Giay = 0;
    }
    public ThoiGian(int nam, int thang, int ngay, int gio, int phut, int giay)
    {
        this.Nam = nam;
        this.Thang = thang;
        this.Ngay = ngay;
        this.Gio = gio;
        this.Phut = phut;
        this.Giay = giay;
    }

    public ThoiGian(ThoiGian tg)
    {
        this.Nam = tg.Nam;
        this.Thang = tg.Thang;
        this.Ngay = tg.Ngay;
        this.Gio = tg.Gio;
        this.Phut = tg.Phut;
        this.Giay = tg.Giay;
    }

    public ThoiGian(DateTime dt)
    {
        this.Nam = dt.Year;
        this.Thang = dt.Month;
        this.Ngay = dt.Day;
        this.Gio = dt.Hour;
        this.Phut = dt.Minute;
        this.Giay = dt.Second;
    }

    public void nhap()
    {
        Console.Write("Nhap nam: ");
        this.Nam = int.Parse(Console.ReadLine());
        Console.Write("Nhap thang: ");
        this.Thang = int.Parse(Console.ReadLine());
        Console.Write("Nhap ngay: ");
        this.Ngay = int.Parse(Console.ReadLine());
        Console.Write("Nhap gio: ");
        this.Gio = int.Parse(Console.ReadLine());
        Console.Write("Nhap phut: ");
        this.Phut = int.Parse(Console.ReadLine());
        Console.Write("Nhap giay: ");
        this.Giay = int.Parse(Console.ReadLine());
    }

    public override string ToString()
    {
        return $"{this.Nam}/{this.Thang}/{this.Ngay} {this.Gio}:{this.Phut}:{this.Giay}";
    }
}