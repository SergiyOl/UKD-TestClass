
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_ScrumbledQuestions = new System.Windows.Forms.CheckBox();
            this.checkBox_ScrumbledVariants = new System.Windows.Forms.CheckBox();
            this.textBox_TestName = new System.Windows.Forms.TextBox();
            this.textBox_GivenQuestionAmount = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва тесту:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Загальна кількість питань:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кількість заданих питань:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пароль редагування:";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Додати нове питання";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_ScrumbledVariants);
            this.Controls.Add(this.checkBox_ScrumbledQuestions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestRedactor";
            this.Text = "Редактор тестів";
            this.Shown += new System.EventHandler(this.TestRedactor_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_ScrumbledQuestions;
        private System.Windows.Forms.CheckBox checkBox_ScrumbledVariants;
        private System.Windows.Forms.TextBox textBox_TestName;
        private System.Windows.Forms.TextBox textBox_GivenQuestionAmount;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}