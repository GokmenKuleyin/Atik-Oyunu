using System;
using System.Windows.Forms;

namespace g191210054
{
    public class Oyun : IOyun
    {
        //Kalan süreyi ayarlama.
        private readonly Timer _KalanSureTimer = new Timer { Interval = 1000 };
        private TimeSpan _kalansure; 
        //Oyunun başlamasını ve bitmesini kontrol eden kod.
        public bool OyunDevamEdiyorMu { get; private set; }
        

        public event EventHandler KalanSureDegisti;

        public Oyun()
        {
            _KalanSureTimer.Tick += KalanSureTimer_Tick;
        }
        private void KalanSureTimer_Tick(object sender, EventArgs e)
        {
            
            KalanSure += TimeSpan.FromSeconds(-1);
           
        }

        public void Baslat()
        {
            if (OyunDevamEdiyorMu) return;

             OyunDevamEdiyorMu = true;

            _KalanSureTimer.Start();
        }

        public void Bitir()
        {
            if (!OyunDevamEdiyorMu) return;

            OyunDevamEdiyorMu = false;

            _KalanSureTimer.Stop();
        }
        public TimeSpan KalanSure
        {
            get => _kalansure;
            private set
            {
                _kalansure = value;

                KalanSureDegisti?.Invoke(this, EventArgs.Empty);

                
            }
        }
        
    }
}
