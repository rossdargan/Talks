using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using AC.Core;

namespace AC.WPF
{
    class MessageService : MessageServiceBase
    {
        public override void SendMessage(string title, string body)
        {
            MessageBox.Show(body, title);
        }
    }
}
