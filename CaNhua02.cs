using System;
using System.Collections.Generic; // list
//ngày 1 2 bai tap tạo class (thuộc tính và phương thức) có su dung đóng gói
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
                Console.WriteLine($"loi: Muc Nuoc hien tai sai");
        }
    }
    public CanNhua(double SucChua, double ChieuCao)
    {
        this.DungTichToiDa = SucChua;
        this.ChieuCaoCan = ChieuCao;
    }
        public void DoNuocVao(double lit)
    {
        if (this.MucNuocHienTai + lit > this.DungTichToiDa )
        {
            this.MucNuocHienTai = this.DungTichToiDa;
            Console.WriteLine($"Nuoc tran !!!!!");
        }
        else
        {
            this.MucNuocHienTai += lit; 
            Console.WriteLine($"Muc nuoc hien tai la: {this.MucNuocHienTai}.");
        }
    }
}


//ngay 3 class cha va class con
public class ThietBiDo
{
    public virtual void MaThietBi() => Console.WriteLine($"ma cua thiet bi:");
    public virtual void TrangThai() =>  Console.WriteLine($"trang thai hoat dong:");   
}
//ngay 4
public interface IConnectable
    {
        void ConnectSerial();
    }
// cum camera
public class CumCamera : ThietBiDo , IConnectable
{
    public string MaThietBiCamera {get; set; }
    public override void MaThietBi()
    {
        base.MaThietBi();
        Console.WriteLine(MaThietBiCamera);
    }
    public override void TrangThai()
    {
        Console.WriteLine($"trang thai hoat dong:true");
    }
    public void ConnectSerial()
    {
        Console.WriteLine($"Camera: Đang mo luong video tu cong serial...");
    }
}
// cam bien nhiet do
public class CamBienNhietDo : ThietBiDo , IConnectable
{
    public string MaThietBiCamBien {get; set; }
    public override void MaThietBi()
    {
        base.MaThietBi();
        Console.WriteLine(MaThietBiCamBien);
    }
    public override void TrangThai()
    {
        Console.WriteLine($"trang thai hoat dong:true");
    }
    public void ConnectSerial()
    {
        Console.WriteLine($"Cam bien: dang mo cong COM de nhan tin hieu so...");
    }
}

// --- NƠI CHẠY CHƯƠNG TRÌNH ---
class Program
{
    static void Main(string[] args)
    {
        // 1. Chạy phần CanNhua
        Console.WriteLine("--- PHẦN 1: CAN NHUA ---");
        CanNhua CaNhuaThu1 = new CanNhua(5.5, 30.0);
        while (true)
        {
            Console.WriteLine("Nhap muc nuoc hien tai (0 - 5.5):");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double MucNuoc) && MucNuoc >= 0 && MucNuoc <= 5.5)
            {
                CaNhuaThu1.MucNuocHienTaiCuaCaNhuaThu1 = MucNuoc;
                Console.WriteLine("Thong tin da duoc tiep nhan");
                break;
            }
            else
            {
                Console.WriteLine("Thong tin sai, yeu cau nhap lai:");
            }
        }
        Console.WriteLine($"Muc Nuoc Hien Tai Trong Ca: {CaNhuaThu1.MucNuocHienTaiCuaCaNhuaThu1}");

        Console.WriteLine("--- THIeT Bi ĐO ---");
        
        // Tạo danh sách các thiết bị (Dùng ThietBiDo để bao quát cả MaThietBi và TrangThai)
        List<ThietBiDo> danhSachThietBi = new List<ThietBiDo>();
        
        danhSachThietBi.Add(new CumCamera { MaThietBiCamera = "CAM-001" });
        danhSachThietBi.Add(new CamBienNhietDo { MaThietBiCamBien = "SEN-001" });

        foreach (var thietBi in danhSachThietBi)
        {
            Console.WriteLine("-----------------------------");
            //  Hiện mã thiết bị
            thietBi.MaThietBi();
            
            // Hiện trạng thái
            thietBi.TrangThai();
            
            // Kiểm tra và hiện Interface (ép kiểu)
            if (thietBi is IConnectable thietBiKetNoi)
            {
                thietBiKetNoi.ConnectSerial();
            }
        }

        Console.ReadLine();
    }
}