namespace ManuallyThrowingCustomException
{
    partial class Form1
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 50);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Alef", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 94);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Product";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Alef", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 284);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 4;
            label4.Text = "Sell Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Alef", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 247);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 5;
            label5.Text = "Qty";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Alef", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 207);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 6;
            label6.Text = "Exp. Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Alef", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 172);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 7;
            label7.Text = "Mfg. Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Alef", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 134);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 8;
            label8.Text = "Category";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 280);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(111, 247);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(111, 130);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 23);
            textBox6.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Alef", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(334, 94);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 14;
            label3.Text = "Description";
            label3.Click += label3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(334, 112);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(239, 134);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(462, 246);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 16;
            button1.Text = "Add product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(71, 337);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(447, 101);
            dataGridView1.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(111, 172);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(111, 207);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 450);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox6;
        private Label label3;
        private RichTextBox richTextBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}
