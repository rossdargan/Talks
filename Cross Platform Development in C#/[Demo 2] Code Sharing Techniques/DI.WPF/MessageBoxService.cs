using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DI.Core;

namespace DI.WPF
{
    class MessageBoxService : IMessageBoxService
    {
        public void Show(string title, string body)
        {
            MessageBox.Show(body, title);
        }
    }
}
