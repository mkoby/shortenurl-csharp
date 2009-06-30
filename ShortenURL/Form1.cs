using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShortenURL
{
    public partial class Form1 : Form
    {
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

        private IShortenService GetShortenService()
        {
            IShortenService Output = null;

            if (itemTinyURL.Checked)
                Output = new TinyURL();
            else if (itemIsgd.Checked)
            {
                Output = new IsGd();
            }

            return Output;
        }

        private void itemTinyURL_Click(object sender, EventArgs e)
        {
                itemIsgd.Checked = false;
                itemTinyURL.Checked = true;
        }

        private void itemIsgd_Click(object sender, EventArgs e)
        {
            itemTinyURL.Checked = false;
            itemIsgd.Checked = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                Hide();
                WindowState = FormWindowState.Minimized;
            }
            else if(WindowState == FormWindowState.Minimized)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }

        }
    }
}
