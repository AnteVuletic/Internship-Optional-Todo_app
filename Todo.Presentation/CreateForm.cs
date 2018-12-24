﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.Data;
using Todo.Domain;

namespace Todo.Presentation
{
    public partial class CreateForm : Form
    {
        private TodoItem _item = new TodoItem("",false);
        private ItemList _listPassed;
        public CreateForm(ItemList listPassed)
        {
            InitializeComponent();
            _listPassed = listPassed;

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            _item.Description = textBox.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _listPassed.AddItem(_item);
            Close();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            _item.Done = checkBox.Checked;
            if(checkBox.Checked)
                dateTimePicker.Show();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _item.Deadline = dateTimePicker.Value;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}