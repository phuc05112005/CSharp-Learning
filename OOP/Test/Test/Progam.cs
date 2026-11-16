public class HocSinh
{
    private string hoTen;
    private int tuoi;
    private double diemTB; 

    public string HoTen
    {
        get { return hoTen; }
        set { hoTen = value; }
    }
    public int Tuoi
    {
        get { return tuoi; }
        set  
        {
            if (value > 0 && value < 100)
            {
                tuoi = value;

            }
        }
    }
    public double DiemTB
    {
        get { return diemTB; }
        set
        {
            if (value > 0 && value <= 10)
            {
                diemTB = value;
            }
        }
    }



    public HocSinh()
    {
        HoTen = "Nguyen Van A";
        Tuoi = 18;
        DiemTB = 8.5;
    }

    public HocSinh(string hoTen, int tuoi, double diemTB)
    {
        HoTen = hoTen;
        Tuoi = tuoi;
        DiemTB = diemTB;
    }
    public HocSinh(string hoTen, int tuoi)
    {
        HoTen = hoTen;
        Tuoi = tuoi;
    }


    public void HienThiThongTin()
    {
        Console.WriteLine("Ho ten: " + HoTen);
        Console.WriteLine("Tuoi: " + Tuoi);
        Console.WriteLine("Diem TB: " + DiemTB);
    }

}