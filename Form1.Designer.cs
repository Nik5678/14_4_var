namespace _14_4_вариант
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtCount;
        private Label label1;
        private Button btnDraw;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtCount = new TextBox();
            label1 = new Label();
            btnDraw = new Button();
            SuspendLayout();
            // 
            // txtCount
            // 
            txtCount.Location = new Point(268, 39);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(88, 23);
            txtCount.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 1;
            label1.Text = "Число окружностей:";
            // 
            // btnDraw
            // 
            btnDraw.Location = new Point(268, 78);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(88, 22);
            btnDraw.TabIndex = 2;
            btnDraw.Text = "Нарисовать";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 375);
            Controls.Add(btnDraw);
            Controls.Add(label1);
            Controls.Add(txtCount);
            Name = "Form1";
            Text = "Диагональные окружности";
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
