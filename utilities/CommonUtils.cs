using System;

namespace Utilities
{
    public class CommonUtils
    {
        public static void WaitForSeconds(int seconds)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }
    }
}