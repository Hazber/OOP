namespace Laba1.Forms
{
    partial class BottleForm
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
            this.TBVolume = new System.Windows.Forms.TextBox();
            this.CMBType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.TBCount = new System.Windows.Forms.TextBox();
            this.TBCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BReady = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBVolume
            // 
            this.TBVolume.Location = new System.Drawing.Point(113, 236);
            this.TBVolume.Name = "TBVolume";
            this.TBVolume.Size = new System.Drawing.Size(100, 20);
            this.TBVolume.TabIndex = 0;
            // 
            // CMBType
            // 
            this.CMBType.FormattingEnabled = true;
            this.CMBType.Location = new System.Drawing.Point(113, 292);
            this.CMBType.Name = "CMBType";
            this.CMBType.Size = new System.Drawing.Size(121, 21);
            this.CMBType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Объем";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(113, 46);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(160, 20);
            this.TBName.TabIndex = 4;
            // 
            // TBPrice
            // 
            this.TBPrice.Location = new System.Drawing.Point(113, 87);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.Size = new System.Drawing.Size(42, 20);
            this.TBPrice.TabIndex = 5;
            // 
            // TBCount
            // 
            this.TBCount.Location = new System.Drawing.Point(113, 136);
            this.TBCount.Name = "TBCount";
            this.TBCount.Size = new System.Drawing.Size(42, 20);
            this.TBCount.TabIndex = 6;
            // 
            // TBCountry
            // 
            this.TBCountry.Location = new System.Drawing.Point(113, 184);
            this.TBCountry.Name = "TBCountry";
            this.TBCountry.Size = new System.Drawing.Size(100, 20);
            this.TBCountry.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(161, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Количество";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Страна";
            // 
            // BReady
            // 
            this.BReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BReady.Location = new System.Drawing.Point(300, 341);
            this.BReady.Name = "BReady";
            this.BReady.Size = new System.Drawing.Size(167, 76);
            this.BReady.TabIndex = 13;
            this.BReady.Text = "Готово";
            this.BReady.UseVisualStyleBackColor = true;
            this.BReady.Click += new System.EventHandler(this.BReady_Click);
            // 
            // BottleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BReady);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBCountry);
            this.Controls.Add(this.TBCount);
            this.Controls.Add(this.TBPrice);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMBType);
            this.Controls.Add(this.TBVolume);
            this.Name = "BottleForm";
            this.Text = "BottleForm";
            this.Activated += new System.EventHandler(this.BottleForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBVolume;
        private System.Windows.Forms.ComboBox CMBType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBPrice;
        private System.Windows.Forms.TextBox TBCount;
        private System.Windows.Forms.TextBox TBCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BReady;
    }
}