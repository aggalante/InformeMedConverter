namespace InformeMedConverter.Controls
{
    partial class AddParameterControl
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
            this.paramenterTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.separator1 = new System.Windows.Forms.Panel();
            this.separator2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // paramenterTextBox
            // 
            this.paramenterTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.paramenterTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paramenterTextBox.Location = new System.Drawing.Point(5, 3);
            this.paramenterTextBox.MaximumSize = new System.Drawing.Size(240, 20);
            this.paramenterTextBox.MaxLength = 250;
            this.paramenterTextBox.MinimumSize = new System.Drawing.Size(240, 20);
            this.paramenterTextBox.Name = "paramenterTextBox";
            this.paramenterTextBox.Size = new System.Drawing.Size(240, 22);
            this.paramenterTextBox.TabIndex = 2;
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
            this.resultTextBox.TabIndex = 3;
            // 
            // unitTextBox
            // 
            this.unitTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.unitTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitTextBox.Location = new System.Drawing.Point(355, 3);
            this.unitTextBox.MaximumSize = new System.Drawing.Size(85, 20);
            this.unitTextBox.MaxLength = 100;
            this.unitTextBox.MinimumSize = new System.Drawing.Size(85, 20);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(85, 20);
            this.unitTextBox.TabIndex = 4;
            // 
            // separator1
            // 
            this.separator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.separator1.Location = new System.Drawing.Point(245, 3);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(10, 20);
            this.separator1.TabIndex = 6;
            // 
            // separator2
            // 
            this.separator2.Dock = System.Windows.Forms.DockStyle.Left;
            this.separator2.Location = new System.Drawing.Point(335, 3);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(20, 20);
            this.separator2.TabIndex = 7;
            // 
            // AddParameterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.separator2);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.paramenterTextBox);
            this.Name = "AddParameterControl";
            this.Padding = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.Size = new System.Drawing.Size(500, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paramenterTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.Panel separator1;
        private System.Windows.Forms.Panel separator2;
    }
}
