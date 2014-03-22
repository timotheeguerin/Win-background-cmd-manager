using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CmdInTray
{
    public partial class Manager : Form
    {
        private Script selected_script;

        public Manager()
        {
            InitializeComponent();
            ScriptManager.instance().scriptOutputReceived += new ScriptManager.EventHandler(handleScriptOutput);
            this.FormClosing += Manager_Closing;
            /*this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.Text = string.Empty;
            */
            updateDisplay();
        }

        private void Manager_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            ScriptManager.instance().scriptOutputReceived -= handleScriptOutput;
        }

        public void updateDisplay()
        {
            ScriptManager.instance().save();
            script_list.Items.Clear();
            foreach (Script script in ScriptManager.instance().scripts)
            {
                ListViewItem item = new ListViewItem(script.id.ToString());
                item.SubItems.Add(script.name);
                item.SubItems.Add(script.command);
                item.SubItems.Add(script.isRunning().ToString());
                item.SubItems.Add(script.isAutoStart().ToString());
                script_list.Items.AddRange(new ListViewItem[] { item });
            }
            updateButtonStatus();
        }


        //Save the input
        private void save_input_button_Click(object sender, EventArgs e)
        {
            //save_input_button.Text = "Saved!";
            selected_script.name = script_name_input.Text;
            selected_script.command = script_command_input.Text;
            selected_script.working_directory = script_working_dir_input.Text;
            updateDisplay();
        }

        private void script_list_ItemSelectionChanged(Object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selected_script = find_script_by_id(int.Parse(e.Item.Text));
            console_richtext_box.Text = selected_script.getLastLines();
            updateButtonStatus();
        }

        public void updateButtonStatus()
        {
            if (selected_script == null)
            {
                save_input_button.Enabled = false;
                start_button.Enabled = false;
                stop_button.Enabled = false;
                restart_button.Enabled = false;

                script_name_input.Text = "";
                script_command_input.Text = "";
                script_working_dir_input.Text = "";
                script_name_input.ReadOnly = true;
                script_command_input.ReadOnly = true;
                script_working_dir_input.ReadOnly = true;
                script_auto_start_checkbox.Enabled = false;

                remove_script_button.Enabled = false;
                script_status_label.Text = "";
            }
            else
            {
                save_input_button.Enabled = true;
                start_button.Enabled = !selected_script.isRunning();
                stop_button.Enabled = selected_script.isRunning();
                restart_button.Enabled = selected_script.isRunning();

                script_name_input.Text = selected_script.name;
                script_command_input.Text = selected_script.command;
                script_working_dir_input.Text = selected_script.working_directory;
                script_name_input.ReadOnly = false;
                script_command_input.ReadOnly = false;
                script_working_dir_input.ReadOnly = false;
                script_auto_start_checkbox.Enabled = true;
                script_auto_start_checkbox.Checked = selected_script.auto_start;

                remove_script_button.Enabled = true;
                if (selected_script.isRunning())
                {
                    this.script_status_label.Text = "Running!";
                }
                else
                {
                    this.script_status_label.Text = "Stopped!";
                }
            }
        }
        private Script find_script_by_id(int id)
        {
            foreach (Script script in ScriptManager.instance().scripts)
            {
                if (script.id == id)
                {
                    return script;
                }
            }
            return null;
        }

        private void remove_script_button_Click(object sender, EventArgs e)
        {
            if (selected_script != null)
            {
                ScriptManager.instance().scripts.Remove(selected_script);
            }
            selected_script = null;
            updateDisplay();
        }

        private void new_script_button_Click(object sender, EventArgs e)
        {
            Script script = new Script();
            script.name = "Unnamed script";
            script.command = "";
            ScriptManager.instance().scripts.Add(script);
            selected_script = script;
            updateDisplay();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (selected_script != null)
            {
                selected_script.start();
                updateDisplay();
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            if (selected_script != null)
            {
                selected_script.stop();
                updateDisplay();
            }
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            if (selected_script != null)
            {
                selected_script.restart();
                updateDisplay();
            }
        }
        private void handleScriptOutput(Script s, String e)
        {
            if (selected_script != null && s == selected_script)
            {
                Action action = () =>
                {
                    console_richtext_box.AppendText(e + Environment.NewLine);
                    console_richtext_box.ScrollToCaret();
                };
                console_richtext_box.BeginInvoke(action);
            }
        }

        private void script_auto_start_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (selected_script != null)
            {
                selected_script.auto_start = script_auto_start_checkbox.Checked;
                updateDisplay();
            }
        }
    }
}
