using System;
//ngày 1 bai tap tạo class (thuộc tính và phương thức)
class CanNhua
{
    public Double DungTichToiDa;
    public Double ChieuCaoCan;
    public Double MucNuocHienTai;

    public CanNhua(double SucChua, double ChieuCao)
    {
        this. DungTichToiDa = SucChua;
        this. ChieuCaoCan = ChieuCao;
        this. MucNuocHienTai = 0;
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
        CaNhuaThu1.DoNuocVao(2.6);
        CaNhuaThu1.DoNuocVao(5.0);
    }
}