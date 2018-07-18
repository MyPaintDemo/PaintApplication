namespace PaintClone
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
            this.ZonaMeniu = new System.Windows.Forms.Panel();
            this.btnEraser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BlackCol = new System.Windows.Forms.Button();
            this.PinkCol = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.PurpleCol = new System.Windows.Forms.Button();
            this.GreenCol = new System.Windows.Forms.Button();
            this.YellowCol = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.RedCol = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentColor = new System.Windows.Forms.Panel();
            this.ZonaScris = new TPanel();
            this.ZonaMeniu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZonaMeniu
            // 
            this.ZonaMeniu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ZonaMeniu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ZonaMeniu.Controls.Add(this.btnEraser);
            this.ZonaMeniu.Controls.Add(this.label3);
            this.ZonaMeniu.Controls.Add(this.BlackCol);
            this.ZonaMeniu.Controls.Add(this.PinkCol);
            this.ZonaMeniu.Controls.Add(this.button7);
            this.ZonaMeniu.Controls.Add(this.PurpleCol);
            this.ZonaMeniu.Controls.Add(this.GreenCol);
            this.ZonaMeniu.Controls.Add(this.YellowCol);
            this.ZonaMeniu.Controls.Add(this.button3);
            this.ZonaMeniu.Controls.Add(this.RedCol);
            this.ZonaMeniu.Controls.Add(this.button1);
            this.ZonaMeniu.Controls.Add(this.label2);
            this.ZonaMeniu.Controls.Add(this.label1);
            this.ZonaMeniu.Controls.Add(this.currentColor);
            this.ZonaMeniu.Location = new System.Drawing.Point(529, 4);
            this.ZonaMeniu.Name = "ZonaMeniu";
            this.ZonaMeniu.Size = new System.Drawing.Size(100, 432);
            this.ZonaMeniu.TabIndex = 1;
            // 
            // btnEraser
            // 
            this.btnEraser.Location = new System.Drawing.Point(58, 119);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(21, 13);
            this.btnEraser.TabIndex = 12;
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Eraser";
            // 
            // BlackCol
            // 
            this.BlackCol.BackColor = System.Drawing.Color.Black;
            this.BlackCol.Location = new System.Drawing.Point(51, 322);
            this.BlackCol.Name = "BlackCol";
            this.BlackCol.Size = new System.Drawing.Size(24, 23);
            this.BlackCol.TabIndex = 10;
            this.BlackCol.UseVisualStyleBackColor = false;
            this.BlackCol.Click += new System.EventHandler(this.BlackCol_Click);
            // 
            // PinkCol
            // 
            this.PinkCol.BackColor = System.Drawing.Color.PaleVioletRed;
            this.PinkCol.Location = new System.Drawing.Point(15, 322);
            this.PinkCol.Name = "PinkCol";
            this.PinkCol.Size = new System.Drawing.Size(24, 23);
            this.PinkCol.TabIndex = 9;
            this.PinkCol.UseVisualStyleBackColor = false;
            this.PinkCol.Click += new System.EventHandler(this.PinkCol_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(11, 384);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Save as";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // PurpleCol
            // 
            this.PurpleCol.BackColor = System.Drawing.Color.Purple;
            this.PurpleCol.Location = new System.Drawing.Point(51, 282);
            this.PurpleCol.Name = "PurpleCol";
            this.PurpleCol.Size = new System.Drawing.Size(24, 23);
            this.PurpleCol.TabIndex = 7;
            this.PurpleCol.UseVisualStyleBackColor = false;
            this.PurpleCol.Click += new System.EventHandler(this.PurpleCol_Click);
            // 
            // GreenCol
            // 
            this.GreenCol.BackColor = System.Drawing.Color.Green;
            this.GreenCol.Location = new System.Drawing.Point(15, 282);
            this.GreenCol.Name = "GreenCol";
            this.GreenCol.Size = new System.Drawing.Size(24, 23);
            this.GreenCol.TabIndex = 6;
            this.GreenCol.UseVisualStyleBackColor = false;
            this.GreenCol.Click += new System.EventHandler(this.GreenCol_Click);
            // 
            // YellowCol
            // 
            this.YellowCol.BackColor = System.Drawing.Color.Gold;
            this.YellowCol.Location = new System.Drawing.Point(51, 237);
            this.YellowCol.Name = "YellowCol";
            this.YellowCol.Size = new System.Drawing.Size(24, 23);
            this.YellowCol.TabIndex = 5;
            this.YellowCol.UseVisualStyleBackColor = false;
            this.YellowCol.Click += new System.EventHandler(this.YellowCol_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(15, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 23);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RedCol
            // 
            this.RedCol.BackColor = System.Drawing.Color.Red;
            this.RedCol.Location = new System.Drawing.Point(51, 191);
            this.RedCol.Name = "RedCol";
            this.RedCol.Size = new System.Drawing.Size(24, 23);
            this.RedCol.TabIndex = 3;
            this.RedCol.UseVisualStyleBackColor = false;
            this.RedCol.Click += new System.EventHandler(this.RedCol_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(15, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current color";
            // 
            // currentColor
            // 
            this.currentColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentColor.Location = new System.Drawing.Point(28, 47);
            this.currentColor.Name = "currentColor";
            this.currentColor.Size = new System.Drawing.Size(34, 32);
            this.currentColor.TabIndex = 0;
            // 
            // ZonaScris
            // 
            this.ZonaScris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ZonaScris.Location = new System.Drawing.Point(3, 4);
            this.ZonaScris.Name = "ZonaScris";
            this.ZonaScris.Size = new System.Drawing.Size(520, 432);
            this.ZonaScris.TabIndex = 2;
            this.ZonaScris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ZonaScris_MouseDown);
            this.ZonaScris.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ZonaScris_MouseMove);
            this.ZonaScris.BackColor = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 437);
            this.Controls.Add(this.ZonaScris);
            this.Controls.Add(this.ZonaMeniu);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "PaintClone";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ZonaMeniu.ResumeLayout(false);
            this.ZonaMeniu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ZonaMeniu;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BlackCol;
        private System.Windows.Forms.Button PinkCol;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button PurpleCol;
        private System.Windows.Forms.Button GreenCol;
        private System.Windows.Forms.Button YellowCol;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button RedCol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel currentColor;
        private System.Windows.Forms.Panel ZonaScris;
    }
}

