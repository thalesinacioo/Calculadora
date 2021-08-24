
namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbloperacao = new System.Windows.Forms.Label();
            this.btCe = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btdivider = new System.Windows.Forms.Button();
            this.btmultiply = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btminus = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btplus = new System.Windows.Forms.Button();
            this.btthree = new System.Windows.Forms.Button();
            this.bttwo = new System.Windows.Forms.Button();
            this.btone = new System.Windows.Forms.Button();
            this.btequal = new System.Windows.Forms.Button();
            this.btdot = new System.Windows.Forms.Button();
            this.btzero = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbloperacao
            // 
            this.lbloperacao.AutoSize = true;
            this.lbloperacao.Font = new System.Drawing.Font("Barlow Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbloperacao.Location = new System.Drawing.Point(13, 9);
            this.lbloperacao.Name = "lbloperacao";
            this.lbloperacao.Size = new System.Drawing.Size(0, 48);
            this.lbloperacao.TabIndex = 1;
            this.lbloperacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCe
            // 
            this.btCe.BackColor = System.Drawing.Color.Orange;
            this.btCe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCe.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btCe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCe.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCe.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btCe.Location = new System.Drawing.Point(13, 266);
            this.btCe.Name = "btCe";
            this.btCe.Size = new System.Drawing.Size(126, 60);
            this.btCe.TabIndex = 2;
            this.btCe.Text = "CE";
            this.btCe.UseVisualStyleBackColor = false;
            this.btCe.Click += new System.EventHandler(this.btCe_Click);
            // 
            // btC
            // 
            this.btC.BackColor = System.Drawing.Color.Orange;
            this.btC.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btC.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btC.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btC.Location = new System.Drawing.Point(141, 266);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(62, 60);
            this.btC.TabIndex = 4;
            this.btC.Text = "⇦";
            this.btC.UseVisualStyleBackColor = false;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btdivider
            // 
            this.btdivider.BackColor = System.Drawing.Color.Orange;
            this.btdivider.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btdivider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdivider.Font = new System.Drawing.Font("Barlow Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btdivider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btdivider.Location = new System.Drawing.Point(205, 266);
            this.btdivider.Name = "btdivider";
            this.btdivider.Size = new System.Drawing.Size(62, 60);
            this.btdivider.TabIndex = 5;
            this.btdivider.Text = "÷";
            this.btdivider.UseVisualStyleBackColor = false;
            this.btdivider.Click += new System.EventHandler(this.btdivider_Click);
            // 
            // btmultiply
            // 
            this.btmultiply.BackColor = System.Drawing.Color.Orange;
            this.btmultiply.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btmultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmultiply.Font = new System.Drawing.Font("Barlow Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btmultiply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmultiply.Location = new System.Drawing.Point(205, 332);
            this.btmultiply.Name = "btmultiply";
            this.btmultiply.Size = new System.Drawing.Size(62, 60);
            this.btmultiply.TabIndex = 9;
            this.btmultiply.Text = "×";
            this.btmultiply.UseVisualStyleBackColor = false;
            this.btmultiply.Click += new System.EventHandler(this.btmultiply_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Orange;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(141, 332);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 60);
            this.button6.TabIndex = 8;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Orange;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(77, 332);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 60);
            this.button7.TabIndex = 7;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Orange;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(13, 332);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 60);
            this.button8.TabIndex = 6;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btminus
            // 
            this.btminus.BackColor = System.Drawing.Color.Orange;
            this.btminus.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btminus.Font = new System.Drawing.Font("Barlow Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btminus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btminus.Location = new System.Drawing.Point(204, 398);
            this.btminus.Name = "btminus";
            this.btminus.Size = new System.Drawing.Size(62, 60);
            this.btminus.TabIndex = 13;
            this.btminus.Text = "–";
            this.btminus.UseVisualStyleBackColor = false;
            this.btminus.Click += new System.EventHandler(this.btminus_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Orange;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(140, 398);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(62, 60);
            this.button10.TabIndex = 12;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Orange;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(76, 398);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(62, 60);
            this.button11.TabIndex = 11;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Orange;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(12, 398);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(62, 60);
            this.button12.TabIndex = 10;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // btplus
            // 
            this.btplus.BackColor = System.Drawing.Color.Orange;
            this.btplus.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btplus.Font = new System.Drawing.Font("Barlow Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btplus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btplus.Location = new System.Drawing.Point(204, 464);
            this.btplus.Name = "btplus";
            this.btplus.Size = new System.Drawing.Size(62, 60);
            this.btplus.TabIndex = 17;
            this.btplus.Text = "+";
            this.btplus.UseVisualStyleBackColor = false;
            this.btplus.Click += new System.EventHandler(this.btplus_Click);
            // 
            // btthree
            // 
            this.btthree.BackColor = System.Drawing.Color.Orange;
            this.btthree.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btthree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btthree.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btthree.Location = new System.Drawing.Point(140, 464);
            this.btthree.Name = "btthree";
            this.btthree.Size = new System.Drawing.Size(62, 60);
            this.btthree.TabIndex = 16;
            this.btthree.Text = "3";
            this.btthree.UseVisualStyleBackColor = false;
            this.btthree.Click += new System.EventHandler(this.btthree_Click);
            // 
            // bttwo
            // 
            this.bttwo.BackColor = System.Drawing.Color.Orange;
            this.bttwo.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bttwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttwo.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttwo.Location = new System.Drawing.Point(76, 464);
            this.bttwo.Name = "bttwo";
            this.bttwo.Size = new System.Drawing.Size(62, 60);
            this.bttwo.TabIndex = 15;
            this.bttwo.Text = "2";
            this.bttwo.UseVisualStyleBackColor = false;
            this.bttwo.Click += new System.EventHandler(this.bttwo_Click);
            // 
            // btone
            // 
            this.btone.BackColor = System.Drawing.Color.Orange;
            this.btone.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btone.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btone.Location = new System.Drawing.Point(12, 464);
            this.btone.Name = "btone";
            this.btone.Size = new System.Drawing.Size(62, 60);
            this.btone.TabIndex = 14;
            this.btone.Text = "1";
            this.btone.UseVisualStyleBackColor = false;
            this.btone.Click += new System.EventHandler(this.btone_Click);
            // 
            // btequal
            // 
            this.btequal.BackColor = System.Drawing.Color.Orange;
            this.btequal.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btequal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btequal.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btequal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btequal.Location = new System.Drawing.Point(204, 530);
            this.btequal.Name = "btequal";
            this.btequal.Size = new System.Drawing.Size(62, 60);
            this.btequal.TabIndex = 21;
            this.btequal.Text = "=";
            this.btequal.UseVisualStyleBackColor = false;
            this.btequal.Click += new System.EventHandler(this.btequal_Click);
            // 
            // btdot
            // 
            this.btdot.BackColor = System.Drawing.Color.Orange;
            this.btdot.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btdot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdot.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btdot.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btdot.Location = new System.Drawing.Point(136, 530);
            this.btdot.Name = "btdot";
            this.btdot.Size = new System.Drawing.Size(62, 60);
            this.btdot.TabIndex = 19;
            this.btdot.Text = ".";
            this.btdot.UseVisualStyleBackColor = false;
            this.btdot.Click += new System.EventHandler(this.btdot_Click);
            // 
            // btzero
            // 
            this.btzero.BackColor = System.Drawing.Color.Orange;
            this.btzero.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btzero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btzero.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btzero.Location = new System.Drawing.Point(12, 530);
            this.btzero.Name = "btzero";
            this.btzero.Size = new System.Drawing.Size(62, 60);
            this.btzero.TabIndex = 18;
            this.btzero.Text = "0";
            this.btzero.UseVisualStyleBackColor = false;
            this.btzero.Click += new System.EventHandler(this.btzero_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.Color.Orange;
            this.txtresultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtresultado.Font = new System.Drawing.Font("Barlow Condensed", 102F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtresultado.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtresultado.Location = new System.Drawing.Point(10, 81);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(257, 164);
            this.txtresultado.TabIndex = 23;
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(278, 602);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btequal);
            this.Controls.Add(this.btdot);
            this.Controls.Add(this.btzero);
            this.Controls.Add(this.btplus);
            this.Controls.Add(this.btthree);
            this.Controls.Add(this.bttwo);
            this.Controls.Add(this.btone);
            this.Controls.Add(this.btminus);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btmultiply);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btdivider);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btCe);
            this.Controls.Add(this.lbloperacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbloperacao;
        private System.Windows.Forms.Button btCe;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btdivider;
        private System.Windows.Forms.Button btmultiply;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btminus;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btplus;
        private System.Windows.Forms.Button btthree;
        private System.Windows.Forms.Button bttwo;
        private System.Windows.Forms.Button btone;
        private System.Windows.Forms.Button btequal;
        private System.Windows.Forms.Button btdot;
        private System.Windows.Forms.Button btzero;
        private System.Windows.Forms.TextBox txtresultado;
    }
}

