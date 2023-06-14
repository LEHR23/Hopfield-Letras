namespace Hopfield_Letras
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
            this.pvectorent = new System.Windows.Forms.Panel();
            this.pvectorres = new System.Windows.Forms.Panel();
            this.btnlimpiar = new System.Windows.Forms.Label();
            this.hopfield = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pvectorent
            // 
            this.pvectorent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pvectorent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pvectorent.Location = new System.Drawing.Point(13, 13);
            this.pvectorent.Name = "pvectorent";
            this.pvectorent.Size = new System.Drawing.Size(166, 157);
            this.pvectorent.TabIndex = 0;
            // 
            // pvectorres
            // 
            this.pvectorres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pvectorres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pvectorres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pvectorres.Location = new System.Drawing.Point(295, 13);
            this.pvectorres.Name = "pvectorres";
            this.pvectorres.Size = new System.Drawing.Size(166, 157);
            this.pvectorres.TabIndex = 0;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlimpiar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(203, 53);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(72, 42);
            this.btnlimpiar.TabIndex = 1;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // hopfield
            // 
            this.hopfield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hopfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hopfield.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hopfield.ForeColor = System.Drawing.Color.White;
            this.hopfield.Location = new System.Drawing.Point(203, 110);
            this.hopfield.Name = "hopfield";
            this.hopfield.Size = new System.Drawing.Size(72, 39);
            this.hopfield.TabIndex = 1;
            this.hopfield.Text = "HOPFIELD";
            this.hopfield.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hopfield.Click += new System.EventHandler(this.hopfield_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 206);
            this.Controls.Add(this.hopfield);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.pvectorres);
            this.Controls.Add(this.pvectorent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pvectorent;
        private System.Windows.Forms.Panel pvectorres;
        private System.Windows.Forms.Label btnlimpiar;
        private System.Windows.Forms.Label hopfield;
    }
}

