using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using DI.Core;

namespace DI.Store
{
    class MessageBoxService : IMessageBoxService
    {
        public void Show(string title, string body)
        {
            MessageDialog messageDialog = new MessageDialog(body,title);
            messageDialog.ShowAsync();
        }
    }
}
