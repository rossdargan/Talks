using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DI.Core
{
    public class MessageService : IMessageService
    {
        private readonly IMessageBoxService _messageBoxService;

        public MessageService(IMessageBoxService messageBoxService)
        {
            _messageBoxService = messageBoxService;
        }

        public void ShowMessage(string title, string body)
        {
            title = title.ToUpper();
            int maxSize = 50;
            string ending = "...";
            if (body.Length > maxSize)
            {
                body = string.Format("{0}{1}", body.Substring(0, maxSize - ending.Length), ending);
            }
            //perhaps log the message
            _messageBoxService.Show(title,body);
        }
    }
}
