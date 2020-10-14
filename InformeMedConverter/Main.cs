#region Copyright © 2014, Critical Health

// ===============================================================================
//   Copyright © 2014, Critical Health. All rights reserved                     //
//   http://www.critical-health.com/                                            //
// ===============================================================================

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

using InformeMedConverter.Controls;
using InformeMedConverter.Model;
using InformeMedConverter.Properties;

namespace InformeMedConverter
{
    public partial class Main : Form
    {
        private string _cultureInfo;

        public Main()
        {
            InitializeComponent();
            InitializeControls();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            addPicture.Click += (sender, args) => AddParameter();
            cleanPicture.Click += (sender, args) => ClearInputs();
            convertPicture.Click += (sender, args) => ConvertParametersToText();
            copyPicture.Click += (sender, args) => CopyText();
            deletePicture.Click += (sender, args) => DeleteText();
            languageComboBox.SelectedIndexChanged += (sender, args) =>
            {
                LanguageChanged();
                LoadDefaultParameters();
            };
        }

        private void InitializeControls()
        {
            languageComboBox.Items.AddRange(DefaultParametersFactory.GetAvailableLanguages());
            languageComboBox.SelectedIndex = 0;
            LanguageChanged();
            LoadDefaultParameters();
        }

        private void InitializeToolTip()
        {
            toolTip.SetToolTip(addPicture, Resources.ToolTip_AddParameter);
            toolTip.SetToolTip(cleanPicture, Resources.ToolTip_CleanInputs);
            toolTip.SetToolTip(convertPicture, Resources.ToolTip_ConvertText);
            toolTip.SetToolTip(copyPicture, Resources.ToolTip_CopyToClipboard);
            toolTip.SetToolTip(deletePicture, Resources.ToolTip_DeleteText);
        }

        private void LoadDefaultParameters()
        {
            SuspendLayout();

            try
            {
                foreach (Control control in parametersPanel.Controls)
                    control.Dispose();
                parametersPanel.Controls.Clear();

                List<ParameterData> defaultParameters = DefaultParametersFactory.GetDefaultParameters(_cultureInfo);

                foreach (ParameterType type in Enum.GetValues(typeof(ParameterType)))
                    LoadParameters(type, defaultParameters.FindAll(s => s.Type == type));
            }
            finally
            {
                ResumeLayout();
            }
        }

        private void LoadParameters(ParameterType parameterType, List<ParameterData> parametersList)
        {
            if (parametersList == null || parametersList.Count == 0)
                return;

            Label title = new Label
            {
                Dock = DockStyle.Top,
                Text = GetParameterTypeDescription(parameterType),
                Font = parameterHeaderLabel.Font,
                Height = 25,
                TextAlign = ContentAlignment.BottomLeft
            };
            parametersPanel.Controls.Add(title);
            title.BringToFront();

            foreach (ParameterData parameterData in parametersList)
            {
                ParameterControl control = new ParameterControl(parameterData)
                {
                    Dock = DockStyle.Top
                };
                parametersPanel.Controls.Add(control);
                control.BringToFront();
            }
        }

        private static string GetParameterTypeDescription(ParameterType parameterType)
        {
            switch (parameterType)
            {
                case ParameterType.Bioquimica:
                    return Resources.ParameterTypeDescription_BIOQUIMICA;
                case ParameterType.MarcadoresTumorales:
                    return Resources.ParameterTypeDescription_MARCADORESTEMPORALES;
                case ParameterType.Hematologia:
                    return Resources.ParameterTypeDescription_HEMATOLOGIA;
                case ParameterType.SedimentoOrina:
                    return Resources.ParameterTypeDescription_SEDIMENTOORINA;
                case ParameterType.TiraReactivaOrina:
                    return Resources.ParameterTypeDescription_TIRAREACTIVAORINA;
                case ParameterType.Urgencias:
                    return Resources.ParameterTypeDescription_URGENCIAS;
                case ParameterType.Otros:
                    return Resources.ParameterTypeDescription_OTROS;
                default:
                    return string.Empty;
            }
        }

        private void AddParameter()
        {
            string othersTitleDescription = GetParameterTypeDescription(ParameterType.Otros);

            List<Label> labels = Extensions.OfTypeLabel(parametersPanel.Controls);
            labels.Reverse();
            Label title = labels.FindLast(s => s.Text == othersTitleDescription);
            
            if (title == null)
            {
                title = new Label
                {
                    Dock = DockStyle.Top,
                    Text = othersTitleDescription,
                    Font = parameterHeaderLabel.Font,
                    Height = 25,
                    TextAlign = ContentAlignment.BottomLeft
                };
                parametersPanel.Controls.Add(title);
                title.BringToFront();
            }

            AddParameterControl control = new AddParameterControl()
            {
                Dock = DockStyle.Top
            };
            parametersPanel.Controls.Add(control);
            control.BringToFront();

            parametersPanel.ScrollControlIntoView(control);
        }

        private void ClearInputs()
        {
            foreach (ParameterControl control in Extensions.OfTypeParameterControl(parametersPanel.Controls))
                control.ClearInput();

            foreach (AddParameterControl control in Extensions.OfTypeAddParameterControl(parametersPanel.Controls))
                control.ClearInput();
        }

        private void ConvertParametersToText()
        {
            string result = string.Empty;

            foreach (ParameterType type in Enum.GetValues(typeof(ParameterType)))
            {
                if (type == ParameterType.Otros)
                {
                    List<AddParameterControl> parameterControls = Extensions.OfTypeAddParameterControl(parametersPanel.Controls);
                    parameterControls.Reverse();

                    if (parameterControls.Count > 0)
                    {
                        result += GetParameterTypeDescription(type) + Environment.NewLine;
                        foreach (AddParameterControl control in parameterControls)
                        {
                            string text = control.GetTextInformation();
                            result += !Extensions.IsNullOrWhiteSpace(text) ? text + ";" : string.Empty;
                        }

                        result += Environment.NewLine;
                    }
                }
                else
                {
                    List<ParameterControl> parameterControls = Extensions.OfTypeParameterControl(parametersPanel.Controls).FindAll(s => s.Data.Type == type);
                    parameterControls.Reverse();

                    if (parameterControls.Count > 0)
                    {
                        string parametersResult = string.Empty;
                        foreach (ParameterControl control in parameterControls)
                        {
                            string text = control.GetTextInformation();
                            parametersResult += !Extensions.IsNullOrWhiteSpace(text) ? text + ";" : string.Empty;
                        }

                        if (!Extensions.IsNullOrWhiteSpace(parametersResult))
                        {
                            result += GetParameterTypeDescription(type) + Environment.NewLine;
                            result += parametersResult;
                            result += Environment.NewLine + Environment.NewLine;
                        }
                    }
                }
            }

            resultTextBox.Text = result;
        }

        private void CopyText()
        {
            Clipboard.SetText(resultTextBox.Text);
        }

        private void DeleteText()
        {
            resultTextBox.Text = string.Empty;
        }

        private void LanguageChanged()
        {
            ComboboxItem selectedItem = (ComboboxItem)languageComboBox.SelectedItem;

            if (languageComboBox.SelectedItem == null || selectedItem == null)
                _cultureInfo = DefaultParametersFactory.DefaultCulture;
            else
                _cultureInfo = selectedItem.Value;

            ChangeLanguage(_cultureInfo);
            InitializeToolTip();
        }

        private void ChangeLanguage(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang);

            ComponentResourceManager resources = new ComponentResourceManager(typeof(Main));
            resources.ApplyResources(toolTip, "toolTip", new CultureInfo(lang));
            foreach (Control control in Controls)
            {
                resources.ApplyResources(control, control.Name, new CultureInfo(lang));
                foreach (Control childControls in control.Controls)
                {
                    resources.ApplyResources(childControls, childControls.Name, new CultureInfo(lang));
                    foreach (Control childChildControls in childControls.Controls)
                    {
                        resources.ApplyResources(childChildControls, childChildControls.Name, new CultureInfo(lang));
                        foreach (Control childChildChildControls in childChildControls.Controls)
                        {
                            resources.ApplyResources(childChildChildControls, childChildChildControls.Name, new CultureInfo(lang));
                        }
                    }
                }
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
    }
}
