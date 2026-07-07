using System;
using System.Collections.Generic; // list
// --- NƠI CHẠY CHƯƠNG TRÌNH ---
class Program
{
    static void Main(string[] args)
    {
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
        
        //danh sách các thiết bị
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