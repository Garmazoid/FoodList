namespace дз
{
    partial class Form1
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
            this.Connect = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.ShowAll = new System.Windows.Forms.Button();
            this.ShowNames = new System.Windows.Forms.Button();
            this.ShowColors = new System.Windows.Forms.Button();
            this.ShowMinKall = new System.Windows.Forms.Button();
            this.ShowMaxKall = new System.Windows.Forms.Button();
            this.ShowAverageKall = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShowCountVeg = new System.Windows.Forms.Button();
            this.ShowCountFru = new System.Windows.Forms.Button();
            this.ShowWithColor = new System.Windows.Forms.Button();
            this.ShowCount = new System.Windows.Forms.Button();
            this.ShowWithKallBelow = new System.Windows.Forms.Button();
            this.ShowWithKallAbove = new System.Windows.Forms.Button();
            this.ShowInRange = new System.Windows.Forms.Button();
            this.ShowRedOrYellow = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.TextBox();
            this.kallForBelow = new System.Windows.Forms.TextBox();
            this.KallForAbove = new System.Windows.Forms.TextBox();
            this.StartRange = new System.Windows.Forms.TextBox();
            this.EndRange = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Connect.Location = new System.Drawing.Point(12, 12);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(385, 31);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "CONNECT";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Disconnect.Location = new System.Drawing.Point(403, 12);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(385, 31);
            this.Disconnect.TabIndex = 1;
            this.Disconnect.Text = "DISCONNECT";
            this.Disconnect.UseVisualStyleBackColor = false;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // ShowAll
            // 
            this.ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowAll.Location = new System.Drawing.Point(12, 49);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(385, 23);
            this.ShowAll.TabIndex = 2;
            this.ShowAll.Text = "Show all";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // ShowNames
            // 
            this.ShowNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowNames.Location = new System.Drawing.Point(403, 49);
            this.ShowNames.Name = "ShowNames";
            this.ShowNames.Size = new System.Drawing.Size(385, 23);
            this.ShowNames.TabIndex = 3;
            this.ShowNames.Text = "Show names";
            this.ShowNames.UseVisualStyleBackColor = true;
            this.ShowNames.Click += new System.EventHandler(this.ShowNames_Click);
            // 
            // ShowColors
            // 
            this.ShowColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowColors.Location = new System.Drawing.Point(12, 78);
            this.ShowColors.Name = "ShowColors";
            this.ShowColors.Size = new System.Drawing.Size(385, 23);
            this.ShowColors.TabIndex = 4;
            this.ShowColors.Text = "Show colors";
            this.ShowColors.UseVisualStyleBackColor = true;
            this.ShowColors.Click += new System.EventHandler(this.ShowColors_Click);
            // 
            // ShowMinKall
            // 
            this.ShowMinKall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowMinKall.Location = new System.Drawing.Point(12, 107);
            this.ShowMinKall.Name = "ShowMinKall";
            this.ShowMinKall.Size = new System.Drawing.Size(385, 23);
            this.ShowMinKall.TabIndex = 5;
            this.ShowMinKall.Text = "Show min kall";
            this.ShowMinKall.UseVisualStyleBackColor = true;
            this.ShowMinKall.Click += new System.EventHandler(this.ShowMinKall_Click);
            // 
            // ShowMaxKall
            // 
            this.ShowMaxKall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowMaxKall.Location = new System.Drawing.Point(403, 78);
            this.ShowMaxKall.Name = "ShowMaxKall";
            this.ShowMaxKall.Size = new System.Drawing.Size(385, 23);
            this.ShowMaxKall.TabIndex = 6;
            this.ShowMaxKall.Text = "Show max kall";
            this.ShowMaxKall.UseVisualStyleBackColor = true;
            this.ShowMaxKall.Click += new System.EventHandler(this.ShowMaxKall_Click);
            // 
            // ShowAverageKall
            // 
            this.ShowAverageKall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowAverageKall.Location = new System.Drawing.Point(403, 107);
            this.ShowAverageKall.Name = "ShowAverageKall";
            this.ShowAverageKall.Size = new System.Drawing.Size(385, 23);
            this.ShowAverageKall.TabIndex = 7;
            this.ShowAverageKall.Text = "Show average kall";
            this.ShowAverageKall.UseVisualStyleBackColor = true;
            this.ShowAverageKall.Click += new System.EventHandler(this.ShowAverageKall_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 146);
            this.dataGridView1.TabIndex = 8;
            // 
            // ShowCountVeg
            // 
            this.ShowCountVeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ShowCountVeg.Location = new System.Drawing.Point(12, 288);
            this.ShowCountVeg.Name = "ShowCountVeg";
            this.ShowCountVeg.Size = new System.Drawing.Size(385, 33);
            this.ShowCountVeg.TabIndex = 9;
            this.ShowCountVeg.Text = "Show quantity of vegetables";
            this.ShowCountVeg.UseVisualStyleBackColor = true;
            this.ShowCountVeg.Click += new System.EventHandler(this.ShowCountVeg_Click);
            // 
            // ShowCountFru
            // 
            this.ShowCountFru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ShowCountFru.Location = new System.Drawing.Point(403, 288);
            this.ShowCountFru.Name = "ShowCountFru";
            this.ShowCountFru.Size = new System.Drawing.Size(385, 33);
            this.ShowCountFru.TabIndex = 10;
            this.ShowCountFru.Text = "Show quantity of fruits";
            this.ShowCountFru.UseVisualStyleBackColor = true;
            this.ShowCountFru.Click += new System.EventHandler(this.ShowCountFru_Click);
            // 
            // ShowWithColor
            // 
            this.ShowWithColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ShowWithColor.Location = new System.Drawing.Point(12, 328);
            this.ShowWithColor.Name = "ShowWithColor";
            this.ShowWithColor.Size = new System.Drawing.Size(225, 30);
            this.ShowWithColor.TabIndex = 11;
            this.ShowWithColor.Text = "Show food with color ->";
            this.ShowWithColor.UseVisualStyleBackColor = true;
            this.ShowWithColor.Click += new System.EventHandler(this.ShowWithColor_Click);
            // 
            // ShowCount
            // 
            this.ShowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ShowCount.Location = new System.Drawing.Point(403, 327);
            this.ShowCount.Name = "ShowCount";
            this.ShowCount.Size = new System.Drawing.Size(385, 33);
            this.ShowCount.TabIndex = 12;
            this.ShowCount.Text = "Show quality of vegetables and fruits";
            this.ShowCount.UseVisualStyleBackColor = true;
            this.ShowCount.Click += new System.EventHandler(this.ShowCount_Click);
            // 
            // ShowWithKallBelow
            // 
            this.ShowWithKallBelow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ShowWithKallBelow.Location = new System.Drawing.Point(12, 369);
            this.ShowWithKallBelow.Name = "ShowWithKallBelow";
            this.ShowWithKallBelow.Size = new System.Drawing.Size(225, 30);
            this.ShowWithKallBelow.TabIndex = 13;
            this.ShowWithKallBelow.Text = "Show  kall below ->";
            this.ShowWithKallBelow.UseVisualStyleBackColor = true;
            this.ShowWithKallBelow.Click += new System.EventHandler(this.ShowWithKallBelow_Click);
            // 
            // ShowWithKallAbove
            // 
            this.ShowWithKallAbove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ShowWithKallAbove.Location = new System.Drawing.Point(403, 369);
            this.ShowWithKallAbove.Name = "ShowWithKallAbove";
            this.ShowWithKallAbove.Size = new System.Drawing.Size(225, 30);
            this.ShowWithKallAbove.TabIndex = 14;
            this.ShowWithKallAbove.Text = "Show  kall above  ->";
            this.ShowWithKallAbove.UseVisualStyleBackColor = true;
            this.ShowWithKallAbove.Click += new System.EventHandler(this.ShowWithKallAbove_Click);
            // 
            // ShowInRange
            // 
            this.ShowInRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ShowInRange.Location = new System.Drawing.Point(12, 405);
            this.ShowInRange.Name = "ShowInRange";
            this.ShowInRange.Size = new System.Drawing.Size(225, 33);
            this.ShowInRange.TabIndex = 15;
            this.ShowInRange.Text = "Show food in range ->";
            this.ShowInRange.UseVisualStyleBackColor = true;
            this.ShowInRange.Click += new System.EventHandler(this.ShowInRange_Click);
            // 
            // ShowRedOrYellow
            // 
            this.ShowRedOrYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ShowRedOrYellow.Location = new System.Drawing.Point(403, 405);
            this.ShowRedOrYellow.Name = "ShowRedOrYellow";
            this.ShowRedOrYellow.Size = new System.Drawing.Size(385, 33);
            this.ShowRedOrYellow.TabIndex = 16;
            this.ShowRedOrYellow.Text = "Show red or yellow food";
            this.ShowRedOrYellow.UseVisualStyleBackColor = true;
            this.ShowRedOrYellow.Click += new System.EventHandler(this.ShowRedOrYellow_Click);
            // 
            // Color
            // 
            this.Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Color.Location = new System.Drawing.Point(243, 328);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(154, 30);
            this.Color.TabIndex = 17;
            // 
            // kallForBelow
            // 
            this.kallForBelow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.kallForBelow.Location = new System.Drawing.Point(243, 369);
            this.kallForBelow.Name = "kallForBelow";
            this.kallForBelow.Size = new System.Drawing.Size(154, 30);
            this.kallForBelow.TabIndex = 18;
            // 
            // KallForAbove
            // 
            this.KallForAbove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.KallForAbove.Location = new System.Drawing.Point(634, 369);
            this.KallForAbove.Name = "KallForAbove";
            this.KallForAbove.Size = new System.Drawing.Size(154, 30);
            this.KallForAbove.TabIndex = 19;
            // 
            // StartRange
            // 
            this.StartRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.StartRange.Location = new System.Drawing.Point(243, 405);
            this.StartRange.Name = "StartRange";
            this.StartRange.Size = new System.Drawing.Size(75, 30);
            this.StartRange.TabIndex = 20;
            // 
            // EndRange
            // 
            this.EndRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EndRange.Location = new System.Drawing.Point(324, 405);
            this.EndRange.Name = "EndRange";
            this.EndRange.Size = new System.Drawing.Size(73, 30);
            this.EndRange.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndRange);
            this.Controls.Add(this.StartRange);
            this.Controls.Add(this.KallForAbove);
            this.Controls.Add(this.kallForBelow);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.ShowRedOrYellow);
            this.Controls.Add(this.ShowInRange);
            this.Controls.Add(this.ShowWithKallAbove);
            this.Controls.Add(this.ShowWithKallBelow);
            this.Controls.Add(this.ShowCount);
            this.Controls.Add(this.ShowWithColor);
            this.Controls.Add(this.ShowCountFru);
            this.Controls.Add(this.ShowCountVeg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowAverageKall);
            this.Controls.Add(this.ShowMaxKall);
            this.Controls.Add(this.ShowMinKall);
            this.Controls.Add(this.ShowColors);
            this.Controls.Add(this.ShowNames);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Button ShowNames;
        private System.Windows.Forms.Button ShowColors;
        private System.Windows.Forms.Button ShowMinKall;
        private System.Windows.Forms.Button ShowMaxKall;
        private System.Windows.Forms.Button ShowAverageKall;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowCountVeg;
        private System.Windows.Forms.Button ShowCountFru;
        private System.Windows.Forms.Button ShowWithColor;
        private System.Windows.Forms.Button ShowCount;
        private System.Windows.Forms.Button ShowWithKallBelow;
        private System.Windows.Forms.Button ShowWithKallAbove;
        private System.Windows.Forms.Button ShowInRange;
        private System.Windows.Forms.Button ShowRedOrYellow;
        private System.Windows.Forms.TextBox Color;
        private System.Windows.Forms.TextBox kallForBelow;
        private System.Windows.Forms.TextBox KallForAbove;
        private System.Windows.Forms.TextBox StartRange;
        private System.Windows.Forms.TextBox EndRange;
    }
}

