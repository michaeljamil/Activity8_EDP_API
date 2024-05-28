namespace Activity8_EDP
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
            dataGridView1 = new DataGridView();
            postBtn = new Button();
            getBtn = new Button();
            nameTxtbox = new TextBox();
            emailTxtbox = new TextBox();
            contentTxtbox = new TextBox();
            titleTxtbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(738, 199);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // postBtn
            // 
            postBtn.BackColor = Color.LightSalmon;
            postBtn.Location = new Point(352, 487);
            postBtn.Name = "postBtn";
            postBtn.Size = new Size(140, 46);
            postBtn.TabIndex = 2;
            postBtn.Text = "POST";
            postBtn.UseVisualStyleBackColor = false;
            postBtn.Click += postBtn_Click;
            // 
            // getBtn
            // 
            getBtn.BackColor = Color.LightSalmon;
            getBtn.Location = new Point(352, 261);
            getBtn.Name = "getBtn";
            getBtn.Size = new Size(140, 46);
            getBtn.TabIndex = 3;
            getBtn.Text = "GET";
            getBtn.UseVisualStyleBackColor = false;
            getBtn.Click += getBtn_Click;
            // 
            // nameTxtbox
            // 
            nameTxtbox.BorderStyle = BorderStyle.FixedSingle;
            nameTxtbox.Location = new Point(121, 371);
            nameTxtbox.Name = "nameTxtbox";
            nameTxtbox.Size = new Size(244, 27);
            nameTxtbox.TabIndex = 4;
            nameTxtbox.TextChanged += nameTxtbox_TextChanged;
            // 
            // emailTxtbox
            // 
            emailTxtbox.BorderStyle = BorderStyle.FixedSingle;
            emailTxtbox.Location = new Point(121, 426);
            emailTxtbox.Name = "emailTxtbox";
            emailTxtbox.Size = new Size(244, 27);
            emailTxtbox.TabIndex = 5;
            emailTxtbox.TextChanged += emailTxtbox_TextChanged;
            // 
            // contentTxtbox
            // 
            contentTxtbox.BorderStyle = BorderStyle.FixedSingle;
            contentTxtbox.Location = new Point(515, 426);
            contentTxtbox.Multiline = true;
            contentTxtbox.Name = "contentTxtbox";
            contentTxtbox.Size = new Size(244, 27);
            contentTxtbox.TabIndex = 6;
            contentTxtbox.TextChanged += contentTxtbox_TextChanged;
            // 
            // titleTxtbox
            // 
            titleTxtbox.BorderStyle = BorderStyle.FixedSingle;
            titleTxtbox.Location = new Point(515, 371);
            titleTxtbox.Name = "titleTxtbox";
            titleTxtbox.Size = new Size(244, 27);
            titleTxtbox.TabIndex = 6;
            titleTxtbox.TextChanged += titleTxtbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 373);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Name";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 428);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 378);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 9;
            label3.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 433);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 10;
            label4.Text = "Content";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(846, 573);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(titleTxtbox);
            Controls.Add(contentTxtbox);
            Controls.Add(emailTxtbox);
            Controls.Add(nameTxtbox);
            Controls.Add(getBtn);
            Controls.Add(postBtn);
            Controls.Add(dataGridView1);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDP Activity 8";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button postBtn;
        private Button getBtn;
        private TextBox nameTxtbox;
        private TextBox emailTxtbox;
        private TextBox contentTxtbox;
        private TextBox titleTxtbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
