using Fallout.NET.TES4;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fallout.NET.Core
{
    public static class FindRegistryKeys
    {
        public static string GetFilename(GameID game)
        {
            string registryPath;
            string installedPathKey;
            switch (game)
            {
                default:
                    registryPath = @"SOFTWARE\WOW6432Node\bethesda softworks\Fallout3";
                    installedPathKey = "installed path";
                    break;
            }

            using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(registryPath))
            {
                var path = key.GetValue(installedPathKey);
                if (path != null)
                {
                    return System.IO.Path.Combine(path.ToString(), "Data", "Fallout3.esm");
                }
                else
                {
                    throw new Exception("Can not find installation path for Fallout 3");
                }
            }
        }
    }
}
