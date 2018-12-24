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

namespace Todo.Presentation
{
    public partial class Todo : Form
    {
        private ItemList _listOfItems;
        public Todo()
        {
            InitializeComponent();
            _listOfItems = new ItemList();
            RefreshTodoList();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            var createWindow = new CreateForm(_listOfItems);
            createWindow.ShowDialog();
            RefreshTodoList();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }
        private void RefreshTodoList()
        {
            TodoList.Items.Clear();
            foreach (var item in _listOfItems.GetAll())
            {
                TodoList.Items.Add(item);
            }
        }
        private void TodoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
