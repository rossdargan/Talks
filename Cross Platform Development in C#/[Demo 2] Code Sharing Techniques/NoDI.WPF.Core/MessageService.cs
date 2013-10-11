﻿using System.Windows.Forms;

namespace WPF.Core
{
    public class MessageService
    {
        public void ShowMessage(string title, string body)
        {
            title = title.ToUpper();
            int maxSize = 50;
            string ending = "...";
            if (body.Length > maxSize)
            {
                body = string.Format("{0}{1}",body.Substring(0, maxSize - ending.Length), ending);
            }
            //perhaps log the message
            MessageBox.Show(body, title);
        }
    }
}
