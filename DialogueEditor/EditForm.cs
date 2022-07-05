using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueEditor
{
    public partial class EditForm : Form
    {
        public string EditedText { get; set; } = "";
        public EditForm(string text)
        {
            InitializeComponent();
            EditedText = text;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            Txt_Text.Text = EditedText;
        }

        private void Txt_Text_TextChanged(object sender, EventArgs e)
        {
            EditedText = Txt_Text.Text;
        }
    }
}
