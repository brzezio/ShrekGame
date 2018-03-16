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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            FormMainGame formMainGame = new FormMainGame();
            formMainGame.Show();
        }

        private void buttonLoadGame_Click(object sender, EventArgs e)
        {
            try
            {
                string wczytane = File.ReadAllText(@"Save");
                string[] dane = wczytane.Split('*');
                FormMainGame formMainGame = new FormMainGame(int.Parse(dane[0]), int.Parse(dane[1]));
                formMainGame.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Wczytanie gry nie powiodło się.", "LoadError");
            }
        }
    }
}
