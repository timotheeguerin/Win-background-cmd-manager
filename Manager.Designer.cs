﻿namespace CmdInTray
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.remove_script_button = new System.Windows.Forms.Button();
            this.new_script_button = new System.Windows.Forms.Button();
            this.script_list = new System.Windows.Forms.ListView();
            this.script_list_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.script_list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.script_list_command = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.script_list_running = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.script_list_auto_start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.script_status_label = new System.Windows.Forms.Label();
            this.restart_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.script_name_input = new System.Windows.Forms.TextBox();
            this.script_command_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.save_input_button = new System.Windows.Forms.Button();
            this.script_working_dir_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.console_richtext_box = new System.Windows.Forms.RichTextBox();
            this.open_log_button = new System.Windows.Forms.Button();
            this.script_auto_start_checkbox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.79533F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.20467F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.script_list, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.89474F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.10526F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(472, 380);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.remove_script_button, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.new_script_button, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 337);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(466, 40);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // remove_script_button
            // 
            this.remove_script_button.Enabled = false;
            this.remove_script_button.Location = new System.Drawing.Point(3, 3);
            this.remove_script_button.Name = "remove_script_button";
            this.remove_script_button.Size = new System.Drawing.Size(227, 34);
            this.remove_script_button.TabIndex = 0;
            this.remove_script_button.Text = "Remove";
            this.remove_script_button.UseVisualStyleBackColor = true;
            this.remove_script_button.Click += new System.EventHandler(this.remove_script_button_Click);
            // 
            // new_script_button
            // 
            this.new_script_button.Location = new System.Drawing.Point(236, 3);
            this.new_script_button.Name = "new_script_button";
            this.new_script_button.Size = new System.Drawing.Size(227, 34);
            this.new_script_button.TabIndex = 1;
            this.new_script_button.Text = "New";
            this.new_script_button.UseVisualStyleBackColor = true;
            this.new_script_button.Click += new System.EventHandler(this.new_script_button_Click);
            // 
            // script_list
            // 
            this.script_list.AllowColumnReorder = true;
            this.script_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.script_list_id,
            this.script_list_name,
            this.script_list_command,
            this.script_list_running,
            this.script_list_auto_start});
            this.script_list.FullRowSelect = true;
            this.script_list.HideSelection = false;
            this.script_list.Location = new System.Drawing.Point(3, 3);
            this.script_list.Name = "script_list";
            this.script_list.Size = new System.Drawing.Size(466, 328);
            this.script_list.TabIndex = 1;
            this.script_list.UseCompatibleStateImageBehavior = false;
            this.script_list.View = System.Windows.Forms.View.Details;
            this.script_list.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.script_list_ItemSelectionChanged);
            // 
            // script_list_id
            // 
            this.script_list_id.Text = "id";
            this.script_list_id.Width = 0;
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
            this.script_list_command.Width = 212;
            // 
            // script_list_running
            // 
            this.script_list_running.Text = "Running";
            this.script_list_running.Width = 72;
            // 
            // script_list_auto_start
            // 
            this.script_list_auto_start.Text = "Auto start";
            this.script_list_auto_start.Width = 65;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.console_richtext_box, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.open_log_button, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(481, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(459, 394);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.script_name_input, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.script_command_input, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.script_working_dir_input, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(453, 144);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel3.Controls.Add(this.script_status_label, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.restart_button, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.start_button, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.stop_button, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(77, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.57724F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(354, 29);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // script_status_label
            // 
            this.script_status_label.AutoSize = true;
            this.script_status_label.Location = new System.Drawing.Point(3, 0);
            this.script_status_label.Name = "script_status_label";
            this.script_status_label.Size = new System.Drawing.Size(0, 13);
            this.script_status_label.TabIndex = 9;
            // 
            // restart_button
            // 
            this.restart_button.Enabled = false;
            this.restart_button.Location = new System.Drawing.Point(273, 3);
            this.restart_button.Name = "restart_button";
            this.restart_button.Size = new System.Drawing.Size(75, 23);
            this.restart_button.TabIndex = 6;
            this.restart_button.Text = "Restart";
            this.restart_button.UseVisualStyleBackColor = true;
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // start_button
            // 
            this.start_button.Enabled = false;
            this.start_button.Location = new System.Drawing.Point(120, 3);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(72, 23);
            this.start_button.TabIndex = 5;
            this.start_button.Text = "Start";
            this.start_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Enabled = false;
            this.stop_button.Location = new System.Drawing.Point(198, 3);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(69, 23);
            this.stop_button.TabIndex = 4;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // script_name_input
            // 
            this.script_name_input.Location = new System.Drawing.Point(77, 50);
            this.script_name_input.Name = "script_name_input";
            this.script_name_input.ReadOnly = true;
            this.script_name_input.Size = new System.Drawing.Size(359, 20);
            this.script_name_input.TabIndex = 0;
            // 
            // script_command_input
            // 
            this.script_command_input.Location = new System.Drawing.Point(77, 71);
            this.script_command_input.Name = "script_command_input";
            this.script_command_input.ReadOnly = true;
            this.script_command_input.Size = new System.Drawing.Size(359, 20);
            this.script_command_input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Command";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.8503F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.1497F));
            this.tableLayoutPanel7.Controls.Add(this.save_input_button, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.script_auto_start_checkbox, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(77, 119);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(359, 26);
            this.tableLayoutPanel7.TabIndex = 9;
            // 
            // save_input_button
            // 
            this.save_input_button.Enabled = false;
            this.save_input_button.Location = new System.Drawing.Point(271, 3);
            this.save_input_button.Name = "save_input_button";
            this.save_input_button.Size = new System.Drawing.Size(75, 20);
            this.save_input_button.TabIndex = 0;
            this.save_input_button.Text = "Save";
            this.save_input_button.UseVisualStyleBackColor = true;
            this.save_input_button.Click += new System.EventHandler(this.save_input_button_Click);
            // 
            // script_working_dir_input
            // 
            this.script_working_dir_input.Location = new System.Drawing.Point(77, 91);
            this.script_working_dir_input.Name = "script_working_dir_input";
            this.script_working_dir_input.ReadOnly = true;
            this.script_working_dir_input.Size = new System.Drawing.Size(359, 20);
            this.script_working_dir_input.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Working directory";
            // 
            // console_richtext_box
            // 
            this.console_richtext_box.Location = new System.Drawing.Point(3, 153);
            this.console_richtext_box.Name = "console_richtext_box";
            this.console_richtext_box.ReadOnly = true;
            this.console_richtext_box.Size = new System.Drawing.Size(453, 196);
            this.console_richtext_box.TabIndex = 3;
            this.console_richtext_box.Text = "";
            // 
            // open_log_button
            // 
            this.open_log_button.Location = new System.Drawing.Point(3, 370);
            this.open_log_button.Name = "open_log_button";
            this.open_log_button.Size = new System.Drawing.Size(75, 21);
            this.open_log_button.TabIndex = 4;
            this.open_log_button.Text = "Open log file";
            this.open_log_button.UseVisualStyleBackColor = true;
            // 
            // script_auto_start_checkbox
            // 
            this.script_auto_start_checkbox.AutoSize = true;
            this.script_auto_start_checkbox.Location = new System.Drawing.Point(3, 3);
            this.script_auto_start_checkbox.Name = "script_auto_start_checkbox";
            this.script_auto_start_checkbox.Size = new System.Drawing.Size(84, 17);
            this.script_auto_start_checkbox.TabIndex = 1;
            this.script_auto_start_checkbox.Text = "Run on start";
            this.script_auto_start_checkbox.UseVisualStyleBackColor = true;
            this.script_auto_start_checkbox.Click += new System.EventHandler(this.script_auto_start_checkbox_CheckedChanged);
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
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ListView script_list;
        private System.Windows.Forms.ColumnHeader script_list_name;
        private System.Windows.Forms.ColumnHeader script_list_command;
        private System.Windows.Forms.ColumnHeader script_list_running;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button remove_script_button;
        private System.Windows.Forms.Button new_script_button;
        private System.Windows.Forms.ColumnHeader script_list_id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button restart_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox script_name_input;
        private System.Windows.Forms.TextBox script_command_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button save_input_button;
        private System.Windows.Forms.Label script_status_label;
        private System.Windows.Forms.RichTextBox console_richtext_box;
        private System.Windows.Forms.Button open_log_button;
        private System.Windows.Forms.TextBox script_working_dir_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader script_list_auto_start;
        private System.Windows.Forms.CheckBox script_auto_start_checkbox;
    }
}