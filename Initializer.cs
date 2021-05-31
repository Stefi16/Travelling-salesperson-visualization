using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseProjectTSP
{
    public partial class Initializer : Form
    {
        public Initializer()
        {
            InitializeComponent();
        }

        private void Initializer_Load(object sender, EventArgs e)
        {

        }

        private void generateRandom_Click(object sender, EventArgs e)
        {
            GlobalVariables.generateRandom = true;
            var t = new Visualizer();
            t.Show();
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            var t = matrix.Lines;
            string[][] strings = new string[t.Length][];
            for (int i = 0; i < t.Length; i++)
            {
                strings[i] = t[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

            GlobalVariables.adjecencyMatrix = new int[strings[0].Length, strings[0].Length];

            for (int i = 0; i < GlobalVariables.adjecencyMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < GlobalVariables.adjecencyMatrix.GetLength(1); j++)
                {
                    int converter = int.Parse(strings[i][j]);
                    GlobalVariables.adjecencyMatrix[i, j] = converter;
                }
            }
            var m = new Visualizer();
            m.Show();
            this.Close();
        }
    }
}
