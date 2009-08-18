using System;
using System.Web;
using System.Windows.Forms;

namespace ShortenURL
{
    internal class Controller
    {
        public enum WindowStateChangeAction
        {
            FormResize,
            NotifyIconDoubleClick
        }

        private Form1 _form;
        private IShortenService _selectedService;

        private ToolStripItemCollection GetServicesMenuItems()
        {
            ToolStripItemCollection Output = null;

            for (int i = 0; i < _form.ContextMenuStrip.Items.Count; i++)
            {
                ToolStripMenuItem currentItem = (ToolStripMenuItem)_form.ContextMenuStrip.Items[i];

                if (String.Equals(currentItem.Text, "Services", StringComparison.OrdinalIgnoreCase))
                {
                    Output = currentItem.DropDownItems;
                    break;
                }
            }

            return Output;
        }

        private void SetServiceMenuItemCheck(ToolStripItem item)
        {
            ToolStripItemCollection servicesList = GetServicesMenuItems();

            if (servicesList != null && servicesList.Count > 0)
                foreach (ToolStripMenuItem i in servicesList)
                {
                    i.Checked = (i == item);
                }
        }

        private void FormResizeAction()
        {
            if (FormWindowState.Minimized == _form.WindowState)
            {
                _form.Hide();
            }
        }

        private void NotifyIconDoubleClickAction()
        {
            if (_form.WindowState == FormWindowState.Normal)
            {
                _form.Hide();
                _form.WindowState = FormWindowState.Minimized;
            }
            else if (_form.WindowState == FormWindowState.Minimized)
            {
                _form.Show();
                _form.WindowState = FormWindowState.Normal;
            }
        }

        public Controller(Form1 form)
        {
            _form = form;
            _selectedService = new isgd(); //Set the default service
        }

        public void WindowStateChanged(WindowStateChangeAction action)
        {
            switch (action)
            {
                case WindowStateChangeAction.NotifyIconDoubleClick:
                    NotifyIconDoubleClickAction();
                    break;
                case WindowStateChangeAction.FormResize:
                    FormResizeAction();
                    break;
                default:
                    break;
            }
        }

        public void PerferredServiceChanged(ToolStripItem selectedServiceItem)
        {
            SetServiceMenuItemCheck(selectedServiceItem);
            _selectedService = ShortenServiceFactory.GetShortenService(selectedServiceItem.Text);
        }

        public void ShortenButtonClicked()
        {
            string shortURL = String.Empty;
            string urlText = HttpUtility.UrlEncode(_form.Controls["textURL"].Text);

            try
            {
                shortURL = _selectedService.ShortenURL(urlText);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _form.Controls["textURL"].Text = shortURL;
            Clipboard.SetText(shortURL);
        }
    }
}
