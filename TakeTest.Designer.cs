
namespace UKD_TestClass
{
    partial class TakeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeTest));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_Back = new System.Windows.Forms.Button();
            this.label_TestName = new System.Windows.Forms.Label();
            this.label_QuestionAmount = new System.Windows.Forms.Label();
            this.button_StartTest = new System.Windows.Forms.Button();
            this.button_Previous = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_EndTest = new System.Windows.Forms.Button();
            this.label_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(42, 40);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(206, 40);
            this.button_Back.TabIndex = 16;
            this.button_Back.Text = "Назад в меню";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // label_TestName
            // 
            this.label_TestName.AutoSize = true;
            this.label_TestName.Location = new System.Drawing.Point(39, 115);
            this.label_TestName.Name = "label_TestName";
            this.label_TestName.Size = new System.Drawing.Size(96, 17);
            this.label_TestName.TabIndex = 17;
            this.label_TestName.Text = "Назва тесту: ";
            // 
            // label_QuestionAmount
            // 
            this.label_QuestionAmount.AutoSize = true;
            this.label_QuestionAmount.Location = new System.Drawing.Point(39, 152);
            this.label_QuestionAmount.Name = "label_QuestionAmount";
            this.label_QuestionAmount.Size = new System.Drawing.Size(124, 17);
            this.label_QuestionAmount.TabIndex = 18;
            this.label_QuestionAmount.Text = "Кількість питань: ";
            // 
            // button_StartTest
            // 
            this.button_StartTest.Location = new System.Drawing.Point(42, 200);
            this.button_StartTest.Name = "button_StartTest";
            this.button_StartTest.Size = new System.Drawing.Size(206, 40);
            this.button_StartTest.TabIndex = 19;
            this.button_StartTest.Text = "Розпочати тест";
            this.button_StartTest.UseVisualStyleBackColor = true;
            this.button_StartTest.Click += new System.EventHandler(this.button_StartTest_Click);
            // 
            // button_Previous
            // 
            this.button_Previous.Location = new System.Drawing.Point(42, 621);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(206, 40);
            this.button_Previous.TabIndex = 20;
            this.button_Previous.Text = "Попереднє питання";
            this.button_Previous.UseVisualStyleBackColor = true;
            this.button_Previous.Visible = false;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(318, 621);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(206, 40);
            this.button_Next.TabIndex = 21;
            this.button_Next.Text = "Наступне питання";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Visible = false;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_EndTest
            // 
            this.button_EndTest.Location = new System.Drawing.Point(318, 621);
            this.button_EndTest.Name = "button_EndTest";
            this.button_EndTest.Size = new System.Drawing.Size(206, 40);
            this.button_EndTest.TabIndex = 22;
            this.button_EndTest.Text = "Завершити тест";
            this.button_EndTest.UseVisualStyleBackColor = true;
            this.button_EndTest.Visible = false;
            this.button_EndTest.Click += new System.EventHandler(this.button_EndTest_Click);
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(39, 115);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(84, 17);
            this.label_Result.TabIndex = 23;
            this.label_Result.Text = "Результат: ";
            this.label_Result.Visible = false;
            // 
            // TakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.button_EndTest);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Previous);
            this.Controls.Add(this.button_StartTest);
            this.Controls.Add(this.label_QuestionAmount);
            this.Controls.Add(this.label_TestName);
            this.Controls.Add(this.button_Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TakeTest";
            this.Text = "Проходження тесту";
            this.Shown += new System.EventHandler(this.TakeTest_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Label label_TestName;
        private System.Windows.Forms.Label label_QuestionAmount;
        private System.Windows.Forms.Button button_StartTest;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_EndTest;
        private System.Windows.Forms.Label label_Result;
    }
}