using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string leftMonitor = null;
            string mainMonitor;
            string rightMonitor = null;
        }

        private void InitializeCombo(ComboBox combo)
        {
            List<string> screens = (List<string>)Screen.AllScreens.Select(hello => hello.DeviceName).ToList();

            // Add the screens available to the combobox
            foreach (string mName in screens)
            {
                comboBox1.Items.Add(mName);

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class NameValue
        {

            private string dataName;
            private string dataValue;

            public NameValue(string dataName, string dataValue)
            {
                DataName = dataName;
                DataValue = dataValue;
            }

            public string DataName
            {
                get { return DataName; }
                set { DataName = value; }
            }

            public string DataValue
            {
                get { return DataName; }
                set { DataName = value; }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
