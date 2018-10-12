namespace wf_calc
{
    partial class Form2
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
            this.Average = new System.Windows.Forms.Button();
            this.Odd = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.SortByDescending = new System.Windows.Forms.Button();
            this.screen2 = new System.Windows.Forms.TextBox();
            this.SortByOder = new System.Windows.Forms.Button();
            this.screen1 = new System.Windows.Forms.TextBox();
            this.Generation = new System.Windows.Forms.Button();
            this.CollectionSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Average
            // 
            this.Average.BackColor = System.Drawing.Color.Maroon;
            this.Average.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Average.Location = new System.Drawing.Point(238, 311);
            this.Average.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(133, 52);
            this.Average.TabIndex = 19;
            this.Average.Text = "Среднее";
            this.Average.UseVisualStyleBackColor = false;
            this.Average.Click += new System.EventHandler(this.Average_Click);
            // 
            // Odd
            // 
            this.Odd.BackColor = System.Drawing.Color.Maroon;
            this.Odd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Odd.Location = new System.Drawing.Point(238, 248);
            this.Odd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Odd.Name = "Odd";
            this.Odd.Size = new System.Drawing.Size(133, 52);
            this.Odd.TabIndex = 18;
            this.Odd.Text = "Чётные";
            this.Odd.UseVisualStyleBackColor = false;
            this.Odd.Click += new System.EventHandler(this.Odd_Click);
            // 
            // Max
            // 
            this.Max.BackColor = System.Drawing.Color.Maroon;
            this.Max.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Max.Location = new System.Drawing.Point(238, 187);
            this.Max.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(133, 52);
            this.Max.TabIndex = 17;
            this.Max.Text = "Максимальный";
            this.Max.UseVisualStyleBackColor = false;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // SortByDescending
            // 
            this.SortByDescending.BackColor = System.Drawing.Color.Maroon;
            this.SortByDescending.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SortByDescending.Location = new System.Drawing.Point(437, 72);
            this.SortByDescending.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SortByDescending.Name = "SortByDescending";
            this.SortByDescending.Size = new System.Drawing.Size(143, 67);
            this.SortByDescending.TabIndex = 16;
            this.SortByDescending.Text = "Сортировать по  убыванию";
            this.SortByDescending.UseVisualStyleBackColor = false;
            this.SortByDescending.Click += new System.EventHandler(this.SortByDescending_Click);
            // 
            // screen2
            // 
            this.screen2.Location = new System.Drawing.Point(424, 172);
            this.screen2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.screen2.Multiline = true;
            this.screen2.Name = "screen2";
            this.screen2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.screen2.Size = new System.Drawing.Size(155, 209);
            this.screen2.TabIndex = 15;
            // 
            // SortByOder
            // 
            this.SortByOder.BackColor = System.Drawing.Color.Maroon;
            this.SortByOder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SortByOder.Location = new System.Drawing.Point(56, 72);
            this.SortByOder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SortByOder.Name = "SortByOder";
            this.SortByOder.Size = new System.Drawing.Size(136, 67);
            this.SortByOder.TabIndex = 14;
            this.SortByOder.Text = "Сортировать по возрастанию";
            this.SortByOder.UseVisualStyleBackColor = false;
            this.SortByOder.Click += new System.EventHandler(this.SortByOder_Click);
            // 
            // screen1
            // 
            this.screen1.Location = new System.Drawing.Point(60, 172);
            this.screen1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.screen1.Multiline = true;
            this.screen1.Name = "screen1";
            this.screen1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.screen1.Size = new System.Drawing.Size(155, 209);
            this.screen1.TabIndex = 13;
            // 
            // Generation
            // 
            this.Generation.BackColor = System.Drawing.Color.Maroon;
            this.Generation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Generation.Location = new System.Drawing.Point(200, 72);
            this.Generation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(229, 69);
            this.Generation.TabIndex = 12;
            this.Generation.Text = "Сгенерировать коллекцию";
            this.Generation.UseVisualStyleBackColor = false;
            this.Generation.Click += new System.EventHandler(this.Generation_Click);
            // 
            // CollectionSize
            // 
            this.CollectionSize.Location = new System.Drawing.Point(238, 40);
            this.CollectionSize.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CollectionSize.Name = "CollectionSize";
            this.CollectionSize.Size = new System.Drawing.Size(132, 20);
            this.CollectionSize.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(247, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Размер коллекции";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(531, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "Меню";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(637, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Odd);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.SortByDescending);
            this.Controls.Add(this.screen2);
            this.Controls.Add(this.SortByOder);
            this.Controls.Add(this.screen1);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.CollectionSize);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Коллекция";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Average;
        private System.Windows.Forms.Button Odd;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button SortByDescending;
        private System.Windows.Forms.TextBox screen2;
        private System.Windows.Forms.Button SortByOder;
        private System.Windows.Forms.TextBox screen1;
        private System.Windows.Forms.Button Generation;
        private System.Windows.Forms.TextBox CollectionSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}