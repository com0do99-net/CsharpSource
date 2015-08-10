using System;
using System.Collections.Generic;
using System.Text;

//Reference
using System.Diagnostics;
using System.Runtime.InteropServices;

//http://www.pinvoke.net/default.aspx/kernel32.setprocessworkingsetsize

namespace Source_Browser_Optimizer
{
    public class WorkingSet
    {
        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        static extern bool SetWorkingSet(IntPtr handle, int minimum, int maximum);

        public static void setMaximizeProcess(string process_name, int minimum, int maximum)
        {
            Process[] setMaximize = Process.GetProcessesByName(process_name);
            foreach (Process theprocess in setMaximize)
                if (setMaximize.Length > 0)
                    SetWorkingSet(theprocess.Handle, minimum, maximum);
        }
    }
}
