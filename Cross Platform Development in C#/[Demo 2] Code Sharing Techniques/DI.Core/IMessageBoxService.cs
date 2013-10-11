using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Core
{
    public interface IMessageBoxService
    {
        void Show(string title, string body);
    }
}
