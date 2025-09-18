namespace ej3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            tbXMLContenido = new TextBox();
            lsbVer = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(393, 129);
            button1.Name = "button1";
            button1.Size = new Size(154, 117);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbXMLContenido
            // 
            tbXMLContenido.Location = new Point(12, 12);
            tbXMLContenido.Multiline = true;
            tbXMLContenido.Name = "tbXMLContenido";
            tbXMLContenido.Size = new Size(245, 210);
            tbXMLContenido.TabIndex = 1;
            tbXMLContenido.TextChanged += textBox1_TextChanged;
            // 
            // lsbVer
            // 
            lsbVer.FormattingEnabled = true;
            lsbVer.ItemHeight = 15;
            lsbVer.Location = new Point(12, 246);
            lsbVer.Name = "lsbVer";
            lsbVer.Size = new Size(245, 169);
            lsbVer.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 448);
            Controls.Add(lsbVer);
            Controls.Add(tbXMLContenido);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbXMLContenido;
        private ListBox lsbVer;
    }
}
