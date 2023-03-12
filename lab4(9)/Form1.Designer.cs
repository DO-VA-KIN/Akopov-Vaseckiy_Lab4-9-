namespace lab4_9_
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
            LBInput = new ListBox();
            TBAdd = new TextBox();
            label1 = new Label();
            BtnAdd = new Button();
            LBLocal = new ListBox();
            LBIthernet = new ListBox();
            label2 = new Label();
            label3 = new Label();
            BtnSort = new Button();
            BtnClearLBInput = new Button();
            BtnClearLBLocal = new Button();
            BtnClearLBIthernet = new Button();
            SuspendLayout();
            // 
            // LBInput
            // 
            LBInput.ItemHeight = 20;
            LBInput.Location = new Point(13, 93);
            LBInput.Margin = new Padding(4, 3, 4, 3);
            LBInput.Name = "LBInput";
            LBInput.Size = new Size(969, 144);
            LBInput.TabIndex = 0;
            // 
            // TBAdd
            // 
            TBAdd.Location = new Point(15, 23);
            TBAdd.Name = "TBAdd";
            TBAdd.Size = new Size(807, 28);
            TBAdd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 3;
            label1.Text = "Входные строки";
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(828, 22);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(154, 29);
            BtnAdd.TabIndex = 4;
            BtnAdd.Text = "Добавить строку";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // LBLocal
            // 
            LBLocal.ItemHeight = 20;
            LBLocal.Location = new Point(13, 333);
            LBLocal.Margin = new Padding(4, 3, 4, 3);
            LBLocal.Name = "LBLocal";
            LBLocal.Size = new Size(969, 144);
            LBLocal.TabIndex = 5;
            // 
            // LBIthernet
            // 
            LBIthernet.ItemHeight = 20;
            LBIthernet.Location = new Point(12, 512);
            LBIthernet.Margin = new Padding(4, 3, 4, 3);
            LBIthernet.Name = "LBIthernet";
            LBIthernet.Size = new Size(969, 144);
            LBIthernet.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 310);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 7;
            label2.Text = "Локальные пути";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 489);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 8;
            label3.Text = "Интернет пути";
            // 
            // BtnSort
            // 
            BtnSort.Location = new Point(414, 264);
            BtnSort.Name = "BtnSort";
            BtnSort.Size = new Size(154, 29);
            BtnSort.TabIndex = 9;
            BtnSort.Text = "Сортировать";
            BtnSort.UseVisualStyleBackColor = true;
            BtnSort.Click += BtnSort_Click;
            // 
            // BtnClearLBInput
            // 
            BtnClearLBInput.Location = new Point(877, 66);
            BtnClearLBInput.Name = "BtnClearLBInput";
            BtnClearLBInput.Size = new Size(104, 29);
            BtnClearLBInput.TabIndex = 10;
            BtnClearLBInput.Text = "Очистить";
            BtnClearLBInput.UseVisualStyleBackColor = true;
            BtnClearLBInput.Click += BtnClearLBInput_Click;
            // 
            // BtnClearLBLocal
            // 
            BtnClearLBLocal.Location = new Point(877, 306);
            BtnClearLBLocal.Name = "BtnClearLBLocal";
            BtnClearLBLocal.Size = new Size(104, 29);
            BtnClearLBLocal.TabIndex = 11;
            BtnClearLBLocal.Text = "Очистить";
            BtnClearLBLocal.UseVisualStyleBackColor = true;
            BtnClearLBLocal.Click += BtnClearLBLocal_Click;
            // 
            // BtnClearLBIthernet
            // 
            BtnClearLBIthernet.Location = new Point(878, 485);
            BtnClearLBIthernet.Name = "BtnClearLBIthernet";
            BtnClearLBIthernet.Size = new Size(104, 29);
            BtnClearLBIthernet.TabIndex = 12;
            BtnClearLBIthernet.Text = "Очистить";
            BtnClearLBIthernet.UseVisualStyleBackColor = true;
            BtnClearLBIthernet.Click += BtnClearLBIthernet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 668);
            Controls.Add(BtnClearLBIthernet);
            Controls.Add(BtnClearLBLocal);
            Controls.Add(BtnClearLBInput);
            Controls.Add(BtnSort);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LBIthernet);
            Controls.Add(LBLocal);
            Controls.Add(BtnAdd);
            Controls.Add(label1);
            Controls.Add(TBAdd);
            Controls.Add(LBInput);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Лабораторная4";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LBInput;
        private TextBox TBAdd;
        private Label label1;
        private Button BtnAdd;
        private ListBox LBLocal;
        private ListBox LBIthernet;
        private Label label2;
        private Label label3;
        private Button BtnSort;
        private Button BtnClearLBInput;
        private Button BtnClearLBLocal;
        private Button BtnClearLBIthernet;
    }
}