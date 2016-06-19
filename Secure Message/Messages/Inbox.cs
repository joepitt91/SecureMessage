using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure_Message
{
    public partial class Inbox : Form
    {
        private List<Message> InboxMessages;

        public Inbox()
        {
            InitializeComponent();
        }

        private void Inbox_Load(object sender, EventArgs e)
        {
            Text = "Inbox - " + Program.CurrentAcount.DisplayName + " - Secure Message";
            lblDisplayName.Text = Program.CurrentAcount.DisplayName;
            imgDisplayImage.Image = Program.CurrentAcount.DisplayImage;
            InboxMessages = Database.GetInbox();
            foreach (Message msg in InboxMessages)
            {
                ListViewItem inboxItem = new ListViewItem();
                inboxItem.Name = msg.MessageID;
                inboxItem.Text = Convert.ToString(msg.AttachmentCound);
                ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem();
                from.Text = msg.FromDisplayName;
                inboxItem.SubItems.Add(from);
                ListViewItem.ListViewSubItem subject = new ListViewItem.ListViewSubItem();
                subject.Text = msg.Subject;
                inboxItem.SubItems.Add(subject);
                ListViewItem.ListViewSubItem sent = new ListViewItem.ListViewSubItem();
                sent.Text = msg.Sent.ToString();
                inboxItem.SubItems.Add(sent);
                ListViewItem.ListViewSubItem expires = new ListViewItem.ListViewSubItem();
                expires.Text = msg.Expires.ToString();
                inboxItem.SubItems.Add(expires);
            }

            // populate table
        }

        private void btnCryptoTest_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Compose NewMessage = new Compose();
            NewMessage.ShowDialog();
            Inbox_Load(this, new EventArgs());
        }
    }
}