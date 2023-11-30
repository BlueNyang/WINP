using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK12
{
    internal class MP3Player
    {
        public bool Loop { get; set; }
        public bool isOpened = false;

        private StringBuilder returnData;

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string _command, StringBuilder _returnData, int _returnLength, IntPtr _hwndCallBack);
        
        public MP3Player()
        {
            returnData = new StringBuilder(128);
        }

        public void Close()
        {
            if (isOpened)
            {
                string command = "close MediaFile";
                mciSendString(command, null, 0, IntPtr.Zero);
                Loop = false;
                isOpened = false;
            }
        }

        public void Open(string filename)
        {
            if (isOpened) Close();

            string command = $@"open ""{filename}"" type mpegvideo alias MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);

            isOpened = true;
        }

        public void Play()
        {
            if (isOpened)
            {
                string command = "play MediaFile";

                if (Loop)
                    command += " REPEAT";

                mciSendString(command, null, 0, IntPtr.Zero);
            }
        }

        public void Pause()
        {
            if(isOpened)
            {
                string command = "pause MediaFile";
                mciSendString(command, null, 0, IntPtr.Zero);
            }
        }

        public void Seek(int time)
        {
            string command = $@"seek MediaFile to {time}";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        public void Stop()
        {
            if (isOpened) Seek(0);
        }
        
        public string GetStatus()
        {
            returnData.Clear();

            string command = "status MediaFile mode";
            mciSendString(command, returnData, returnData.Capacity, IntPtr.Zero);

            return returnData.ToString();
        }

        public int GetLength()
        {
            returnData.Clear();

            if (isOpened)
            {
                string command = "status MediaFile length";
                mciSendString(command, returnData, returnData.Capacity, IntPtr.Zero);

                int length = int.Parse(returnData.ToString());

                return length;
            }
            else return 0;
        }

        public int GetPosition()
        {
            returnData.Clear();

            if (isOpened)
            {
                string command = "status MediaFile position";
                mciSendString(command, returnData, returnData.Capacity, IntPtr.Zero);

                int position = int.Parse(returnData.ToString());

                return position;
            }
            else return 0;
        }

    }
}
