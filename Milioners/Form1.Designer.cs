namespace Milioners
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem0 = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановатьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CreatQvest = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_Quest = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеВопросаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.оИгреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(743, 551);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Начать игру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem0,
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem0
            // 
            this.ToolStripMenuItem0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьИгруToolStripMenuItem,
            this.остановатьИгруToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.ToolStripMenuItem0.Name = "ToolStripMenuItem0";
            this.ToolStripMenuItem0.Size = new System.Drawing.Size(46, 20);
            this.ToolStripMenuItem0.Text = "Игра";
            // 
            // начатьИгруToolStripMenuItem
            // 
            this.начатьИгруToolStripMenuItem.Name = "начатьИгруToolStripMenuItem";
            this.начатьИгруToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.начатьИгруToolStripMenuItem.Text = "Начать игру";
            // 
            // остановатьИгруToolStripMenuItem
            // 
            this.остановатьИгруToolStripMenuItem.Name = "остановатьИгруToolStripMenuItem";
            this.остановатьИгруToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.остановатьИгруToolStripMenuItem.Text = "Остановать игру";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreatQvest,
            this.Edit_Quest,
            this.удалениеВопросаToolStripMenuItem});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(106, 20);
            this.ToolStripMenuItem1.Text = "Администратор";
            // 
            // CreatQvest
            // 
            this.CreatQvest.Name = "CreatQvest";
            this.CreatQvest.Size = new System.Drawing.Size(185, 22);
            this.CreatQvest.Text = "Создать вопрос";
            this.CreatQvest.Click += new System.EventHandler(this.CreatQvest_Click);
            // 
            // Edit_Quest
            // 
            this.Edit_Quest.Name = "Edit_Quest";
            this.Edit_Quest.Size = new System.Drawing.Size(185, 22);
            this.Edit_Quest.Text = "Изменение вопроса";
            this.Edit_Quest.Click += new System.EventHandler(this.Edit_Quest_Click);
            // 
            // удалениеВопросаToolStripMenuItem
            // 
            this.удалениеВопросаToolStripMenuItem.Name = "удалениеВопросаToolStripMenuItem";
            this.удалениеВопросаToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.удалениеВопросаToolStripMenuItem.Text = "Удаление вопроса";
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оИгреToolStripMenuItem});
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(68, 20);
            this.ToolStripMenuItem2.Text = "Помощь";
            // 
            // оИгреToolStripMenuItem
            // 
            this.оИгреToolStripMenuItem.Name = "оИгреToolStripMenuItem";
            this.оИгреToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.оИгреToolStripMenuItem.Text = "О игре";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(740, 546);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Миллионер";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem0;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem начатьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановатьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreatQvest;
        private System.Windows.Forms.ToolStripMenuItem Edit_Quest;
        private System.Windows.Forms.ToolStripMenuItem удалениеВопросаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оИгреToolStripMenuItem;
    }
}

