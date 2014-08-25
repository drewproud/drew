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

        // It hangs after I select the second monitor

        private Dictionary<string, string> monitorList = new Dictionary<string, string>
        {
            {"leftMonitor", ""},
            {"mainMonitor",""},
            {"rightMonitor", ""}
        };

        public Form1()
        {
            InitializeComponent();

            InitializeCombo(comboBox1);
            InitializeCombo(comboBox2);

        }

        public List<string> GetMonitorList()
        {
            List<string> thisList = (List<string>)Screen.AllScreens.Select(hello => hello.DeviceName).ToList();
            thisList.Add("<None>");
            return thisList;
        }

        public Dictionary<string, string> MonitorList
        {
            get { return monitorList; }
        }

        private void InitializeCombo(ComboBox combo)
        {
            // Creates the list of all screens attached to the computer
            List<string> screens = GetMonitorList();

            string currentText = combo.Text;

            // Clear all existing items in the current combobox
            combo.Items.Clear();

            Dictionary<string, string> mList = this.monitorList;

            // Add the screens available to the combobox that are not used in any other boxes
            foreach (string mName in screens)
            {
                if (!mList.Values.Any(mlist => mlist.Equals(mName)))
                {
                    combo.Items.Add(mName);
                }
            }

            // Reset it to the original selection
            combo.Text = currentText;
        }

        private void InitializeOtherCombos(ComboBox cBox)
        {
            Dictionary<string, string> mDict = this.monitorList; 

            foreach (Control combo in this.Controls)
            {
                if (combo is ComboBox)
                {
                    if (cBox.Name != combo.Name)
                    {
                        InitializeCombo(combo as ComboBox);
                    }
                }
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
            InitializeOtherCombos(comboBox1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeOtherCombos(comboBox2);
        }
    }
}
