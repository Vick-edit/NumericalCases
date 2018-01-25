namespace NumericalCasesClient
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
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Case = new System.Windows.Forms.ComboBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            this.SuspendLayout();
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Ж",
            "М",
            "С"});
            this.Gender.Location = new System.Drawing.Point(175, 103);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(75, 21);
            this.Gender.TabIndex = 1;
            this.Gender.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // Case
            // 
            this.Case.FormattingEnabled = true;
            this.Case.Items.AddRange(new object[] {
            "И",
            "Р",
            "Д",
            "В",
            "Т",
            "П"});
            this.Case.Location = new System.Drawing.Point(272, 103);
            this.Case.Name = "Case";
            this.Case.Size = new System.Drawing.Size(75, 21);
            this.Case.TabIndex = 2;
            this.Case.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Output.Location = new System.Drawing.Point(12, 208);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(364, 20);
            this.Output.TabIndex = 3;
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(13, 103);
            this.Number.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.Number.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(156, 20);
            this.Number.TabIndex = 4;
            this.Number.ThousandsSeparator = true;
            this.Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            this.Number.Validated += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Конвертировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Число текстом:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Род";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Падеж";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 312);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Case);
            this.Controls.Add(this.Gender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.ComboBox Case;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

