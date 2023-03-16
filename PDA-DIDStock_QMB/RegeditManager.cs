using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace PDA_DIDSlotLink
{
    public class RegeditManager
    {
        public static void write(string name,string value)
        {

            RegistryKey localMachine = Registry.LocalMachine;
            RegistryKey softWare = localMachine.OpenSubKey("SOFTWARE", true);
            RegistryKey key = softWare.CreateSubKey("PDA");

            key.SetValue(name, value); 
        }

        public static string Read(string name)
        {
            RegistryKey localMachine = Registry.LocalMachine;
            RegistryKey softWare = localMachine.OpenSubKey("SOFTWARE",false);
            RegistryKey key = softWare.OpenSubKey("PDA", false);
            if (key == null)
                return "";

            return key.GetValue(name).ToString();
  
        }

        private static bool exists(string name)
        {
            string[] subKeyNames;

            RegistryKey localMachine = Registry.LocalMachine;
            RegistryKey softWare = localMachine.OpenSubKey("SOFTWARE", true);
            RegistryKey key = softWare.OpenSubKey("PDA", true);

            subKeyNames = key.GetSubKeyNames();

            foreach (string keyName in subKeyNames)
            {
                if (keyName == name)
                {
                    return true;
                }
            }

            return false;

        }
    }
}
