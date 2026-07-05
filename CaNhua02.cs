using System;
//ngày 2 bai tap tạo class (thuộc tính và phương thức)
class CanNhua
{
    private Double DungTichToiDa;
    private Double ChieuCaoCan;
    private Double MucNuocHienTai;

    public Double MucNuocHienTaiCuaCaNhuaThu1
    {
        get { return MucNuocHienTai;}
        set
        {
            if ( value >= 0 && value <= DungTichToiDa )
                MucNuocHienTai = value;
            else 
                Console.WriteLine($"lỗi: Muc Nuoc hien tai sai");
        }
    }
    public CanNhua(double SucChua, double ChieuCao)
    {
        this. DungTichToiDa = SucChua;
        this. ChieuCaoCan = ChieuCao;
    }
        public void DoNuocVao(double lit)
    {
        if (this. MucNuocHienTai + lit > this.DungTichToiDa )
        {
            this. MucNuocHienTai = this.DungTichToiDa;
            Console.WriteLine($"Nuoc tran !!!!!");
        }
        else
        {
            this.MucNuocHienTai += lit; 
            Console.WriteLine($"Muc nuoc hien tai la: {this. MucNuocHienTai}.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        CanNhua CaNhuaThu1 = new CanNhua(5.5 , 30.0 );
       while(true)
        {
            Console.WriteLine($"Nhap muc nuoc hien tai:");
            string input = Console.ReadLine();
            if(double.TryParse(input ,out double MucNuoc) && MucNuoc >= 0 && MucNuoc <= 5.5 )
            {
                CaNhuaThu1. MucNuocHienTaiCuaCaNhuaThu1 = MucNuoc;
                Console.WriteLine($"Thong tin da duoc tiep nhan");
                break;
            }
            else
            {
                Console.WriteLine($"Thong tin sai, yeu cau nhap lai:");
            }
        }
        Console.WriteLine($"Muc Nuoc Hien Tai Trong Ca:{CaNhuaThu1. MucNuocHienTaiCuaCaNhuaThu1}");
        CaNhuaThu1.DoNuocVao(1.6);
        CaNhuaThu1.DoNuocVao(1.0);
    }
}