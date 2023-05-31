namespace Lai_Kep.Models
{
	public class Laikep
	{
		public decimal Sotien { get; set; }
		public double Laisuat { get; set; }
		public int Sonam { get; set; }
		public int SoLanGui { get; set; }
		public double KetQua { get; set; }
		public Laikep() { }
		public Laikep(decimal sotien, double laisuat, int sonam, int soLanGui)
		{
			this.Sotien = sotien;
			this.Laisuat = laisuat;
			this.Sonam = sonam;
			this.SoLanGui = soLanGui;
			this.KetQua = (double)sotien * Math.Pow(coSo(laisuat,soLanGui), soMu(sonam, soLanGui));
		}
		public double coSo(double laisuat,int soLanGui)
		{
			laisuat = laisuat / 100;
			return 1 + (double)(laisuat / soLanGui);
		}
		public double soMu(int sonam, int soLanGui)
		{
			return sonam * soLanGui;
		}
	}
}