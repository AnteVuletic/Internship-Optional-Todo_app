using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.Domain;
using Todo.Data;

namespace Todo.Presentation
{
    public partial class EditForm : Form
    {
        private TodoItem _item;
        public EditForm(TodoItem item)
        {
            InitializeComponent();
            _item = item;
            noteTextbox.Text = item.Description;
            checkBox.Checked = item.Done;
            if (!item.Done)
                dateTimePicker.Hide();
            else
            {
                dateTimePicker.Show();
                dateTimePicker.Value = item.Deadline;
            }
        }

        private void noteTextbox_TextChanged(object sender, EventArgs e)
        {
            _item.Description = noteTextbox.Text;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            _item.Done = checkBox.Checked;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _item.Deadline = dateTimePicker.Value;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
