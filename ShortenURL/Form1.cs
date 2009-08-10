using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShortenURL
{
    public partial class Form1 : Form
    {
        #region Non-Form Methods

        private IShortenService GetShortenService()
        {
            IShortenService Output = null;

            if (itemTinyURL.Checked)
                Output = new TinyURL();
            else if (itemIsgd.Checked)
            {
                Output = new IsGd();
            }
            else if (itemSupr.Checked)
            {
                Output = new Supr();
            }
            else if (itembitly.Checked)
            {
                Output = new bitly();
            }

            return Output;
        }

        private ToolStripItemCollection GetServicesMenuItems()
        {
            ToolStripItemCollection Output = null;

            for (int i = 0; i < contextMenuMain.Items.Count; i++)
            {
                ToolStripMenuItem currentItem = (ToolStripMenuItem)contextMenuMain.Items[i];

                if (String.Equals(currentItem.Text, "Services", StringComparison.OrdinalIgnoreCase))
                {
                    Output = currentItem.DropDownItems;
                    break;
                }
            }

            return Output;
        }

        private void setServiceMenuItemCheck(ToolStripMenuItem item)
        {
            ToolStripItemCollection servicesList = GetServicesMenuItems();

            if (servicesList != null && servicesList.Count > 0)
                foreach (ToolStripMenuItem i in servicesList)
                {
                    i.Checked = i == item;
                }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShorten_Click(object sender, EventArgs e)
        {
            IShortenService shortenService = GetShortenService();
            string shortURL = String.Empty;

            try
            {
                shortURL = shortenService.ShortenURL(textURL.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textURL.Text = shortURL;
            Clipboard.SetText(shortURL);
        }

        private void itemTinyURL_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem) sender;
            setServiceMenuItemCheck(item);
        }

        private void itemIsgd_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            setServiceMenuItemCheck(item);
        }

        private void itemSupr_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            setServiceMenuItemCheck(item);
        }

        private void itembitly_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            setServiceMenuItemCheck(item);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Hide();
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
