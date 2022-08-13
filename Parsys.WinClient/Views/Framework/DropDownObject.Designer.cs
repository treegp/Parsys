namespace Parsys.WinClient.Views.Framework
{
    partial class DropDownObject
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
            this.DropDownButton = new System.Windows.Forms.Button();
            this.ValueMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // DropDownButton
            // 
            this.DropDownButton.Location = new System.Drawing.Point(1, 1);
            this.DropDownButton.Name = "DropDownButton";
            this.DropDownButton.Size = new System.Drawing.Size(20, 20);
            this.DropDownButton.TabIndex = 0;
            this.DropDownButton.Text = "▼";
            this.DropDownButton.UseVisualStyleBackColor = true;
            this.DropDownButton.Click += new System.EventHandler(this.DropDownButton_Click);
            // 
            // ValueMaskedTextBox
            // 
            this.ValueMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueMaskedTextBox.Location = new System.Drawing.Point(21, 1);
            this.ValueMaskedTextBox.Name = "ValueMaskedTextBox";
            this.ValueMaskedTextBox.Size = new System.Drawing.Size(99, 20);
            this.ValueMaskedTextBox.TabIndex = 1;
            // 
            // DropDownObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValueMaskedTextBox);
            this.Controls.Add(this.DropDownButton);
            this.MaximumSize = new System.Drawing.Size(3000, 22);
            this.MinimumSize = new System.Drawing.Size(123, 22);
            this.Name = "DropDownObject";
            this.Size = new System.Drawing.Size(123, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DropDownButton;
        private System.Windows.Forms.MaskedTextBox ValueMaskedTextBox;
    }
}
