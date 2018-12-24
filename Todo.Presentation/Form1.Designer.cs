namespace Todo.Presentation
{
    partial class Todo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Delete = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.TodoList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(313, 373);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(125, 49);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(153, 373);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(123, 49);
            this.Create.TabIndex = 1;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(489, 373);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(125, 49);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // TodoList
            // 
            this.TodoList.FormattingEnabled = true;
            this.TodoList.Location = new System.Drawing.Point(31, 26);
            this.TodoList.Name = "TodoList";
            this.TodoList.Size = new System.Drawing.Size(737, 319);
            this.TodoList.TabIndex = 3;
            this.TodoList.SelectedIndexChanged += new System.EventHandler(this.TodoList_SelectedIndexChanged);
            // 
            // Todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TodoList);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Delete);
            this.Name = "Todo";
            this.Text = "Todo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.CheckedListBox TodoList;
    }
}

