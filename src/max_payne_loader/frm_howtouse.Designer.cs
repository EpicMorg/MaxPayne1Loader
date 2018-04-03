namespace max_payne_loader
{
    partial class frm_howtouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_howtouse));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pic_logo2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(188, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(371, 262);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pic_logo2
            // 
            this.pic_logo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_logo2.Image = global::max_payne_loader.Properties.Resources.logo1;
            this.pic_logo2.Location = new System.Drawing.Point(12, 12);
            this.pic_logo2.Name = "pic_logo2";
            this.pic_logo2.Size = new System.Drawing.Size(174, 266);
            this.pic_logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_logo2.TabIndex = 0;
            this.pic_logo2.TabStop = false;
            // 
            // frm_howtouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 286);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pic_logo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_howtouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Help";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_howtouse_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo2;
        private System.Windows.Forms.TextBox textBox1;
    }
}