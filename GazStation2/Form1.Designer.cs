
namespace GazStation2
{
    partial class Check
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
            this.checkBTN = new System.Windows.Forms.Button();
            this.enternumberBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.enterPicktureBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBTN
            // 
            this.checkBTN.Location = new System.Drawing.Point(300, 462);
            this.checkBTN.Name = "checkBTN";
            this.checkBTN.Size = new System.Drawing.Size(138, 29);
            this.checkBTN.TabIndex = 0;
            this.checkBTN.Text = "Распознан";
            this.checkBTN.UseVisualStyleBackColor = true;
            this.checkBTN.Click += new System.EventHandler(this.checkBTN_Click);
            // 
            // enternumberBTN
            // 
            this.enternumberBTN.Location = new System.Drawing.Point(466, 462);
            this.enternumberBTN.Name = "enternumberBTN";
            this.enternumberBTN.Size = new System.Drawing.Size(138, 29);
            this.enternumberBTN.TabIndex = 2;
            this.enternumberBTN.Text = "Ввести номер";
            this.enternumberBTN.UseVisualStyleBackColor = true;
            this.enternumberBTN.Click += new System.EventHandler(this.enternumberBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Данные о номере";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(127, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 293);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // enterPicktureBTN
            // 
            this.enterPicktureBTN.Location = new System.Drawing.Point(342, 332);
            this.enterPicktureBTN.Name = "enterPicktureBTN";
            this.enterPicktureBTN.Size = new System.Drawing.Size(201, 29);
            this.enterPicktureBTN.TabIndex = 5;
            this.enterPicktureBTN.Text = "Выбрать изображение";
            this.enterPicktureBTN.UseVisualStyleBackColor = true;
            this.enterPicktureBTN.Click += new System.EventHandler(this.enterPicktureBTN_Click);
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 527);
            this.Controls.Add(this.enterPicktureBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enternumberBTN);
            this.Controls.Add(this.checkBTN);
            this.Name = "Check";
            this.Text = "Check";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkBTN;
        private System.Windows.Forms.Button enternumberBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button enterPicktureBTN;
    }
}

