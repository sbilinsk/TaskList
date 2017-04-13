using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskList
{
    public partial class Form1 : Form
    {
        public MyArray list1 = new MyArray();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            list1.addToList(txtIn.Text);
            txtIn.Clear();
            Display();
            txtIn.Focus();

        }


        public class MyArray
        {

            private List<string> mainList = new List<string>();

            public List<string> MainList{
                get { return mainList; }
            }

            public void addToList(string st){
                mainList.Add(st);
            }

            public int listLength(){
                return mainList.Count();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Display();
        }


        public void Display(){
            txtOut.Clear();
            foreach(string st in list1.MainList){
                txtOut.Text += st + "\r\n";
            }
        }

        

        


        private void saveListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOperations fOps = new FileOperations();
            fOps.SaveList(list1.MainList);

        }

        private void loadListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOperations fileOps = new FileOperations();
            txtOut.Text = fileOps.LoadList();
        }
    }
    }

