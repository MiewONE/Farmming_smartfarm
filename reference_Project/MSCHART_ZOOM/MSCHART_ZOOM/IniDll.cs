using System;
using System.Runtime.InteropServices;//Using Dll
using System.Text;

namespace MSCHART_ZOOM
{
     public static class IniDll
    { 


    [DllImport("kernel32")]//DLL Import 
    private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
    /// <summary>INI Write </summary>
    public static long Writeini(string section, string key, string val, string filePath = null)
    {
        return WritePrivateProfileString(section, key, val, filePath);
    }
    /// <summary>INI Write </summary>
    public static String Readini(string section, string key, string def, string filePath)
    {
        int size = 256;
        int rtn = 0;
        StringBuilder retVal = new StringBuilder(size);
        if (0 == GetPrivateProfileString(section, key, "", retVal, size, filePath))
        {
            WritePrivateProfileString(section, key, def, filePath);
        }
        if ((rtn = GetPrivateProfileString(section, key, def, retVal, size, filePath)) > 0)
        {
            return retVal.ToString();
        }
        else return "";
    }

   }
}
