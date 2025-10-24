using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADVG
{
    public partial class rules : Form
    {
        public rules()
        {
            InitializeComponent();
        }

        private void rules_Load(object sender, EventArgs e)
        {
            rulesLable.Text = " Rules of the Game \n\n";
            rulesLable.Text += "1.  The player will mak a serise of desisions\n";
            rulesLable.Text += "2.  The player will pick one button or the other to make the desisions \n";
            rulesLable.Text += "3.  The player will play throug the game and fight the final boss\n";
            rulesLable.Text += "4.  The player will make the final desision to end the game \n";


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
