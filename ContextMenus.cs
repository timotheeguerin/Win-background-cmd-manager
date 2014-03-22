
using System;
using System.Diagnostics;
using System.Windows.Forms;
using CmdInTray.Properties;
using System.Drawing;

namespace CmdInTray
{
    /// <summary>
    /// 
    /// </summary>
    class ContextMenus
    {
        /// <summary>
        /// Is the About box displayed?
        /// </summary>
        bool isAboutLoaded = false;

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>ContextMenuStrip</returns>
        public ContextMenuStrip Create()
        {
            // Add the default menu options.
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator sep;

            // Windows Explorer.
            item = new ToolStripMenuItem();
            item.Text = "Manage";
            item.Click += new EventHandler(Manage_Click);
            item.Image = Resources.Explorer;
           // menu.Items.Add(item);

            // Separator.
            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            // Exit.
            item = new ToolStripMenuItem();
            item.Text = "Exit";
            item.Click += new System.EventHandler(Exit_Click);
            item.Image = Resources.Exit;
            menu.Items.Add(item);

            return menu;
        }


        /// <summary>
        /// Handles the Click event of the About control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Manage_Click(object sender, EventArgs e)
        {
            if (!isAboutLoaded)
            {
                isAboutLoaded = true;
                new Manager().ShowDialog();
                isAboutLoaded = false;
            }
        }

        /// <summary>
        /// Processes a menu item.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Exit_Click(object sender, EventArgs e)
        {
            // Quit without further ado.
            Application.Exit();
        }
    }
}