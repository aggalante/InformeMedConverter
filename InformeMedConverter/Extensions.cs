#region Copyright © 2014, Critical Health
// ===============================================================================
//   Copyright © 2014, Critical Health. All rights reserved                     //
//   http://www.critical-health.com/                                            //
// ===============================================================================
#endregion

using System.Collections.Generic;
using System.Windows.Forms;

using InformeMedConverter.Controls;

namespace InformeMedConverter
{
    public static class Extensions
    {
        public static bool IsNullOrWhiteSpace(string str)
        {
            if (str == null)
                return true;

            if (str.Equals(string.Empty))
                return true;

            return false;
        }

        public static List<Label> OfTypeLabel(Control.ControlCollection controls)
        {
            List<Label> results = new List<Label>();

            foreach (Control control in controls)
            {
                if(control is Label)
                    results.Add(control as Label);
            }

            return results;
        }

        public static List<ParameterControl> OfTypeParameterControl(Control.ControlCollection controls)
        {
            List<ParameterControl> results = new List<ParameterControl>();

            foreach (Control control in controls)
            {
                if (control is ParameterControl)
                    results.Add(control as ParameterControl);
            }

            return results;
        }

        public static List<AddParameterControl> OfTypeAddParameterControl(Control.ControlCollection controls)
        {
            List<AddParameterControl> results = new List<AddParameterControl>();

            foreach (Control control in controls)
            {
                if (control is AddParameterControl)
                    results.Add(control as AddParameterControl);
            }

            return results;
        }
    }
}
