namespace Laba1
{
    partial class FMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.Orders = new System.Windows.Forms.ListView();
            this.BAdd = new System.Windows.Forms.Button();
            this.BInfo = new System.Windows.Forms.Button();
            this.BChange = new System.Windows.Forms.Button();
            this.BDel = new System.Windows.Forms.Button();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SVD = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.хуевПоглотатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пососатьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.раздвинутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.володяКучеренкоГейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(344, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(118, 31);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Бухарик";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Orders
            // 
            this.Orders.HideSelection = false;
            this.Orders.Location = new System.Drawing.Point(12, 78);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(776, 294);
            this.Orders.TabIndex = 3;
            this.Orders.UseCompatibleStateImageBehavior = false;
            // 
            // BAdd
            // 
            this.BAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAdd.Location = new System.Drawing.Point(193, 398);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(119, 40);
            this.BAdd.TabIndex = 4;
            this.BAdd.Text = "Добавить";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BInfo
            // 
            this.BInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BInfo.Location = new System.Drawing.Point(350, 398);
            this.BInfo.Name = "BInfo";
            this.BInfo.Size = new System.Drawing.Size(119, 40);
            this.BInfo.TabIndex = 5;
            this.BInfo.Text = "Свойства";
            this.BInfo.UseVisualStyleBackColor = true;
            this.BInfo.Click += new System.EventHandler(this.BInfo_Click);
            // 
            // BChange
            // 
            this.BChange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BChange.Location = new System.Drawing.Point(514, 398);
            this.BChange.Name = "BChange";
            this.BChange.Size = new System.Drawing.Size(119, 40);
            this.BChange.TabIndex = 6;
            this.BChange.Text = "Изменить";
            this.BChange.UseVisualStyleBackColor = true;
            this.BChange.Click += new System.EventHandler(this.BChange_Click);
            // 
            // BDel
            // 
            this.BDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDel.Location = new System.Drawing.Point(669, 398);
            this.BDel.Name = "BDel";
            this.BDel.Size = new System.Drawing.Size(119, 40);
            this.BDel.TabIndex = 7;
            this.BDel.Text = "Удалить";
            this.BDel.UseVisualStyleBackColor = true;
            this.BDel.Click += new System.EventHandler(this.BDel_Click);
            // 
            // CBType
            // 
            this.CBType.FormattingEnabled = true;
            this.CBType.Location = new System.Drawing.Point(12, 398);
            this.CBType.Name = "CBType";
            this.CBType.Size = new System.Drawing.Size(164, 21);
            this.CBType.TabIndex = 8;
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.хуевПоглотатьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пососатьКакToolStripMenuItem,
            this.раздвинутьToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // хуевПоглотатьToolStripMenuItem
            // 
            this.хуевПоглотатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.володяКучеренкоГейToolStripMenuItem});
            this.хуевПоглотатьToolStripMenuItem.Name = "хуевПоглотатьToolStripMenuItem";
            this.хуевПоглотатьToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // пососатьКакToolStripMenuItem
            // 
            this.пососатьКакToolStripMenuItem.Name = "пососатьКакToolStripMenuItem";
            this.пососатьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пососатьКакToolStripMenuItem.Text = "Сохранить как";
            this.пососатьКакToolStripMenuItem.Click += new System.EventHandler(this.ПососатьКакToolStripMenuItem_Click);
            // 
            // раздвинутьToolStripMenuItem
            // 
            this.раздвинутьToolStripMenuItem.Name = "раздвинутьToolStripMenuItem";
            this.раздвинутьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.раздвинутьToolStripMenuItem.Text = "Открыть";
            this.раздвинутьToolStripMenuItem.Click += new System.EventHandler(this.РаздвинутьToolStripMenuItem_Click);
            // 
            // володяКучеренкоГейToolStripMenuItem
            // 
            this.володяКучеренкоГейToolStripMenuItem.Name = "володяКучеренкоГейToolStripMenuItem";
            this.володяКучеренкоГейToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.володяКучеренкоГейToolStripMenuItem.Text = "Володя Кучеренко гей";
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBType);
            this.Controls.Add(this.BDel);
            this.Controls.Add(this.BChange);
            this.Controls.Add(this.BInfo);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ListView Orders;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BInfo;
        private System.Windows.Forms.Button BChange;
        private System.Windows.Forms.Button BDel;
        private System.Windows.Forms.ComboBox CBType;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SVD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem пососатьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem раздвинутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хуевПоглотатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem володяКучеренкоГейToolStripMenuItem;
    }
}

