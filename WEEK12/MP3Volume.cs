using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WEEK12
{
    internal class MP3Volume
    {
        public int Volume
        {
            get
            {
                return GetSoundVolume();
            }
            set
            {
                SetSountVolume(value);
            }
        }

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr waveOutHandle, out uint dwVolume);
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr waveOutHandle, uint dwVolume);


        public MP3Volume() { }

        public void SetSountVolume(int volume)
        {
            try
            {
                int newVolume = (ushort.MaxValue / 100) * volume;
                uint newVolumeAllChannels = ((uint)newVolume & 0x0000ffff) | ((uint)newVolume << 16);
                waveOutSetVolume(IntPtr.Zero, newVolumeAllChannels);
            }
            catch (Exception) { }
        }

        public int GetSoundVolume()
        {
            int value = 0;
            try
            {
                uint CurrVol = 0;
                waveOutGetVolume(IntPtr.Zero, out CurrVol);
                ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
                value = CalcVol / (ushort.MaxValue / 100);
            }
            catch (Exception) { }
            return value;
        }

    }
}
