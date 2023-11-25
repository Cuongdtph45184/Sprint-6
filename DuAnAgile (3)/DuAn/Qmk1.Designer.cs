namespace DuAn
{
    partial class Qmk1
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
            label1 = new Label();
            label3 = new Label();
            txtmkmoi1 = new TextBox();
            txtmkmoi2 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            mail1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 124);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Mật Khẩu Mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 166);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 0;
            label3.Text = "Xác Nhận Mật Khẩu";
            // 
            // txtmkmoi1
            // 
            txtmkmoi1.Location = new Point(161, 121);
            txtmkmoi1.Name = "txtmkmoi1";
            txtmkmoi1.Size = new Size(330, 23);
            txtmkmoi1.TabIndex = 1;
            // 
            // txtmkmoi2
            // 
            txtmkmoi2.Location = new Point(161, 163);
            txtmkmoi2.Name = "txtmkmoi2";
            txtmkmoi2.Size = new Size(330, 23);
            txtmkmoi2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(247, 220);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Tiếp Tục";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 78);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 0;
            label2.Text = "ĐIền lại mail";
            // 
            // mail1
            // 
            mail1.Location = new Point(161, 75);
            mail1.Name = "mail1";
            mail1.Size = new Size(330, 23);
            mail1.TabIndex = 1;
            // 
            // Qmk1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtmkmoi2);
            Controls.Add(mail1);
            Controls.Add(txtmkmoi1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Qmk1";
            Text = "Qmk1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtmkmoi1;
        private TextBox txtmkmoi2;
        private Button button1;
        private Label label2;
        private TextBox mail1;
    }
}