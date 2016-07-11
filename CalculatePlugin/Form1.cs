using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatePlugin
{
    // http://csharptechnique.blogspot.com/2015/01/vi-du-on-gian-ve-plug-in.html
    public partial class Form1 : Form
    {
        private ArrayList plugins = new ArrayList();
        private int a;
        private int b;
        public Form1()
        {
            InitializeComponent();
            lstFunction.Items.Add("Add");
        }

        private void addPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.InitialDirectory = "c:\\";
            openDlg.Filter = "Calculate plugin files (*dll)|*dll";
            if(openDlg.ShowDialog()==DialogResult.OK)
            {
                string file = openDlg.FileName;
                AddPluginToolStripMenuItem(file);
            }
        }

        private void AddPluginToolStripMenuItem(string file)
        {
            try
            {
                Assembly ab = Assembly.LoadFrom(file);
                Type[] types = ab.GetTypes();
                foreach(Type t in types)
                {
                    if(t.GetInterface("ICalculate")!=null)
                    {
                        plugins.Add(ab.CreateInstance(t.FullName));
                        lstFunction.Items.Add(t.FullName);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOperate_Click(object sender, EventArgs e)
        {
            if (this.lstFunction.SelectedIndex == -1)
                return;

            a = int.Parse(txtnumber1.Text.Trim());
            b = int.Parse(txtnumber2.Text.Trim());

            if(this.lstFunction.SelectedIndex == 0)
            {
                MessageBox.Show((a + b).ToString());
            }
            else
            {
                object selObj = this.plugins[this.lstFunction.SelectedIndex - 1];
                Type t = selObj.GetType();
                MethodInfo onOperate = t.GetMethod("Operate");
                object returnValue = onOperate.Invoke(selObj, new object[] { a, b });

                MessageBox.Show(returnValue.ToString());
            }
        }
    }
}
