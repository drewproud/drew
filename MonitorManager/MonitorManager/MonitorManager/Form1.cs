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

        // Make sure these match up with the combobox names
        private Dictionary<string, string> monitorSelection = new Dictionary<string, string>
        {
            {"leftMonitor", ""},
            {"mainMonitor",""},
            {"rightMonitor", ""}
        };


        public Form1()
        {
            InitializeComponent();

            MonitorList = GetMonitorList();

            InitializeCombo(leftMonitor);
            InitializeCombo(mainMonitor);
            InitializeCombo(rightMonitor);

        }

        public List<string> MonitorList = new List<string>();

        public List<ComboBox> comboBoxList = new List<ComboBox>();

        // make internal things not public
        
        public void AddComboToList (ComboBox cBox)
        {
            if (!comboBoxList.Any(a => a.Name == cBox.Name))
            {
                comboBoxList.Add(cBox);
            }
        }

        public List<string> GetMonitorList()
        {
            List<string> thisList = (List<string>)Screen.AllScreens.Select(hello => hello.DeviceName).ToList();
            thisList.Add("<None>");
            thisList.Add("");
            return thisList;
        }

        public Dictionary<string, string> MonitorSelection
        {
            get { return monitorSelection; }
        }

        public void SetMonitorListValue(ComboBox combo)
        {
            monitorSelection[combo.Name] = combo.Text;
        }

        private void InitializeCombo(ComboBox combo)
        {
            // Creates the list of all screens attached to the computer
            List<string> screens = GetMonitorList();
            AddComboToList(combo);
            ChangeComboMembers(combo);

        }

        private void InitializeOtherCombos(ComboBox cBox)
        {
            foreach (ComboBox combo in comboBoxList)
            {
                MessageBox.Show(combo.Name);

                // Loop through all comboboxes
                if (combo is ComboBox)
                {

                    // MessageBox.Show("Current: " + cBox.Name + "Changing:" + combo.Name);

                    // Stores the combobox text
                    SetMonitorListValue(combo as ComboBox);

                    // Only change the values of comboboxes that were not the one currently being used
                    if (combo.Name != cBox.Name)
                    {
                        ChangeComboMembers(combo as ComboBox);
                    }
                }
            }
        }

        private void ChangeComboMembers(ComboBox combo)
        {
            // Remember what was in here before
            string currentText = combo.Text;

            MessageBox.Show("Changing:" + combo.Name + combo.Text);

            // Clear all existing items in the current combobox
            foreach (object item in combo.Items)
            {
                if (item.ToString() != currentText)
                {
                    combo.Items.Remove(item);
                }
            }

            // Add the screens available to the combobox that are not used in any other boxes
            foreach (string mName in MonitorList)
            {
                if (!(monitorSelection.Values.Any(value => value.Equals(mName))) && currentText != mName)
                {
                    combo.Items.Add(mName);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {}

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
            InitializeOtherCombos(sender as ComboBox);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeOtherCombos(sender as ComboBox);
        }

        private void rightMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeOtherCombos(sender as ComboBox);
        }
    }
}
