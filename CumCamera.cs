using System;
using System.Collections.Generic; // list
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