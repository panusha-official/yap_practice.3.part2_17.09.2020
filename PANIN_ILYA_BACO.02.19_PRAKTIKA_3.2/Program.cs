using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace encod
{
  class Program
  {
    static void Main(string[] args)
    {
      string fn = "file.txt";
      StreamWriter sw = new StreamWriter(fn, false, Encoding.UTF7);
      sw.WriteLine("Здравствуй, МИР!");
      sw.Close();
      StreamReader sr = new StreamReader(fn, Encoding.UTF7);
      Console.WriteLine(sr.ReadToEnd());
      sr.Close();
    }
  }
}