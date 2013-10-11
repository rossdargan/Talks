namespace AC.Core
{
    public abstract class MessageServiceBase
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
            SendMessage(title,body);
        }

        public abstract void SendMessage(string title, string body);
    }
}
