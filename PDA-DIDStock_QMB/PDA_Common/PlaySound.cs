using System;
using System.Collections.Generic;
using System.Text;

namespace PDA_DIDSlotLink
{
    public class PlaySound
    {
        public const int SND_ASYNC = 0x0001;
        public const int SND_SYNC = 0X0;
        public const int SND_LOOP = 0X8;
        string strSoundPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        [System.Runtime.InteropServices.DllImport("CoreDll.DLL", EntryPoint = "PlaySound", SetLastError = true)]

        private extern static int MobilePlaySound(string szSound, IntPtr hMod, int flags);

        //Paly the sound need play 
        public void Play(string strFileName)
        {
            System.Threading.Thread.Sleep(1000);
            long intRetval;
            intRetval = MobilePlaySound(strSoundPath+strFileName, IntPtr.Zero, SND_ASYNC);            
        }

    }
}
