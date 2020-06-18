namespace Qwixx
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
            this.btndobbelsteen = new System.Windows.Forms.Button();
            this.imgWit1 = new System.Windows.Forms.PictureBox();
            this.imgWit2 = new System.Windows.Forms.PictureBox();
            this.imgGeel = new System.Windows.Forms.PictureBox();
            this.imgGroen = new System.Windows.Forms.PictureBox();
            this.imgRood = new System.Windows.Forms.PictureBox();
            this.imgBlauw = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgWit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGeel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGroen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBlauw)).BeginInit();
            this.SuspendLayout();
            // 
            // btndobbelsteen
            // 
            this.btndobbelsteen.Location = new System.Drawing.Point(12, 626);
            this.btndobbelsteen.Name = "btndobbelsteen";
            this.btndobbelsteen.Size = new System.Drawing.Size(75, 23);
            this.btndobbelsteen.TabIndex = 0;
            this.btndobbelsteen.Text = "Dobbelsteen";
            this.btndobbelsteen.UseVisualStyleBackColor = true;
            this.btndobbelsteen.Click += new System.EventHandler(this.btndobbelsteen_Click);
            // 
            // imgWit1
            // 
            this.imgWit1.Location = new System.Drawing.Point(1060, 543);
            this.imgWit1.Name = "imgWit1";
            this.imgWit1.Size = new System.Drawing.Size(50, 50);
            this.imgWit1.TabIndex = 1;
            this.imgWit1.TabStop = false;
            // 
            // imgWit2
            // 
            this.imgWit2.Location = new System.Drawing.Point(1060, 599);
            this.imgWit2.Name = "imgWit2";
            this.imgWit2.Size = new System.Drawing.Size(50, 50);
            this.imgWit2.TabIndex = 2;
            this.imgWit2.TabStop = false;
            // 
            // imgGeel
            // 
            this.imgGeel.Location = new System.Drawing.Point(1116, 599);
            this.imgGeel.Name = "imgGeel";
            this.imgGeel.Size = new System.Drawing.Size(50, 50);
            this.imgGeel.TabIndex = 4;
            this.imgGeel.TabStop = false;
            // 
            // imgGroen
            // 
            this.imgGroen.Location = new System.Drawing.Point(1116, 543);
            this.imgGroen.Name = "imgGroen";
            this.imgGroen.Size = new System.Drawing.Size(50, 50);
            this.imgGroen.TabIndex = 3;
            this.imgGroen.TabStop = false;
            // 
            // imgRood
            // 
            this.imgRood.Location = new System.Drawing.Point(1172, 599);
            this.imgRood.Name = "imgRood";
            this.imgRood.Size = new System.Drawing.Size(50, 50);
            this.imgRood.TabIndex = 6;
            this.imgRood.TabStop = false;
            // 
            // imgBlauw
            // 
            this.imgBlauw.Location = new System.Drawing.Point(1172, 543);
            this.imgBlauw.Name = "imgBlauw";
            this.imgBlauw.Size = new System.Drawing.Size(50, 50);
            this.imgBlauw.TabIndex = 5;
            this.imgBlauw.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.imgRood);
            this.Controls.Add(this.imgBlauw);
            this.Controls.Add(this.imgGeel);
            this.Controls.Add(this.imgGroen);
            this.Controls.Add(this.imgWit2);
            this.Controls.Add(this.imgWit1);
            this.Controls.Add(this.btndobbelsteen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgWit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGeel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGroen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBlauw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndobbelsteen;
        private System.Windows.Forms.PictureBox imgWit1;
        private System.Windows.Forms.PictureBox imgWit2;
        private System.Windows.Forms.PictureBox imgGeel;
        private System.Windows.Forms.PictureBox imgGroen;
        private System.Windows.Forms.PictureBox imgRood;
        private System.Windows.Forms.PictureBox imgBlauw;
    }
}

