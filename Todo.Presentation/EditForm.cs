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
        private ItemRepository _listPassed;
        public EditForm(TodoItem item,ItemRepository listPassed)
        {
            InitializeComponent();
            _item = item;
            _listPassed = listPassed;
            noteTextbox.Text = item.Description;
            checkBox.Checked = !item.IsDone;
            if (!item.IsDone)
            {
                dateTimePicker.Show();
                dateTimePicker.Value = item.Deadline;
            }
            else
                dateTimePicker.Hide();
        }

        private void noteTextbox_TextChanged(object sender, EventArgs e)
        {
            _item.Description = noteTextbox.Text;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            _item.IsDone = checkBox.Checked;
            if (!_item.IsDone)
                dateTimePicker.Show();
            else
                dateTimePicker.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _item.Deadline = dateTimePicker.Value;
            _listPassed.RemoveItem(_item.Id);
            _listPassed.AddItem(_item);
            Close();
        }
    }
}
