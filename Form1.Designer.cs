namespace HaveIt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblMotto = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnHaveIt = new System.Windows.Forms.Button();
            this.btnDecks = new System.Windows.Forms.Button();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.btnUpdateDecks = new System.Windows.Forms.Button();
            this.btnCards = new System.Windows.Forms.Button();
            this.txtBoxDisplay = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.imgTheros = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTheros)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(951, 591);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // lblMotto
            // 
            this.lblMotto.AutoSize = true;
            this.lblMotto.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotto.Location = new System.Drawing.Point(332, 37);
            this.lblMotto.Name = "lblMotto";
            this.lblMotto.Size = new System.Drawing.Size(347, 37);
            this.lblMotto.TabIndex = 1;
            this.lblMotto.Text = "Show the Magic!";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(449, 28);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(73, 49);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnHaveIt
            // 
            this.btnHaveIt.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHaveIt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHaveIt.BackgroundImage")));
            this.btnHaveIt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHaveIt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHaveIt.Image = ((System.Drawing.Image)(resources.GetObject("btnHaveIt.Image")));
            this.btnHaveIt.Location = new System.Drawing.Point(346, 28);
            this.btnHaveIt.Name = "btnHaveIt";
            this.btnHaveIt.Size = new System.Drawing.Size(75, 49);
            this.btnHaveIt.TabIndex = 3;
            this.btnHaveIt.Text = "HAVE IT?";
            this.btnHaveIt.UseVisualStyleBackColor = false;
            // 
            // btnDecks
            // 
            this.btnDecks.Location = new System.Drawing.Point(235, 28);
            this.btnDecks.Name = "btnDecks";
            this.btnDecks.Size = new System.Drawing.Size(75, 49);
            this.btnDecks.TabIndex = 4;
            this.btnDecks.Text = "Show Deck";
            this.btnDecks.UseVisualStyleBackColor = true;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.btnCards);
            this.grpOptions.Controls.Add(this.btnUpdateDecks);
            this.grpOptions.Controls.Add(this.btnDecks);
            this.grpOptions.Controls.Add(this.btnQuit);
            this.grpOptions.Controls.Add(this.btnHaveIt);
            this.grpOptions.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOptions.Location = new System.Drawing.Point(390, 484);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(543, 95);
            this.grpOptions.TabIndex = 5;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // btnUpdateDecks
            // 
            this.btnUpdateDecks.Location = new System.Drawing.Point(123, 28);
            this.btnUpdateDecks.Name = "btnUpdateDecks";
            this.btnUpdateDecks.Size = new System.Drawing.Size(75, 49);
            this.btnUpdateDecks.TabIndex = 6;
            this.btnUpdateDecks.Text = "Update Deck";
            this.btnUpdateDecks.UseVisualStyleBackColor = true;
            // 
            // btnCards
            // 
            this.btnCards.Location = new System.Drawing.Point(17, 28);
            this.btnCards.Name = "btnCards";
            this.btnCards.Size = new System.Drawing.Size(75, 49);
            this.btnCards.TabIndex = 6;
            this.btnCards.Text = "Update CARDS";
            this.btnCards.UseVisualStyleBackColor = true;
            // 
            // txtBoxDisplay
            // 
            this.txtBoxDisplay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBoxDisplay.Location = new System.Drawing.Point(390, 104);
            this.txtBoxDisplay.Multiline = true;
            this.txtBoxDisplay.Name = "txtBoxDisplay";
            this.txtBoxDisplay.ReadOnly = true;
            this.txtBoxDisplay.Size = new System.Drawing.Size(543, 374);
            this.txtBoxDisplay.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 497);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(372, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // imgTheros
            // 
            this.imgTheros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgTheros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgTheros.Image = ((System.Drawing.Image)(resources.GetObject("imgTheros.Image")));
            this.imgTheros.Location = new System.Drawing.Point(12, 104);
            this.imgTheros.Name = "imgTheros";
            this.imgTheros.Size = new System.Drawing.Size(372, 374);
            this.imgTheros.TabIndex = 8;
            this.imgTheros.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Theros Beyond Death";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(945, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgTheros);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtBoxDisplay);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.lblMotto);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Have It Doh";
            this.grpOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTheros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblMotto;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnHaveIt;
        private System.Windows.Forms.Button btnDecks;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Button btnCards;
        private System.Windows.Forms.Button btnUpdateDecks;
        private System.Windows.Forms.TextBox txtBoxDisplay;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox imgTheros;
        private System.Windows.Forms.Label label1;
    }
}

