using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TaskList
{
    public class FileOperations
    {


        public void SaveList(List<string> list)
        {
            StreamWriter file2 = new StreamWriter(@"c:\file.txt",true);
            for(int i = 0; i < list.Count(); i++)
            {
                file2.WriteLine(list[i].ToString());
            }
            
            file2.Close();

        }

       public string LoadList()
        {
            string line;
            string output = "";
            StreamReader read = new StreamReader(@"c:\file.txt", true);
            while((line = read.ReadLine()) != null)
            {
                output += line + "\r\n";
            }

            return output;
            
        }
    }
}
