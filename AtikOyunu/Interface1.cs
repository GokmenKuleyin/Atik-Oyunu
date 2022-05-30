using System;

namespace g191210054
{

    public interface IOyun
    {
        bool OyunDevamEdiyorMu { get; }        
        void Baslat();
        event EventHandler KalanSureDegisti;

    }
    
    
    public interface IAtik
    {
        
        int Hacim { get; }
        
    }
    public interface IAtikKutusu : IDolabilen
    {
        int BosaltmaPuani { get;set; }
        bool Ekle(Atik atik);
        bool Bosalt();
    }
    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; }
        int DolulukOrani { get; }
    }
}
