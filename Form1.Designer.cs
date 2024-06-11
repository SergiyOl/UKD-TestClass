
namespace UKD_TestClass
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_CreateTest = new System.Windows.Forms.Button();
            this.button_RedactTest = new System.Windows.Forms.Button();
            this.button_TakeTest = new System.Windows.Forms.Button();
            this.button_About = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(465, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "TestClass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(300, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ваш помічник у створенні та проходженні тестів";
            // 
            // button_CreateTest
            // 
            this.button_CreateTest.Location = new System.Drawing.Point(156, 335);
            this.button_CreateTest.Name = "button_CreateTest";
            this.button_CreateTest.Size = new System.Drawing.Size(200, 50);
            this.button_CreateTest.TabIndex = 2;
            this.button_CreateTest.Text = "Створити новий тест";
            this.button_CreateTest.UseVisualStyleBackColor = true;
            // 
            // button_RedactTest
            // 
            this.button_RedactTest.Location = new System.Drawing.Point(494, 335);
            this.button_RedactTest.Name = "button_RedactTest";
            this.button_RedactTest.Size = new System.Drawing.Size(200, 50);
            this.button_RedactTest.TabIndex = 3;
            this.button_RedactTest.Text = "Редагувати наявний тест";
            this.button_RedactTest.UseVisualStyleBackColor = true;
            // 
            // button_TakeTest
            // 
            this.button_TakeTest.Location = new System.Drawing.Point(813, 335);
            this.button_TakeTest.Name = "button_TakeTest";
            this.button_TakeTest.Size = new System.Drawing.Size(200, 50);
            this.button_TakeTest.TabIndex = 4;
            this.button_TakeTest.Text = "Пройти тест";
            this.button_TakeTest.UseVisualStyleBackColor = true;
            // 
            // button_About
            // 
            this.button_About.Location = new System.Drawing.Point(494, 565);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(200, 50);
            this.button_About.TabIndex = 5;
            this.button_About.Text = "Довідник";
            this.button_About.UseVisualStyleBackColor = true;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.button_TakeTest);
            this.Controls.Add(this.button_RedactTest);
            this.Controls.Add(this.button_CreateTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartPage";
            this.Text = "TestClass";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_CreateTest;
        private System.Windows.Forms.Button button_RedactTest;
        private System.Windows.Forms.Button button_TakeTest;
        private System.Windows.Forms.Button button_About;
    }
}

