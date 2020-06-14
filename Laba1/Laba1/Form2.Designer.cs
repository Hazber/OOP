namespace Laba1
{
    partial class PluginForm
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
            this.CMBPlug = new System.Windows.Forms.ComboBox();
            this.BSave = new System.Windows.Forms.Button();
            this.BDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CMBPlug
            // 
            this.CMBPlug.FormattingEnabled = true;
            this.CMBPlug.Location = new System.Drawing.Point(99, 105);
            this.CMBPlug.Name = "CMBPlug";
            this.CMBPlug.Size = new System.Drawing.Size(151, 21);
            this.CMBPlug.TabIndex = 0;
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(43, 166);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(96, 50);
            this.BSave.TabIndex = 1;
            this.BSave.Text = "Сохранить";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BDel
            // 
            this.BDel.Location = new System.Drawing.Point(186, 166);
            this.BDel.Name = "BDel";
            this.BDel.Size = new System.Drawing.Size(105, 50);
            this.BDel.TabIndex = 2;
            this.BDel.Text = "Удалить";
            this.BDel.UseVisualStyleBackColor = true;
            this.BDel.Click += new System.EventHandler(this.BDel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(95, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите плагин";
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 238);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BDel);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.CMBPlug);
            this.Name = "PluginForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMBPlug;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Button BDel;
        private System.Windows.Forms.Label label1;
    }
}