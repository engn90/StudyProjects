using System;
using System.Collections.Generic;
using System.Text;

namespace RoverNavigate.Common
{
    public class SelectItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public SelectItem(string text,int value)
        {
            Text = text;
            Value = value;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
