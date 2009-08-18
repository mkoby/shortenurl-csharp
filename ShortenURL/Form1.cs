using System;
using System.Windows.Forms;

namespace ShortenURL
{
    public partial class Form1 : Form
    {
        private readonly Controller _controller;

        public Form1()
        {
            InitializeComponent();
            _controller = new Controller(this);
        }

        private void buttonShorten_Click(object sender, EventArgs e)
        {
            _controller.ShortenButtonClicked();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            _controller.WindowStateChanged(Controller.WindowStateChangeAction.FormResize);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _controller.WindowStateChanged(Controller.WindowStateChangeAction.NotifyIconDoubleClick);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemServiceList_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            _controller.PerferredServiceChanged(e.ClickedItem);
        }
    }
}
