using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowNetFloristProj
{
    public  class ConsoleOutputSaver
    {

        private StreamWriter fileStreamWriter;
        public void RedirectConsoleOutputToFile(string filePath)
        {
            // Create a new file and set the console output to write to it
            fileStreamWriter = new StreamWriter(filePath, false, Encoding.UTF8);
            Console.SetOut(fileStreamWriter);
        }

        public void RestoreConsoleOutput()
        {
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            fileStreamWriter.Close();
        }

    }
}
