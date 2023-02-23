using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Frameworkprojects
{
    internal class files
    {
        public void Writeinfile()
        {
            FileStream fs1 = new FileStream(@"C:\Inatech Training\CS Program\write.txt",FileMode.OpenOrCreate,FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs1);
            //bw.BaseStream.Seek(0, SeekOrigin.End);
            bw.Write("Hello welcome to program");
            bw.Write("Successfully written in the file");
            bw.Flush();
            bw.Close();
            fs1.Close();
        }
        public void readfromfile()
        {
            FileStream fs2 = new FileStream(@"C:\Inatech Training\CS Program\write.txt", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs2);
            br.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(br.ReadString());
        }
        public static void Main(string[] args) 
        {
            files f = new files();
            f.Writeinfile();  
            f.readfromfile();
        }
    }
}
