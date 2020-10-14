using System.Windows.Forms;

namespace InformeMedConverter.Controls
{
    public partial class AddParameterControl : UserControl
    {
        public AddParameterControl()
        {
            InitializeComponent();
        }

        public string GetTextInformation()
        {
            if (string.IsNullOrEmpty(paramenterTextBox.Text))
                return string.Empty;

            string parameter = paramenterTextBox.Text;

            if (string.IsNullOrEmpty(resultTextBox.Text))
                return string.Empty;

            string result = resultTextBox.Text;
            string unit = unitTextBox.Text;

            return $"{parameter} {result} {unit}";
        }

        public void ClearInput()
        {
            paramenterTextBox.Text = null;
            resultTextBox.Text = null;
            unitTextBox.Text = null;
        }
    }
}
