namespace InformeMedConverter
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.copyPanel = new System.Windows.Forms.Panel();
            this.deletePicture = new System.Windows.Forms.PictureBox();
            this.buttonSeparator1 = new System.Windows.Forms.Panel();
            this.copyPicture = new System.Windows.Forms.PictureBox();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.parametersPanel = new System.Windows.Forms.Panel();
            this.inputActionsPanel = new System.Windows.Forms.Panel();
            this.cleanPicture = new System.Windows.Forms.PictureBox();
            this.buttonSeparator2 = new System.Windows.Forms.Panel();
            this.addPicture = new System.Windows.Forms.PictureBox();
            this.inputHeaderPanel = new System.Windows.Forms.Panel();
            this.unitHeaderLabel = new System.Windows.Forms.Label();
            this.resultsHeaderLabel = new System.Windows.Forms.Label();
            this.parameterHeaderLabel = new System.Windows.Forms.Label();
            this.convertPanel = new System.Windows.Forms.Panel();
            this.convertPicture = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.developedByLabel = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.resultsPanel.SuspendLayout();
            this.copyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyPicture)).BeginInit();
            this.inputPanel.SuspendLayout();
            this.inputActionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cleanPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).BeginInit();
            this.inputHeaderPanel.SuspendLayout();
            this.convertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.convertPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.languageLabel);
            this.titlePanel.Controls.Add(this.languageComboBox);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Controls.Add(this.logoPicture);
            resources.ApplyResources(this.titlePanel, "titlePanel");
            this.titlePanel.Name = "titlePanel";
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.Name = "languageLabel";
            // 
            // languageComboBox
            // 
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Name = "languageComboBox";
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // logoPicture
            // 
            resources.ApplyResources(this.logoPicture, "logoPicture");
            this.logoPicture.Image = global::InformeMedConverter.Properties.Resources.logo;
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.resultsPanel);
            this.mainPanel.Controls.Add(this.copyPanel);
            this.mainPanel.Controls.Add(this.inputPanel);
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // resultsPanel
            // 
            this.resultsPanel.Controls.Add(this.resultTextBox);
            this.resultsPanel.Controls.Add(this.developedByLabel);
            resources.ApplyResources(this.resultsPanel, "resultsPanel");
            this.resultsPanel.Name = "resultsPanel";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.White;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.resultTextBox, "resultTextBox");
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            // 
            // copyPanel
            // 
            this.copyPanel.Controls.Add(this.deletePicture);
            this.copyPanel.Controls.Add(this.buttonSeparator1);
            this.copyPanel.Controls.Add(this.copyPicture);
            this.copyPanel.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.copyPanel, "copyPanel");
            this.copyPanel.Name = "copyPanel";
            // 
            // deletePicture
            // 
            this.deletePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.deletePicture, "deletePicture");
            this.deletePicture.Image = global::InformeMedConverter.Properties.Resources.Delete;
            this.deletePicture.Name = "deletePicture";
            this.deletePicture.TabStop = false;
            this.toolTip.SetToolTip(this.deletePicture, resources.GetString("deletePicture.ToolTip"));
            // 
            // buttonSeparator1
            // 
            resources.ApplyResources(this.buttonSeparator1, "buttonSeparator1");
            this.buttonSeparator1.Name = "buttonSeparator1";
            // 
            // copyPicture
            // 
            this.copyPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.copyPicture, "copyPicture");
            this.copyPicture.Image = global::InformeMedConverter.Properties.Resources.Copy;
            this.copyPicture.Name = "copyPicture";
            this.copyPicture.TabStop = false;
            this.toolTip.SetToolTip(this.copyPicture, resources.GetString("copyPicture.ToolTip"));
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.parametersPanel);
            this.inputPanel.Controls.Add(this.inputActionsPanel);
            this.inputPanel.Controls.Add(this.inputHeaderPanel);
            this.inputPanel.Controls.Add(this.convertPanel);
            resources.ApplyResources(this.inputPanel, "inputPanel");
            this.inputPanel.Name = "inputPanel";
            // 
            // parametersPanel
            // 
            resources.ApplyResources(this.parametersPanel, "parametersPanel");
            this.parametersPanel.Name = "parametersPanel";
            // 
            // inputActionsPanel
            // 
            this.inputActionsPanel.Controls.Add(this.cleanPicture);
            this.inputActionsPanel.Controls.Add(this.buttonSeparator2);
            this.inputActionsPanel.Controls.Add(this.addPicture);
            this.inputActionsPanel.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.inputActionsPanel, "inputActionsPanel");
            this.inputActionsPanel.Name = "inputActionsPanel";
            // 
            // cleanPicture
            // 
            this.cleanPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.cleanPicture, "cleanPicture");
            this.cleanPicture.Image = global::InformeMedConverter.Properties.Resources.Clear;
            this.cleanPicture.Name = "cleanPicture";
            this.cleanPicture.TabStop = false;
            this.toolTip.SetToolTip(this.cleanPicture, resources.GetString("cleanPicture.ToolTip"));
            // 
            // buttonSeparator2
            // 
            resources.ApplyResources(this.buttonSeparator2, "buttonSeparator2");
            this.buttonSeparator2.Name = "buttonSeparator2";
            // 
            // addPicture
            // 
            this.addPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.addPicture, "addPicture");
            this.addPicture.Image = global::InformeMedConverter.Properties.Resources.Add;
            this.addPicture.Name = "addPicture";
            this.addPicture.TabStop = false;
            this.toolTip.SetToolTip(this.addPicture, resources.GetString("addPicture.ToolTip"));
            // 
            // inputHeaderPanel
            // 
            this.inputHeaderPanel.Controls.Add(this.unitHeaderLabel);
            this.inputHeaderPanel.Controls.Add(this.resultsHeaderLabel);
            this.inputHeaderPanel.Controls.Add(this.parameterHeaderLabel);
            resources.ApplyResources(this.inputHeaderPanel, "inputHeaderPanel");
            this.inputHeaderPanel.Name = "inputHeaderPanel";
            // 
            // unitHeaderLabel
            // 
            resources.ApplyResources(this.unitHeaderLabel, "unitHeaderLabel");
            this.unitHeaderLabel.Name = "unitHeaderLabel";
            // 
            // resultsHeaderLabel
            // 
            resources.ApplyResources(this.resultsHeaderLabel, "resultsHeaderLabel");
            this.resultsHeaderLabel.Name = "resultsHeaderLabel";
            // 
            // parameterHeaderLabel
            // 
            resources.ApplyResources(this.parameterHeaderLabel, "parameterHeaderLabel");
            this.parameterHeaderLabel.Name = "parameterHeaderLabel";
            // 
            // convertPanel
            // 
            this.convertPanel.Controls.Add(this.convertPicture);
            this.convertPanel.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.convertPanel, "convertPanel");
            this.convertPanel.Name = "convertPanel";
            // 
            // convertPicture
            // 
            this.convertPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.convertPicture, "convertPicture");
            this.convertPicture.Image = global::InformeMedConverter.Properties.Resources.Arrow;
            this.convertPicture.Name = "convertPicture";
            this.convertPicture.TabStop = false;
            this.toolTip.SetToolTip(this.convertPicture, resources.GetString("convertPicture.ToolTip"));
            // 
            // developedByLabel
            // 
            resources.ApplyResources(this.developedByLabel, "developedByLabel");
            this.developedByLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.developedByLabel.Name = "developedByLabel";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.titlePanel);
            this.Name = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.resultsPanel.ResumeLayout(false);
            this.copyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deletePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyPicture)).EndInit();
            this.inputPanel.ResumeLayout(false);
            this.inputActionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cleanPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).EndInit();
            this.inputHeaderPanel.ResumeLayout(false);
            this.inputHeaderPanel.PerformLayout();
            this.convertPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.convertPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel resultsPanel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel inputHeaderPanel;
        private System.Windows.Forms.Panel parametersPanel;
        private System.Windows.Forms.Label unitHeaderLabel;
        private System.Windows.Forms.Label resultsHeaderLabel;
        private System.Windows.Forms.Label parameterHeaderLabel;
        private System.Windows.Forms.Panel convertPanel;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.PictureBox convertPicture;
        private System.Windows.Forms.Panel copyPanel;
        private System.Windows.Forms.PictureBox copyPicture;
        private System.Windows.Forms.PictureBox deletePicture;
        private System.Windows.Forms.Panel buttonSeparator1;
        private System.Windows.Forms.Panel inputActionsPanel;
        private System.Windows.Forms.PictureBox addPicture;
        private System.Windows.Forms.Panel buttonSeparator2;
        private System.Windows.Forms.PictureBox cleanPicture;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label developedByLabel;
    }
}

