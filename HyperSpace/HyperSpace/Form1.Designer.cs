namespace HyperSpace
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
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.enterbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.exitbotton = new System.Windows.Forms.Button();
            this.totalprice = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shirtbox = new System.Windows.Forms.CheckBox();
            this.pantsbox = new System.Windows.Forms.CheckBox();
            this.shoebox = new System.Windows.Forms.CheckBox();
            this.textpants = new System.Windows.Forms.TextBox();
            this.textshoes = new System.Windows.Forms.TextBox();
            this.textshirt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.Color.BlueViolet;
            this.textbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textbox1.Location = new System.Drawing.Point(330, 12);
            this.textbox1.Name = "textbox1";
            this.textbox1.ReadOnly = true;
            this.textbox1.Size = new System.Drawing.Size(489, 55);
            this.textbox1.TabIndex = 0;
            this.textbox1.Text = "HyperSpace Clothing";
            // 
            // enterbutton
            // 
            this.enterbutton.Location = new System.Drawing.Point(138, 500);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(195, 74);
            this.enterbutton.TabIndex = 8;
            this.enterbutton.Text = "Add to Cart";
            this.enterbutton.UseVisualStyleBackColor = true;
            this.enterbutton.Click += new System.EventHandler(this.enterbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(138, 599);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(195, 70);
            this.clearbutton.TabIndex = 9;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // exitbotton
            // 
            this.exitbotton.Location = new System.Drawing.Point(138, 693);
            this.exitbotton.Name = "exitbotton";
            this.exitbotton.Size = new System.Drawing.Size(195, 70);
            this.exitbotton.TabIndex = 10;
            this.exitbotton.Text = "Exit Application";
            this.exitbotton.UseVisualStyleBackColor = true;
            this.exitbotton.Click += new System.EventHandler(this.exitbotton_Click);
            // 
            // totalprice
            // 
            this.totalprice.FormattingEnabled = true;
            this.totalprice.ItemHeight = 25;
            this.totalprice.Location = new System.Drawing.Point(879, 500);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(245, 354);
            this.totalprice.TabIndex = 12;
            this.totalprice.SelectedIndexChanged += new System.EventHandler(this.totalprice_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HyperSpace.Properties.Resources.Hyperspaceshoes;
            this.pictureBox3.Location = new System.Drawing.Point(727, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(335, 261);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::HyperSpace.Properties.Resources.hyperspacepants;
            this.pictureBox2.Location = new System.Drawing.Point(403, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 261);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HyperSpace.Properties.Resources.Hyperspaceshirt;
            this.pictureBox1.Location = new System.Drawing.Point(-24, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // shirtbox
            // 
            this.shirtbox.AutoSize = true;
            this.shirtbox.Location = new System.Drawing.Point(83, 371);
            this.shirtbox.Name = "shirtbox";
            this.shirtbox.Size = new System.Drawing.Size(130, 29);
            this.shirtbox.TabIndex = 13;
            this.shirtbox.Text = "$35 Shirt";
            this.shirtbox.UseVisualStyleBackColor = true;
            this.shirtbox.CheckedChanged += new System.EventHandler(this.shirtbox_CheckedChanged);
            // 
            // pantsbox
            // 
            this.pantsbox.AutoSize = true;
            this.pantsbox.Location = new System.Drawing.Point(474, 371);
            this.pantsbox.Name = "pantsbox";
            this.pantsbox.Size = new System.Drawing.Size(141, 29);
            this.pantsbox.TabIndex = 14;
            this.pantsbox.Text = "$55 Pants";
            this.pantsbox.UseVisualStyleBackColor = true;
            this.pantsbox.CheckedChanged += new System.EventHandler(this.pantsbox_CheckedChanged);
            // 
            // shoebox
            // 
            this.shoebox.AutoSize = true;
            this.shoebox.Location = new System.Drawing.Point(819, 371);
            this.shoebox.Name = "shoebox";
            this.shoebox.Size = new System.Drawing.Size(147, 29);
            this.shoebox.TabIndex = 15;
            this.shoebox.Text = "$85 Shoes";
            this.shoebox.UseVisualStyleBackColor = true;
            this.shoebox.CheckedChanged += new System.EventHandler(this.shoebox_CheckedChanged);
            // 
            // textpants
            // 
            this.textpants.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpants.Location = new System.Drawing.Point(474, 595);
            this.textpants.Name = "textpants";
            this.textpants.ReadOnly = true;
            this.textpants.Size = new System.Drawing.Size(225, 62);
            this.textpants.TabIndex = 17;
            this.textpants.Text = "Pants: 0";
            this.textpants.TextChanged += new System.EventHandler(this.textpants_TextChanged);
            // 
            // textshoes
            // 
            this.textshoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textshoes.Location = new System.Drawing.Point(469, 693);
            this.textshoes.Name = "textshoes";
            this.textshoes.ReadOnly = true;
            this.textshoes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textshoes.Size = new System.Drawing.Size(230, 62);
            this.textshoes.TabIndex = 18;
            this.textshoes.Text = "Shoes: 0";
            this.textshoes.TextChanged += new System.EventHandler(this.textshoes_TextChanged);
            // 
            // textshirt
            // 
            this.textshirt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textshirt.Location = new System.Drawing.Point(469, 498);
            this.textshirt.Name = "textshirt";
            this.textshirt.ReadOnly = true;
            this.textshirt.Size = new System.Drawing.Size(225, 62);
            this.textshirt.TabIndex = 20;
            this.textshirt.Text = "Shirts: 0";
            this.textshirt.TextChanged += new System.EventHandler(this.textshirt_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1180, 883);
            this.Controls.Add(this.textshirt);
            this.Controls.Add(this.textshoes);
            this.Controls.Add(this.textpants);
            this.Controls.Add(this.shoebox);
            this.Controls.Add(this.pantsbox);
            this.Controls.Add(this.shirtbox);
            this.Controls.Add(this.totalprice);
            this.Controls.Add(this.exitbotton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.enterbutton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Button enterbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button exitbotton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox shirtbox;
        private System.Windows.Forms.CheckBox pantsbox;
        private System.Windows.Forms.CheckBox shoebox;
        private System.Windows.Forms.TextBox textpants;
        private System.Windows.Forms.TextBox textshoes;
        private System.Windows.Forms.TextBox textshirt;
        public System.Windows.Forms.ListBox totalprice;
    }
}

