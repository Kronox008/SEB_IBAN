namespace SEBtestIBAN
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.btnManual = new System.Windows.Forms.Button();
            this.BoxManual = new System.Windows.Forms.TextBox();
            this.labelValid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.LabelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(127, 80);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(185, 23);
            this.btnManual.TabIndex = 0;
            this.btnManual.Text = "Tikrinti";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // BoxManual
            // 
            this.BoxManual.Location = new System.Drawing.Point(127, 34);
            this.BoxManual.Name = "BoxManual";
            this.BoxManual.Size = new System.Drawing.Size(185, 22);
            this.BoxManual.TabIndex = 1;
            // 
            // labelValid
            // 
            this.labelValid.AutoSize = true;
            this.labelValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValid.Location = new System.Drawing.Point(144, 118);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(0, 25);
            this.labelValid.TabIndex = 2;
            this.labelValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Įveskite IBAN:";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(410, 80);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(185, 23);
            this.btnFile.TabIndex = 4;
            this.btnFile.Text = "Tikrinti iš failo...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(376, 34);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(0, 17);
            this.LabelResult.TabIndex = 5;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(685, 170);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelValid);
            this.Controls.Add(this.BoxManual);
            this.Controls.Add(this.btnManual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Test";
            this.Text = "SEB IBAN test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.TextBox BoxManual;
        private System.Windows.Forms.Label labelValid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label LabelResult;
    }
}