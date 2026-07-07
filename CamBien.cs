using System;
using System.Collections.Generic; // list
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