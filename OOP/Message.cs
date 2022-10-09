using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Message
    {
        private string _text;
        public string Text { 
            get { return _text; } 
            private set { _text = value; } 
        }

        public Message(string text)
        {
            // Вариант 1
            //if (text == null)
            //    throw new ArgumentNullException("message");
            //else
            //    Text = text;

            // Вариант 2
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }
    }
}
