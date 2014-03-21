using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CmdInTray
{
    public partial class Manager : Form
    {

        private List<Script> scripts = new List<Script>();

        private Script selected_script;

        public Manager()
        {
            InitializeComponent();

            Script script1 = new Script();
            script1.name = "Server";
            script1.command = "rails s";
            scripts.Add(script1);

            Script script2 = new Script();
            script2.name = "Solr";
            script2.command = "rake sunspot:start";
            scripts.Add(script2);
            updateDisplay();
            updateButtonStatus();

        }

        public void updateDisplay()
        {
            script_list.Items.Clear();
            foreach (Script script in scripts)
            {
                ListViewItem item = new ListViewItem(script.id.ToString());
                item.SubItems.Add(script.name);
                item.SubItems.Add(script.command);
                item.SubItems.Add(script.isRunning().ToString());
                script_list.Items.AddRange(new ListViewItem[] { item });
            }
        }


        //Save the input
        private void save_input_button_Click(object sender, EventArgs e)
        {
            selected_script.name = script_name_input.Text;
            selected_script.command = script_command_input.Text;
            updateDisplay();
        }

        private void script_list_ItemSelectionChanged(Object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selected_script = find_script_by_id(int.Parse(e.Item.Text));

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
                script_name_input.ReadOnly = true;
                script_command_input.ReadOnly = true;
            }
            else
            {
                save_input_button.Enabled = true;
                start_button.Enabled = !selected_script.isRunning();
                stop_button.Enabled = selected_script.isRunning();
                restart_button.Enabled = selected_script.isRunning();
                script_name_input.Text = selected_script.name;
                script_command_input.Text = selected_script.command;
                script_name_input.ReadOnly = false;
                script_command_input.ReadOnly = false;
            }
        }
        private Script find_script_by_id(int id)
        {
            foreach (Script script in scripts)
            {
                if (script.id == id)
                {
                    return script;
                }
            }
            return null;
        }

    }
}
