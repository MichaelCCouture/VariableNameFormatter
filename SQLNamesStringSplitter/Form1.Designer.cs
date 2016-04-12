namespace SQLNamesStringSplitter
{
    partial class Form1
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
            this.chkCapitalize = new System.Windows.Forms.CheckBox();
            this.chkAtSign = new System.Windows.Forms.CheckBox();
            this.chkCommaSeparated = new System.Windows.Forms.CheckBox();
            this.chkUnderscores = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.chkUpdateFormat = new System.Windows.Forms.CheckBox();
            this.chkSprocGetFormat = new System.Windows.Forms.CheckBox();
            this.chkSprocUpdateFormat = new System.Windows.Forms.CheckBox();
            this.btnResetText = new System.Windows.Forms.Button();
            this.chkDivTagFormat = new System.Windows.Forms.CheckBox();
            this.chkSetTextboxFormat = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkCapitalize
            // 
            this.chkCapitalize.AutoSize = true;
            this.chkCapitalize.Location = new System.Drawing.Point(13, 13);
            this.chkCapitalize.Name = "chkCapitalize";
            this.chkCapitalize.Size = new System.Drawing.Size(116, 17);
            this.chkCapitalize.TabIndex = 0;
            this.chkCapitalize.TabStop = false;
            this.chkCapitalize.Text = "Capitalize first letter";
            this.chkCapitalize.UseVisualStyleBackColor = true;
            // 
            // chkAtSign
            // 
            this.chkAtSign.AutoSize = true;
            this.chkAtSign.Location = new System.Drawing.Point(13, 37);
            this.chkAtSign.Name = "chkAtSign";
            this.chkAtSign.Size = new System.Drawing.Size(95, 17);
            this.chkAtSign.TabIndex = 1;
            this.chkAtSign.TabStop = false;
            this.chkAtSign.Text = "@ sign at front";
            this.chkAtSign.UseVisualStyleBackColor = true;
            // 
            // chkCommaSeparated
            // 
            this.chkCommaSeparated.AutoSize = true;
            this.chkCommaSeparated.Location = new System.Drawing.Point(13, 61);
            this.chkCommaSeparated.Name = "chkCommaSeparated";
            this.chkCommaSeparated.Size = new System.Drawing.Size(111, 17);
            this.chkCommaSeparated.TabIndex = 2;
            this.chkCommaSeparated.TabStop = false;
            this.chkCommaSeparated.Text = "Comma separated";
            this.chkCommaSeparated.UseVisualStyleBackColor = true;
            // 
            // chkUnderscores
            // 
            this.chkUnderscores.AutoSize = true;
            this.chkUnderscores.Location = new System.Drawing.Point(13, 85);
            this.chkUnderscores.Name = "chkUnderscores";
            this.chkUnderscores.Size = new System.Drawing.Size(161, 17);
            this.chkUnderscores.TabIndex = 3;
            this.chkUnderscores.TabStop = false;
            this.chkUnderscores.Text = "Underscores between words";
            this.chkUnderscores.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(54, 242);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 32);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Text = "Format";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(180, 11);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(291, 324);
            this.txtInput.TabIndex = 6;
            this.txtInput.Text = "";
            // 
            // chkUpdateFormat
            // 
            this.chkUpdateFormat.AutoSize = true;
            this.chkUpdateFormat.Location = new System.Drawing.Point(13, 109);
            this.chkUpdateFormat.Name = "chkUpdateFormat";
            this.chkUpdateFormat.Size = new System.Drawing.Size(110, 17);
            this.chkUpdateFormat.TabIndex = 7;
            this.chkUpdateFormat.TabStop = false;
            this.chkUpdateFormat.Text = "Full update format";
            this.chkUpdateFormat.UseVisualStyleBackColor = true;
            // 
            // chkSprocGetFormat
            // 
            this.chkSprocGetFormat.AutoSize = true;
            this.chkSprocGetFormat.Location = new System.Drawing.Point(13, 133);
            this.chkSprocGetFormat.Name = "chkSprocGetFormat";
            this.chkSprocGetFormat.Size = new System.Drawing.Size(97, 17);
            this.chkSprocGetFormat.TabIndex = 8;
            this.chkSprocGetFormat.Text = "DAL get format";
            this.chkSprocGetFormat.UseVisualStyleBackColor = true;
            // 
            // chkSprocUpdateFormat
            // 
            this.chkSprocUpdateFormat.AutoSize = true;
            this.chkSprocUpdateFormat.Location = new System.Drawing.Point(13, 157);
            this.chkSprocUpdateFormat.Name = "chkSprocUpdateFormat";
            this.chkSprocUpdateFormat.Size = new System.Drawing.Size(115, 17);
            this.chkSprocUpdateFormat.TabIndex = 9;
            this.chkSprocUpdateFormat.Text = "DAL update format";
            this.chkSprocUpdateFormat.UseVisualStyleBackColor = true;
            // 
            // btnResetText
            // 
            this.btnResetText.Location = new System.Drawing.Point(54, 280);
            this.btnResetText.Name = "btnResetText";
            this.btnResetText.Size = new System.Drawing.Size(75, 32);
            this.btnResetText.TabIndex = 10;
            this.btnResetText.Text = "Reset Text";
            this.btnResetText.UseVisualStyleBackColor = true;
            this.btnResetText.Click += new System.EventHandler(this.btnResetText_Click);
            // 
            // chkDivTagFormat
            // 
            this.chkDivTagFormat.AutoSize = true;
            this.chkDivTagFormat.Location = new System.Drawing.Point(13, 180);
            this.chkDivTagFormat.Name = "chkDivTagFormat";
            this.chkDivTagFormat.Size = new System.Drawing.Size(92, 17);
            this.chkDivTagFormat.TabIndex = 11;
            this.chkDivTagFormat.Text = "Div tag format";
            this.chkDivTagFormat.UseVisualStyleBackColor = true;
            // 
            // chkSetTextboxFormat
            // 
            this.chkSetTextboxFormat.AutoSize = true;
            this.chkSetTextboxFormat.Location = new System.Drawing.Point(13, 204);
            this.chkSetTextboxFormat.Name = "chkSetTextboxFormat";
            this.chkSetTextboxFormat.Size = new System.Drawing.Size(118, 17);
            this.chkSetTextboxFormat.TabIndex = 12;
            this.chkSetTextboxFormat.Text = "Set Textbox Format";
            this.chkSetTextboxFormat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 347);
            this.Controls.Add(this.chkSetTextboxFormat);
            this.Controls.Add(this.chkDivTagFormat);
            this.Controls.Add(this.btnResetText);
            this.Controls.Add(this.chkSprocUpdateFormat);
            this.Controls.Add(this.chkSprocGetFormat);
            this.Controls.Add(this.chkUpdateFormat);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkUnderscores);
            this.Controls.Add(this.chkCommaSeparated);
            this.Controls.Add(this.chkAtSign);
            this.Controls.Add(this.chkCapitalize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCapitalize;
        private System.Windows.Forms.CheckBox chkAtSign;
        private System.Windows.Forms.CheckBox chkCommaSeparated;
        private System.Windows.Forms.CheckBox chkUnderscores;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.CheckBox chkUpdateFormat;
        private System.Windows.Forms.CheckBox chkSprocGetFormat;
        private System.Windows.Forms.CheckBox chkSprocUpdateFormat;
        private System.Windows.Forms.Button btnResetText;
        private System.Windows.Forms.CheckBox chkDivTagFormat;
        private System.Windows.Forms.CheckBox chkSetTextboxFormat;
    }
}

