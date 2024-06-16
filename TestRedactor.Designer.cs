
namespace UKD_TestClass
{
    partial class TestRedactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestRedactor));
            this.label_TestName = new System.Windows.Forms.Label();
            this.label_QuestionAmount = new System.Windows.Forms.Label();
            this.label_QuestionAmountCounter = new System.Windows.Forms.Label();
            this.label_GivenQuestionAmount = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.checkBox_ScrumbledQuestions = new System.Windows.Forms.CheckBox();
            this.checkBox_ScrumbledVariants = new System.Windows.Forms.CheckBox();
            this.textBox_TestName = new System.Windows.Forms.TextBox();
            this.textBox_GivenQuestionAmount = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_AddNewQuestion = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label_TestName
            // 
            this.label_TestName.AutoSize = true;
            this.label_TestName.Location = new System.Drawing.Point(60, 40);
            this.label_TestName.Name = "label_TestName";
            this.label_TestName.Size = new System.Drawing.Size(92, 17);
            this.label_TestName.TabIndex = 0;
            this.label_TestName.Text = "Назва тесту:";
            // 
            // label_QuestionAmount
            // 
            this.label_QuestionAmount.AutoSize = true;
            this.label_QuestionAmount.Location = new System.Drawing.Point(60, 100);
            this.label_QuestionAmount.Name = "label_QuestionAmount";
            this.label_QuestionAmount.Size = new System.Drawing.Size(183, 17);
            this.label_QuestionAmount.TabIndex = 1;
            this.label_QuestionAmount.Text = "Загальна кількість питань:";
            // 
            // label_QuestionAmountCounter
            // 
            this.label_QuestionAmountCounter.AutoSize = true;
            this.label_QuestionAmountCounter.Location = new System.Drawing.Point(250, 100);
            this.label_QuestionAmountCounter.Name = "label_QuestionAmountCounter";
            this.label_QuestionAmountCounter.Size = new System.Drawing.Size(16, 17);
            this.label_QuestionAmountCounter.TabIndex = 2;
            this.label_QuestionAmountCounter.Text = "0";
            // 
            // label_GivenQuestionAmount
            // 
            this.label_GivenQuestionAmount.AutoSize = true;
            this.label_GivenQuestionAmount.Location = new System.Drawing.Point(60, 160);
            this.label_GivenQuestionAmount.Name = "label_GivenQuestionAmount";
            this.label_GivenQuestionAmount.Size = new System.Drawing.Size(177, 17);
            this.label_GivenQuestionAmount.TabIndex = 3;
            this.label_GivenQuestionAmount.Text = "Кількість заданих питань:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(60, 220);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(148, 17);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "Пароль редагування:";
            // 
            // checkBox_ScrumbledQuestions
            // 
            this.checkBox_ScrumbledQuestions.AutoSize = true;
            this.checkBox_ScrumbledQuestions.Location = new System.Drawing.Point(500, 100);
            this.checkBox_ScrumbledQuestions.Name = "checkBox_ScrumbledQuestions";
            this.checkBox_ScrumbledQuestions.Size = new System.Drawing.Size(169, 21);
            this.checkBox_ScrumbledQuestions.TabIndex = 8;
            this.checkBox_ScrumbledQuestions.Text = "Перемішення питань";
            this.checkBox_ScrumbledQuestions.UseVisualStyleBackColor = true;
            // 
            // checkBox_ScrumbledVariants
            // 
            this.checkBox_ScrumbledVariants.AutoSize = true;
            this.checkBox_ScrumbledVariants.Location = new System.Drawing.Point(500, 160);
            this.checkBox_ScrumbledVariants.Name = "checkBox_ScrumbledVariants";
            this.checkBox_ScrumbledVariants.Size = new System.Drawing.Size(182, 21);
            this.checkBox_ScrumbledVariants.TabIndex = 9;
            this.checkBox_ScrumbledVariants.Text = "Перемішення варіантів";
            this.checkBox_ScrumbledVariants.UseVisualStyleBackColor = true;
            // 
            // textBox_TestName
            // 
            this.textBox_TestName.Location = new System.Drawing.Point(158, 40);
            this.textBox_TestName.Name = "textBox_TestName";
            this.textBox_TestName.Size = new System.Drawing.Size(200, 22);
            this.textBox_TestName.TabIndex = 12;
            // 
            // textBox_GivenQuestionAmount
            // 
            this.textBox_GivenQuestionAmount.Location = new System.Drawing.Point(243, 157);
            this.textBox_GivenQuestionAmount.Name = "textBox_GivenQuestionAmount";
            this.textBox_GivenQuestionAmount.Size = new System.Drawing.Size(115, 22);
            this.textBox_GivenQuestionAmount.TabIndex = 13;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(214, 220);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(144, 22);
            this.textBox_Password.TabIndex = 14;
            // 
            // button_AddNewQuestion
            // 
            this.button_AddNewQuestion.Location = new System.Drawing.Point(60, 285);
            this.button_AddNewQuestion.Name = "button_AddNewQuestion";
            this.button_AddNewQuestion.Size = new System.Drawing.Size(206, 40);
            this.button_AddNewQuestion.TabIndex = 0;
            this.button_AddNewQuestion.Text = "Додати нове питання";
            this.button_AddNewQuestion.UseVisualStyleBackColor = true;
            this.button_AddNewQuestion.Click += new System.EventHandler(this.button_AddNewQuestion_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(500, 31);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(206, 40);
            this.button_Back.TabIndex = 15;
            this.button_Back.Text = "Назад в меню";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(745, 31);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(206, 40);
            this.button_Save.TabIndex = 16;
            this.button_Save.Text = "Зберегти тест";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TestRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_GivenQuestionAmount);
            this.Controls.Add(this.textBox_TestName);
            this.Controls.Add(this.button_AddNewQuestion);
            this.Controls.Add(this.checkBox_ScrumbledVariants);
            this.Controls.Add(this.checkBox_ScrumbledQuestions);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_GivenQuestionAmount);
            this.Controls.Add(this.label_QuestionAmountCounter);
            this.Controls.Add(this.label_QuestionAmount);
            this.Controls.Add(this.label_TestName);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestRedactor";
            this.Text = "Редактор тестів";
            this.Shown += new System.EventHandler(this.TestRedactor_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TestName;
        private System.Windows.Forms.Label label_QuestionAmount;
        private System.Windows.Forms.Label label_QuestionAmountCounter;
        private System.Windows.Forms.Label label_GivenQuestionAmount;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.CheckBox checkBox_ScrumbledQuestions;
        private System.Windows.Forms.CheckBox checkBox_ScrumbledVariants;
        private System.Windows.Forms.TextBox textBox_TestName;
        private System.Windows.Forms.TextBox textBox_GivenQuestionAmount;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_AddNewQuestion;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}