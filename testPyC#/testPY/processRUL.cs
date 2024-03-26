using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace testPY
{
    internal class processRUL
    {
        public processRUL() { }
        public string getRul()
        {
            string output = "";
            Process ML = new Process();
            ML.StartInfo = new ProcessStartInfo("python.exe") { Arguments = "Untitled.py", RedirectStandardOutput = true };
            ML.Start();
            output = ML.StandardOutput.ReadToEnd();
            return output;
        }
    }
}
