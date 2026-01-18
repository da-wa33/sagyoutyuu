namespace 作業中
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Start = new Button();
            Stop = new Button();
            detailBox = new TextBox();
            stateBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Update = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Start
            // 
            Start.Location = new Point(11, 338);
            Start.Name = "Start";
            Start.Size = new Size(114, 62);
            Start.TabIndex = 0;
            Start.Text = "作業開始";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(144, 338);
            Stop.Name = "Stop";
            Stop.Size = new Size(114, 62);
            Stop.TabIndex = 1;
            Stop.Text = "作業終了";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // detailBox
            // 
            detailBox.Location = new Point(20, 41);
            detailBox.Name = "detailBox";
            detailBox.Size = new Size(349, 27);
            detailBox.TabIndex = 2;
            // 
            // stateBox
            // 
            stateBox.Location = new Point(20, 121);
            stateBox.Name = "stateBox";
            stateBox.Size = new Size(349, 27);
            stateBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 4;
            label1.Text = "作業内容";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 98);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 5;
            label2.Text = "ステータス";
            // 
            // Update
            // 
            Update.Location = new Point(298, 338);
            Update.Name = "Update";
            Update.Size = new Size(114, 62);
            Update.TabIndex = 6;
            Update.Text = "内容の更新";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(11, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 151);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Help - このように表示されます";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 26);
            label3.Name = "label3";
            label3.Size = new Size(129, 60);
            label3.TabIndex = 9;
            label3.Text = "入力してない\r\n内容はその項目だけ\r\n非表示になります\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 426);
            Controls.Add(groupBox1);
            Controls.Add(Update);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(stateBox);
            Controls.Add(detailBox);
            Controls.Add(Stop);
            Controls.Add(Start);
            Name = "Form1";
            ShowIcon = false;
            Text = "作業中....";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Start;
        private Button Stop;
        private TextBox detailBox;
        private TextBox stateBox;
        private Label label1;
        private Label label2;
        private Button Update;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}
