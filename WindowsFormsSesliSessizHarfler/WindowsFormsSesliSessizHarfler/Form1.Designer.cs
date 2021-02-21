
namespace WindowsFormsSesliSessizHarfler
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
            this.lkelime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lSesli = new System.Windows.Forms.Label();
            this.lSessiz = new System.Windows.Forms.Label();
            this.lbSesli = new System.Windows.Forms.ListBox();
            this.lbSessiz = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lkelime
            // 
            this.lkelime.AutoSize = true;
            this.lkelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lkelime.Location = new System.Drawing.Point(38, 40);
            this.lkelime.Name = "lkelime";
            this.lkelime.Size = new System.Drawing.Size(119, 20);
            this.lkelime.TabIndex = 0;
            this.lkelime.Text = "Kelime giriniz.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(237, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Harfleri Ayır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lSesli
            // 
            this.lSesli.AutoSize = true;
            this.lSesli.Location = new System.Drawing.Point(84, 191);
            this.lSesli.Name = "lSesli";
            this.lSesli.Size = new System.Drawing.Size(95, 20);
            this.lSesli.TabIndex = 3;
            this.lSesli.Text = "Sesli Harfler";
            // 
            // lSessiz
            // 
            this.lSessiz.AutoSize = true;
            this.lSessiz.Location = new System.Drawing.Point(529, 191);
            this.lSessiz.Name = "lSessiz";
            this.lSessiz.Size = new System.Drawing.Size(108, 20);
            this.lSessiz.TabIndex = 3;
            this.lSessiz.Text = "Sessiz Harfler";
            // 
            // lbSesli
            // 
            this.lbSesli.FormattingEnabled = true;
            this.lbSesli.ItemHeight = 20;
            this.lbSesli.Location = new System.Drawing.Point(88, 214);
            this.lbSesli.Name = "lbSesli";
            this.lbSesli.Size = new System.Drawing.Size(120, 164);
            this.lbSesli.TabIndex = 4;
            // 
            // lbSessiz
            // 
            this.lbSessiz.FormattingEnabled = true;
            this.lbSessiz.ItemHeight = 20;
            this.lbSessiz.Location = new System.Drawing.Point(533, 224);
            this.lbSessiz.Name = "lbSessiz";
            this.lbSessiz.Size = new System.Drawing.Size(120, 164);
            this.lbSessiz.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSessiz);
            this.Controls.Add(this.lbSesli);
            this.Controls.Add(this.lSessiz);
            this.Controls.Add(this.lSesli);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lkelime);
            this.Name = "Form1";
            this.Text = "SesliSessizHarf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lkelime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lSesli;
        private System.Windows.Forms.Label lSessiz;
        private System.Windows.Forms.ListBox lbSesli;
        private System.Windows.Forms.ListBox lbSessiz;
    }
}

