using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI.Popups;
using AC.Core;

namespace AC.Store
{
    class MessageService : MessageServiceBase
    {
        public override void SendMessage(string title, string body)
        {
            MessageDialog dialog = new MessageDialog(body, title);
            dialog.ShowAsync();
        }
    }
}
