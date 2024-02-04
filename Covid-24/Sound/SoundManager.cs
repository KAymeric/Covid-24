using System;
using System.Runtime.InteropServices;
using System.Timers;


namespace Covid_24.Sound
{
    class SoundManager
    {

        const uint _APPCOMMAND_VOLUME_UP = 0xA0000;
        const int _WM_APPCOMMAND = 0x319;
        private System.Timers.Timer _timer;

        public SoundManager() 
        {
            _timer = new System.Timers.Timer(50);
            _timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        }

        // this method MUST be static
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public void VolMax()
        {
            SendMessageW(new IntPtr(0xFFFF), _WM_APPCOMMAND, IntPtr.Zero, (IntPtr)_APPCOMMAND_VOLUME_UP);

            Thread.Sleep(1000);
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            VolMax();
        }

    }
}