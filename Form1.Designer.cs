namespace SnakeGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.yilansBasi = new System.Windows.Forms.PictureBox();
            this.yilanGovde = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.yilansBasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilanGovde)).BeginInit();
            this.SuspendLayout();
            // 
            // yilansBasi
            // 
            this.yilansBasi.BackColor = System.Drawing.Color.Transparent;
            this.yilansBasi.Image = ((System.Drawing.Image)(resources.GetObject("yilansBasi.Image")));
            this.yilansBasi.Location = new System.Drawing.Point(1317, 12);
            this.yilansBasi.Name = "yilansBasi";
            this.yilansBasi.Size = new System.Drawing.Size(40, 30);
            this.yilansBasi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yilansBasi.TabIndex = 0;
            this.yilansBasi.TabStop = false;
            // 
            // yilanGovde
            // 
            this.yilanGovde.Image = ((System.Drawing.Image)(resources.GetObject("yilanGovde.Image")));
            this.yilanGovde.Location = new System.Drawing.Point(1389, 12);
            this.yilanGovde.Name = "yilanGovde";
            this.yilanGovde.Size = new System.Drawing.Size(40, 30);
            this.yilanGovde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yilanGovde.TabIndex = 0;
            this.yilanGovde.TabStop = false;
            this.yilanGovde.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 1055);
            this.Controls.Add(this.yilanGovde);
            this.Controls.Add(this.yilansBasi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.yilansBasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilanGovde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox yilansBasi;
        private System.Windows.Forms.PictureBox yilanGovde;
        private System.Windows.Forms.Timer timer1;
    }
}

