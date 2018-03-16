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

namespace ShrekGame
{
    public partial class FormMainGame : Form
    {
        public int lifes;
        public int round;

        public FormMainGame()
        {
            lifes = 3;
            round = 1;
            InitializeComponent();
            labelLifes.Text = lifes.ToString();
            labelRound.Text = round.ToString();
        }
        public FormMainGame(int ROUND,int LIFES)
        {
            lifes = LIFES;
            round = ROUND;
            InitializeComponent();
            labelLifes.Text = lifes.ToString();
            labelRound.Text = round.ToString();
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(round);
            stringBuilder.Append("*");
            stringBuilder.Append(lifes);
            File.WriteAllText(@"Save", stringBuilder.ToString());
            MessageBox.Show("Zapisano grę.", "Save");
        }
    }
}
