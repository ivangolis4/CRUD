namespace CRUD
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lbquantity = new Label();
            btnminus = new Button();
            btnplus = new Button();
            panelContainer = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(679, 322);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(100, 392);
            button1.Name = "button1";
            button1.Size = new Size(99, 46);
            button1.TabIndex = 1;
            button1.Text = "CREATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(249, 392);
            button2.Name = "button2";
            button2.Size = new Size(99, 46);
            button2.TabIndex = 2;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(419, 392);
            button3.Name = "button3";
            button3.Size = new Size(99, 46);
            button3.TabIndex = 3;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lbquantity
            // 
            lbquantity.AutoSize = true;
            lbquantity.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbquantity.Location = new Point(643, 393);
            lbquantity.Name = "lbquantity";
            lbquantity.Size = new Size(25, 30);
            lbquantity.TabIndex = 4;
            lbquantity.Text = "0";
            lbquantity.Click += lbquantity_Click;
            // 
            // btnminus
            // 
            btnminus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnminus.Location = new Point(610, 393);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(27, 34);
            btnminus.TabIndex = 5;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
            btnminus.Click += btnminus_Click;
            // 
            // btnplus
            // 
            btnplus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnplus.Location = new Point(674, 392);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(27, 34);
            btnplus.TabIndex = 6;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += btnplus_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(249, 75);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(259, 256);
            panelContainer.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContainer);
            Controls.Add(btnplus);
            Controls.Add(btnminus);
            Controls.Add(lbquantity);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lbquantity;
        private Button btnminus;
        private Button btnplus;
        private Panel panelContainer;
    }
}
