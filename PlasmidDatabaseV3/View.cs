using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlasmidDatabaseV3
{
    public partial class View : Form
    {
        public bool SaveCmd { get; set; }
        public string NameInput { get; set; }
        public string SequenceInput { get; set; }

        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        private void TxtbxPlasmidName_TextChanged(object sender, EventArgs e)
        {
            NameInput = ((TextBox)sender).Text;
        }

        private void TxtbxPlasmidSequence_TextChanged(object sender, EventArgs e)
        {
            SequenceInput = ((TextBox)sender).Text;
        }

        private void CmdSaveInput_Click(object sender, EventArgs e)
        {
            SaveCmd = true;
        }
    }
}
