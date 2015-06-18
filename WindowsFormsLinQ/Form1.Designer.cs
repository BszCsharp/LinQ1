namespace WindowsFormsLinQ
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBsp1 = new System.Windows.Forms.Button();
            this.richTextBoxAusgabe = new System.Windows.Forms.RichTextBox();
            this.buttonBsp2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBsp1
            // 
            this.buttonBsp1.Location = new System.Drawing.Point(28, 12);
            this.buttonBsp1.Name = "buttonBsp1";
            this.buttonBsp1.Size = new System.Drawing.Size(123, 42);
            this.buttonBsp1.TabIndex = 0;
            this.buttonBsp1.Text = "Beispiel1";
            this.buttonBsp1.UseVisualStyleBackColor = true;
            this.buttonBsp1.Click += new System.EventHandler(this.buttonBsp1_Click);
            // 
            // richTextBoxAusgabe
            // 
            this.richTextBoxAusgabe.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAusgabe.Location = new System.Drawing.Point(26, 234);
            this.richTextBoxAusgabe.Name = "richTextBoxAusgabe";
            this.richTextBoxAusgabe.Size = new System.Drawing.Size(563, 86);
            this.richTextBoxAusgabe.TabIndex = 1;
            this.richTextBoxAusgabe.Text = "";
            // 
            // buttonBsp2
            // 
            this.buttonBsp2.Location = new System.Drawing.Point(157, 12);
            this.buttonBsp2.Name = "buttonBsp2";
            this.buttonBsp2.Size = new System.Drawing.Size(123, 42);
            this.buttonBsp2.TabIndex = 2;
            this.buttonBsp2.Text = "Beispiel2";
            this.buttonBsp2.UseVisualStyleBackColor = true;
            this.buttonBsp2.Click += new System.EventHandler(this.buttonBsp2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 373);
            this.Controls.Add(this.buttonBsp2);
            this.Controls.Add(this.richTextBoxAusgabe);
            this.Controls.Add(this.buttonBsp1);
            this.Name = "Form1";
            this.Text = "LinQ-Beispiele";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBsp1;
        private System.Windows.Forms.RichTextBox richTextBoxAusgabe;
        private System.Windows.Forms.Button buttonBsp2;
    }
}

