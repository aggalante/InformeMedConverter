namespace InformeMedConverter.Controls
{
    partial class ParameterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.parameterLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // parameterLabel
            // 
            this.parameterLabel.AutoSize = true;
            this.parameterLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.parameterLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameterLabel.Location = new System.Drawing.Point(5, 3);
            this.parameterLabel.MaximumSize = new System.Drawing.Size(250, 20);
            this.parameterLabel.MinimumSize = new System.Drawing.Size(250, 20);
            this.parameterLabel.Name = "parameterLabel";
            this.parameterLabel.Size = new System.Drawing.Size(250, 20);
            this.parameterLabel.TabIndex = 0;
            this.parameterLabel.Text = "<parameter>";
            this.parameterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.resultTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(255, 3);
            this.resultTextBox.MaximumSize = new System.Drawing.Size(80, 20);
            this.resultTextBox.MaxLength = 50;
            this.resultTextBox.MinimumSize = new System.Drawing.Size(80, 20);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(80, 20);
            this.resultTextBox.TabIndex = 1;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.unitLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.Location = new System.Drawing.Point(335, 3);
            this.unitLabel.MaximumSize = new System.Drawing.Size(205, 20);
            this.unitLabel.MinimumSize = new System.Drawing.Size(205, 20);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.unitLabel.Size = new System.Drawing.Size(205, 20);
            this.unitLabel.TabIndex = 2;
            this.unitLabel.Text = "<unit>";
            this.unitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ParameterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.parameterLabel);
            this.Name = "ParameterControl";
            this.Padding = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.Size = new System.Drawing.Size(500, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label parameterLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label unitLabel;
    }
}
