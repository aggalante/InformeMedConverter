#region Copyright © 2014, Critical Health

// ===============================================================================
//   Copyright © 2014, Critical Health. All rights reserved                     //
//   http://www.critical-health.com/                                            //
// ===============================================================================

#endregion

using System;
using System.Windows.Forms;

using InformeMedConverter.Model;

namespace InformeMedConverter.Controls
{
    public partial class ParameterControl : UserControl
    {
        public ParameterData Data { get; private set; }

        public ParameterControl(ParameterData data)
        {
            InitializeComponent();

            ResetData();
            SetData(data);
        }

        public string GetTextInformation()
        {
            if (string.IsNullOrEmpty(parameterLabel.Text))
                return string.Empty;

            string parameter = parameterLabel.Text;

            if (string.IsNullOrEmpty(resultTextBox.Text))
                return string.Empty;

            string result = resultTextBox.Text;
            string unit = unitLabel.Text;

            return $"{parameter} {result} {unit}";
        }

        private void ResetData()
        {
            Data = null;

            parameterLabel.Text = string.Empty;
            resultTextBox.Text = null;
            unitLabel.Text = string.Empty;
        }

        private void SetData(ParameterData data)
        {
            if (data == null)
                return;

            Data = data;

            parameterLabel.Text = data.Parameter;
            unitLabel.Text = data.Unit;
        }

        public void ClearInput()
        {
            resultTextBox.Text = null;
        }
    }
}
