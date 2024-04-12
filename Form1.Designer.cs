namespace BluescreenSimulator
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            exit_button = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(340, 59);
            button1.TabIndex = 0;
            button1.Text = "Windows 10";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(12, 77);
            button2.Name = "button2";
            button2.Size = new Size(340, 59);
            button2.TabIndex = 1;
            button2.Text = "Windows 10 (happy)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(12, 142);
            button3.Name = "button3";
            button3.Size = new Size(340, 59);
            button3.TabIndex = 2;
            button3.Text = "Windows XP-7";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(12, 207);
            button4.Name = "button4";
            button4.Size = new Size(340, 59);
            button4.TabIndex = 3;
            button4.Text = "Windows 9x";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(12, 272);
            button5.Name = "button5";
            button5.Size = new Size(340, 59);
            button5.TabIndex = 4;
            button5.Text = "Windows 9x (System is busy)";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // exit_button
            // 
            exit_button.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            exit_button.Location = new Point(78, 348);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(201, 49);
            exit_button.TabIndex = 5;
            exit_button.Text = "Exit";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 407);
            Controls.Add(exit_button);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Bluescreen Simulator";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button exit_button;
    }
}
