namespace wf_calc
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConcat = new System.Windows.Forms.TabPage();
            this.CalculateConcat_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultStringlbl = new System.Windows.Forms.Label();
            this.String2txtb = new System.Windows.Forms.TextBox();
            this.String1txtb = new System.Windows.Forms.TextBox();
            this.tabReplace = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.replacedString_txtb = new System.Windows.Forms.TextBox();
            this.calculateReplace_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.String_lbl = new System.Windows.Forms.Label();
            this.ReplaceResult_lbl = new System.Windows.Forms.Label();
            this.newString_txtb = new System.Windows.Forms.TextBox();
            this.tabRemove = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.count_txtb = new System.Windows.Forms.TextBox();
            this.index_cmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.calculateRemove_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.removeResult_lbl = new System.Windows.Forms.Label();
            this.tabSymbol = new System.Windows.Forms.TabPage();
            this.calculateSymbol_btn = new System.Windows.Forms.Button();
            this.string2_lbl = new System.Windows.Forms.Label();
            this.Indexcmb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.symbol_lbl = new System.Windows.Forms.Label();
            this.tabLenght = new System.Windows.Forms.TabPage();
            this.calculateLenght_btn = new System.Windows.Forms.Button();
            this.Resultlbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.line_txtb = new System.Windows.Forms.TextBox();
            this.tabDoublingVowels = new System.Windows.Forms.TabPage();
            this.DoublingVowels_btn = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.str1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabConcat.SuspendLayout();
            this.tabReplace.SuspendLayout();
            this.tabRemove.SuspendLayout();
            this.tabSymbol.SuspendLayout();
            this.tabLenght.SuspendLayout();
            this.tabDoublingVowels.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabConcat);
            this.tabControl.Controls.Add(this.tabReplace);
            this.tabControl.Controls.Add(this.tabRemove);
            this.tabControl.Controls.Add(this.tabSymbol);
            this.tabControl.Controls.Add(this.tabLenght);
            this.tabControl.Controls.Add(this.tabDoublingVowels);
            this.tabControl.Location = new System.Drawing.Point(6, 9);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(401, 269);
            this.tabControl.TabIndex = 0;
            // 
            // tabConcat
            // 
            this.tabConcat.Controls.Add(this.CalculateConcat_btn);
            this.tabConcat.Controls.Add(this.label2);
            this.tabConcat.Controls.Add(this.label1);
            this.tabConcat.Controls.Add(this.ResultStringlbl);
            this.tabConcat.Controls.Add(this.String2txtb);
            this.tabConcat.Controls.Add(this.String1txtb);
            this.tabConcat.Location = new System.Drawing.Point(4, 22);
            this.tabConcat.Name = "tabConcat";
            this.tabConcat.Padding = new System.Windows.Forms.Padding(3);
            this.tabConcat.Size = new System.Drawing.Size(393, 243);
            this.tabConcat.TabIndex = 0;
            this.tabConcat.Text = "объединение";
            this.tabConcat.UseVisualStyleBackColor = true;
            // 
            // CalculateConcat_btn
            // 
            this.CalculateConcat_btn.Location = new System.Drawing.Point(160, 216);
            this.CalculateConcat_btn.Name = "CalculateConcat_btn";
            this.CalculateConcat_btn.Size = new System.Drawing.Size(75, 23);
            this.CalculateConcat_btn.TabIndex = 5;
            this.CalculateConcat_btn.Text = "calculate";
            this.CalculateConcat_btn.UseVisualStyleBackColor = true;
            this.CalculateConcat_btn.Click += new System.EventHandler(this.CalculateConcat_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Строка 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Строка 1";
            // 
            // ResultStringlbl
            // 
            this.ResultStringlbl.AutoSize = true;
            this.ResultStringlbl.Location = new System.Drawing.Point(25, 124);
            this.ResultStringlbl.Name = "ResultStringlbl";
            this.ResultStringlbl.Size = new System.Drawing.Size(10, 13);
            this.ResultStringlbl.TabIndex = 2;
            this.ResultStringlbl.Text = " ";
            // 
            // String2txtb
            // 
            this.String2txtb.Location = new System.Drawing.Point(208, 59);
            this.String2txtb.Name = "String2txtb";
            this.String2txtb.Size = new System.Drawing.Size(149, 20);
            this.String2txtb.TabIndex = 1;
            // 
            // String1txtb
            // 
            this.String1txtb.Location = new System.Drawing.Point(28, 59);
            this.String1txtb.Name = "String1txtb";
            this.String1txtb.Size = new System.Drawing.Size(149, 20);
            this.String1txtb.TabIndex = 0;
            // 
            // tabReplace
            // 
            this.tabReplace.Controls.Add(this.label4);
            this.tabReplace.Controls.Add(this.replacedString_txtb);
            this.tabReplace.Controls.Add(this.calculateReplace_btn);
            this.tabReplace.Controls.Add(this.label3);
            this.tabReplace.Controls.Add(this.String_lbl);
            this.tabReplace.Controls.Add(this.ReplaceResult_lbl);
            this.tabReplace.Controls.Add(this.newString_txtb);
            this.tabReplace.Location = new System.Drawing.Point(4, 22);
            this.tabReplace.Name = "tabReplace";
            this.tabReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tabReplace.Size = new System.Drawing.Size(395, 278);
            this.tabReplace.TabIndex = 1;
            this.tabReplace.Text = "Замена";
            this.tabReplace.UseVisualStyleBackColor = true;
            this.tabReplace.Click += new System.EventHandler(this.tabReplace_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Что заменить:";
            // 
            // replacedString_txtb
            // 
            this.replacedString_txtb.Location = new System.Drawing.Point(35, 76);
            this.replacedString_txtb.Name = "replacedString_txtb";
            this.replacedString_txtb.Size = new System.Drawing.Size(149, 20);
            this.replacedString_txtb.TabIndex = 11;
            // 
            // calculateReplace_btn
            // 
            this.calculateReplace_btn.Location = new System.Drawing.Point(160, 234);
            this.calculateReplace_btn.Name = "calculateReplace_btn";
            this.calculateReplace_btn.Size = new System.Drawing.Size(75, 23);
            this.calculateReplace_btn.TabIndex = 10;
            this.calculateReplace_btn.Text = "calculate";
            this.calculateReplace_btn.UseVisualStyleBackColor = true;
            this.calculateReplace_btn.Click += new System.EventHandler(this.calculateReplace_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "На сто заменить:";
            // 
            // String_lbl
            // 
            this.String_lbl.AutoSize = true;
            this.String_lbl.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.String_lbl.Location = new System.Drawing.Point(27, 16);
            this.String_lbl.Name = "String_lbl";
            this.String_lbl.Size = new System.Drawing.Size(348, 28);
            this.String_lbl.TabIndex = 8;
            this.String_lbl.Text = "I\'m a stranger here, oh dear, what now?";
            // 
            // ReplaceResult_lbl
            // 
            this.ReplaceResult_lbl.AutoSize = true;
            this.ReplaceResult_lbl.Location = new System.Drawing.Point(32, 134);
            this.ReplaceResult_lbl.Name = "ReplaceResult_lbl";
            this.ReplaceResult_lbl.Size = new System.Drawing.Size(10, 13);
            this.ReplaceResult_lbl.TabIndex = 7;
            this.ReplaceResult_lbl.Text = " ";
            // 
            // newString_txtb
            // 
            this.newString_txtb.Location = new System.Drawing.Point(207, 76);
            this.newString_txtb.Name = "newString_txtb";
            this.newString_txtb.Size = new System.Drawing.Size(149, 20);
            this.newString_txtb.TabIndex = 6;
            // 
            // tabRemove
            // 
            this.tabRemove.Controls.Add(this.label7);
            this.tabRemove.Controls.Add(this.count_txtb);
            this.tabRemove.Controls.Add(this.index_cmb);
            this.tabRemove.Controls.Add(this.label5);
            this.tabRemove.Controls.Add(this.calculateRemove_btn);
            this.tabRemove.Controls.Add(this.label6);
            this.tabRemove.Controls.Add(this.removeResult_lbl);
            this.tabRemove.Location = new System.Drawing.Point(4, 22);
            this.tabRemove.Name = "tabRemove";
            this.tabRemove.Size = new System.Drawing.Size(395, 278);
            this.tabRemove.TabIndex = 2;
            this.tabRemove.Text = "Удаление";
            this.tabRemove.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Количество символов:";
            // 
            // count_txtb
            // 
            this.count_txtb.Location = new System.Drawing.Point(233, 102);
            this.count_txtb.Name = "count_txtb";
            this.count_txtb.Size = new System.Drawing.Size(119, 20);
            this.count_txtb.TabIndex = 14;
            // 
            // index_cmb
            // 
            this.index_cmb.FormattingEnabled = true;
            this.index_cmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39"});
            this.index_cmb.Location = new System.Drawing.Point(31, 102);
            this.index_cmb.Name = "index_cmb";
            this.index_cmb.Size = new System.Drawing.Size(121, 21);
            this.index_cmb.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "I\'m a stranger here, oh dear, what now?";
            // 
            // calculateRemove_btn
            // 
            this.calculateRemove_btn.Location = new System.Drawing.Point(162, 238);
            this.calculateRemove_btn.Name = "calculateRemove_btn";
            this.calculateRemove_btn.Size = new System.Drawing.Size(75, 23);
            this.calculateRemove_btn.TabIndex = 11;
            this.calculateRemove_btn.Text = "calculate";
            this.calculateRemove_btn.UseVisualStyleBackColor = true;
            this.calculateRemove_btn.Click += new System.EventHandler(this.calculateRemove_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Начиная с какого символа:";
            // 
            // removeResult_lbl
            // 
            this.removeResult_lbl.AutoSize = true;
            this.removeResult_lbl.Location = new System.Drawing.Point(28, 148);
            this.removeResult_lbl.Name = "removeResult_lbl";
            this.removeResult_lbl.Size = new System.Drawing.Size(10, 13);
            this.removeResult_lbl.TabIndex = 7;
            this.removeResult_lbl.Text = " ";
            // 
            // tabSymbol
            // 
            this.tabSymbol.Controls.Add(this.calculateSymbol_btn);
            this.tabSymbol.Controls.Add(this.string2_lbl);
            this.tabSymbol.Controls.Add(this.Indexcmb);
            this.tabSymbol.Controls.Add(this.label10);
            this.tabSymbol.Controls.Add(this.symbol_lbl);
            this.tabSymbol.Location = new System.Drawing.Point(4, 22);
            this.tabSymbol.Name = "tabSymbol";
            this.tabSymbol.Size = new System.Drawing.Size(395, 278);
            this.tabSymbol.TabIndex = 3;
            this.tabSymbol.Text = "Символ";
            this.tabSymbol.UseVisualStyleBackColor = true;
            this.tabSymbol.Click += new System.EventHandler(this.tabSymbol_Click);
            // 
            // calculateSymbol_btn
            // 
            this.calculateSymbol_btn.Location = new System.Drawing.Point(144, 243);
            this.calculateSymbol_btn.Name = "calculateSymbol_btn";
            this.calculateSymbol_btn.Size = new System.Drawing.Size(75, 23);
            this.calculateSymbol_btn.TabIndex = 11;
            this.calculateSymbol_btn.Text = "calculate";
            this.calculateSymbol_btn.UseVisualStyleBackColor = true;
            this.calculateSymbol_btn.Click += new System.EventHandler(this.calculateSymbol_btn_Click);
            // 
            // string2_lbl
            // 
            this.string2_lbl.AutoSize = true;
            this.string2_lbl.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.string2_lbl.Location = new System.Drawing.Point(118, 12);
            this.string2_lbl.Name = "string2_lbl";
            this.string2_lbl.Size = new System.Drawing.Size(133, 28);
            this.string2_lbl.TabIndex = 10;
            this.string2_lbl.Text = "Hello world!";
            // 
            // Indexcmb
            // 
            this.Indexcmb.FormattingEnabled = true;
            this.Indexcmb.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.Indexcmb.Location = new System.Drawing.Point(123, 74);
            this.Indexcmb.Name = "Indexcmb";
            this.Indexcmb.Size = new System.Drawing.Size(121, 21);
            this.Indexcmb.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Индекс";
            // 
            // symbol_lbl
            // 
            this.symbol_lbl.AutoSize = true;
            this.symbol_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symbol_lbl.Location = new System.Drawing.Point(158, 140);
            this.symbol_lbl.Name = "symbol_lbl";
            this.symbol_lbl.Size = new System.Drawing.Size(0, 29);
            this.symbol_lbl.TabIndex = 7;
            // 
            // tabLenght
            // 
            this.tabLenght.Controls.Add(this.calculateLenght_btn);
            this.tabLenght.Controls.Add(this.Resultlbl);
            this.tabLenght.Controls.Add(this.label12);
            this.tabLenght.Controls.Add(this.line_txtb);
            this.tabLenght.Location = new System.Drawing.Point(4, 22);
            this.tabLenght.Name = "tabLenght";
            this.tabLenght.Size = new System.Drawing.Size(395, 278);
            this.tabLenght.TabIndex = 4;
            this.tabLenght.Text = "Длина";
            this.tabLenght.UseVisualStyleBackColor = true;
            // 
            // calculateLenght_btn
            // 
            this.calculateLenght_btn.Location = new System.Drawing.Point(143, 241);
            this.calculateLenght_btn.Name = "calculateLenght_btn";
            this.calculateLenght_btn.Size = new System.Drawing.Size(75, 23);
            this.calculateLenght_btn.TabIndex = 12;
            this.calculateLenght_btn.Text = "calculate";
            this.calculateLenght_btn.UseVisualStyleBackColor = true;
            this.calculateLenght_btn.Click += new System.EventHandler(this.calculateLenght_btn_Click);
            // 
            // Resultlbl
            // 
            this.Resultlbl.AutoSize = true;
            this.Resultlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Resultlbl.Location = new System.Drawing.Point(159, 109);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(18, 25);
            this.Resultlbl.TabIndex = 11;
            this.Resultlbl.Text = " ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Строка ";
            // 
            // line_txtb
            // 
            this.line_txtb.Location = new System.Drawing.Point(112, 49);
            this.line_txtb.Name = "line_txtb";
            this.line_txtb.Size = new System.Drawing.Size(149, 20);
            this.line_txtb.TabIndex = 9;
            // 
            // tabDoublingVowels
            // 
            this.tabDoublingVowels.Controls.Add(this.DoublingVowels_btn);
            this.tabDoublingVowels.Controls.Add(this.result);
            this.tabDoublingVowels.Controls.Add(this.label14);
            this.tabDoublingVowels.Controls.Add(this.str1);
            this.tabDoublingVowels.Location = new System.Drawing.Point(4, 22);
            this.tabDoublingVowels.Name = "tabDoublingVowels";
            this.tabDoublingVowels.Size = new System.Drawing.Size(395, 278);
            this.tabDoublingVowels.TabIndex = 5;
            this.tabDoublingVowels.Text = "Удвоение гласных";
            this.tabDoublingVowels.UseVisualStyleBackColor = true;
            // 
            // DoublingVowels_btn
            // 
            this.DoublingVowels_btn.Location = new System.Drawing.Point(148, 242);
            this.DoublingVowels_btn.Name = "DoublingVowels_btn";
            this.DoublingVowels_btn.Size = new System.Drawing.Size(75, 23);
            this.DoublingVowels_btn.TabIndex = 15;
            this.DoublingVowels_btn.Text = "calculate";
            this.DoublingVowels_btn.UseVisualStyleBackColor = true;
            this.DoublingVowels_btn.Click += new System.EventHandler(this.DoublingVowels_btn_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(45, 130);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(15, 24);
            this.result.TabIndex = 14;
            this.result.Text = " ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(156, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Строка ";
            // 
            // str1
            // 
            this.str1.Location = new System.Drawing.Point(114, 58);
            this.str1.Name = "str1";
            this.str1.Size = new System.Drawing.Size(149, 20);
            this.str1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(419, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Калькулятор для строк";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabConcat.ResumeLayout(false);
            this.tabConcat.PerformLayout();
            this.tabReplace.ResumeLayout(false);
            this.tabReplace.PerformLayout();
            this.tabRemove.ResumeLayout(false);
            this.tabRemove.PerformLayout();
            this.tabSymbol.ResumeLayout(false);
            this.tabSymbol.PerformLayout();
            this.tabLenght.ResumeLayout(false);
            this.tabLenght.PerformLayout();
            this.tabDoublingVowels.ResumeLayout(false);
            this.tabDoublingVowels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabConcat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultStringlbl;
        private System.Windows.Forms.TextBox String2txtb;
        private System.Windows.Forms.TextBox String1txtb;
        private System.Windows.Forms.TabPage tabReplace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label String_lbl;
        private System.Windows.Forms.Label ReplaceResult_lbl;
        private System.Windows.Forms.TextBox newString_txtb;
        private System.Windows.Forms.TabPage tabRemove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label removeResult_lbl;
        private System.Windows.Forms.TabPage tabSymbol;
        private System.Windows.Forms.Label string2_lbl;
        private System.Windows.Forms.ComboBox Indexcmb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label symbol_lbl;
        private System.Windows.Forms.TabPage tabLenght;
        private System.Windows.Forms.TabPage tabDoublingVowels;
        private System.Windows.Forms.Button CalculateConcat_btn;
        private System.Windows.Forms.Button calculateReplace_btn;
        private System.Windows.Forms.Button calculateRemove_btn;
        private System.Windows.Forms.Button calculateSymbol_btn;
        private System.Windows.Forms.Button calculateLenght_btn;
        private System.Windows.Forms.Label Resultlbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox line_txtb;
        private System.Windows.Forms.Button DoublingVowels_btn;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox str1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox replacedString_txtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox count_txtb;
        private System.Windows.Forms.ComboBox index_cmb;
        private System.Windows.Forms.Button button1;
    }
}

