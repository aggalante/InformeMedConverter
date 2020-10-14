#region Copyright © 2014, Critical Health
// ===============================================================================
//   Copyright © 2014, Critical Health. All rights reserved                     //
//   http://www.critical-health.com/                                            //
// ===============================================================================
#endregion

namespace InformeMedConverter.Model
{
    public class ComboboxItem
    {
        public ComboboxItem(string value, string text)
        {
            Value = value;
            Text = text;
        }

        public string Value { get; set; }

        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
