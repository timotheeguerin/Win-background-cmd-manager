namespace CmdInTray
{
    partial class Manager
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.script_list = new System.Windows.Forms.ListView();
            this.script_list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.script_list_command = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.script_list_running = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.79533F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.20467F));
            this.tableLayoutPanel1.Controls.Add(this.script_list, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 389);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // script_list
            // 
            this.script_list.AllowColumnReorder = true;
            this.script_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.script_list_name,
            this.script_list_command,
            this.script_list_running});
            this.script_list.FullRowSelect = true;
            this.script_list.HideSelection = false;
            this.script_list.Location = new System.Drawing.Point(3, 3);
            this.script_list.Name = "script_list";
            this.script_list.Size = new System.Drawing.Size(472, 302);
            this.script_list.TabIndex = 0;
            this.script_list.UseCompatibleStateImageBehavior = false;
            this.script_list.View = System.Windows.Forms.View.Details;
            // 
            // script_list_name
            // 
            this.script_list_name.Tag = "";
            this.script_list_name.Text = "Name";
            this.script_list_name.Width = 112;
            // 
            // script_list_command
            // 
            this.script_list_command.Text = "Command";
            this.script_list_command.Width = 282;
            // 
            // script_list_running
            // 
            this.script_list_running.Text = "Running";
            this.script_list_running.Width = 348;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 413);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Manager";
            this.Text = "Manager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView script_list;
        private System.Windows.Forms.ColumnHeader script_list_name;
        private System.Windows.Forms.ColumnHeader script_list_command;
        private System.Windows.Forms.ColumnHeader script_list_running;
    }
}