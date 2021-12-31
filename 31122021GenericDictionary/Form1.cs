using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31122021GenericDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        List<string> liste = new List<string>();
        Dictionary<int, string> dliste = new Dictionary<int, string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            liste.Add("Matematik");
            liste.Add("Fizik");
            liste.Add("Kimya");
            liste.Add("Biyoloji");
            liste.Add("İngilizce");

            dliste.Add(0,"Generic");
            dliste.Add(1, "List<>");
            dliste.Add(2, "Dictionary<>");
            dliste.Add(3, "SortedList<>");
            dliste.Add(4, "stack<>");
            dliste.Add(5, "Queue<>");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(liste.ToArray<string>());
            MessageBox.Show($"Count : {liste.Count}");
            MessageBox.Show($"Capacity : {liste.Capacity.ToString()}");
            liste.TrimExcess();

            MessageBox.Show($"TrimExcess-Count : {liste.Count}");
            MessageBox.Show($"TrimExcess-Capacity : {liste.Capacity.ToString()}");

            MessageBox.Show($"TrimExcess-Count : {liste.Contains("Kimya")}");
            liste.Insert(0, "Türkçe");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int,string> item in dliste)
            {
                sb.Append(item.Key);
                sb.Append("-");
                sb.Append(item.Value);
                sb.AppendLine();

            }
            MessageBox.Show(sb.ToString());
         }
    }
}
