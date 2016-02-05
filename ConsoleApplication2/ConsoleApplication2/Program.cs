using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string ct;
            string fout = "out.txt", fin = "in.txt";

            StreamReader fr = new StreamReader(fin, Encoding.GetEncoding(1215));
StreamReader fw = new StreamWriter (fout, false Encoding.GetEncoding(1215));

            st=fr.ReadLine();

            fr.Close();
            fw.Close();

            Console.WriteLine(st);
            Console.ReadLine;
        }
    }
}
