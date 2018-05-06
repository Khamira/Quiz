namespace Teleturniej
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddAnsB = new System.Windows.Forms.Button();
            this.question_textBox = new System.Windows.Forms.TextBox();
            this.ansTextBox = new System.Windows.Forms.TextBox();
            this.TestButton = new System.Windows.Forms.Button();
            this.enterQlab = new System.Windows.Forms.Label();
            this.enterAnslab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ansTextBox2 = new System.Windows.Forms.TextBox();
            this.ansTextBox3 = new System.Windows.Forms.TextBox();
            this.ansTextBox4 = new System.Windows.Forms.TextBox();
            this.answer_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelQ = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.quizPanel = new System.Windows.Forms.Panel();
            this.quizPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddAnsB
            // 
            this.AddAnsB.Location = new System.Drawing.Point(147, 329);
            this.AddAnsB.Name = "AddAnsB";
            this.AddAnsB.Size = new System.Drawing.Size(353, 44);
            this.AddAnsB.TabIndex = 1;
            this.AddAnsB.Text = "Add";
            this.AddAnsB.UseVisualStyleBackColor = true;
            this.AddAnsB.Click += new System.EventHandler(this.AddAnsB_Click);
            // 
            // question_textBox
            // 
            this.question_textBox.Location = new System.Drawing.Point(49, 188);
            this.question_textBox.Name = "question_textBox";
            this.question_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.question_textBox.Size = new System.Drawing.Size(214, 20);
            this.question_textBox.TabIndex = 2;
            // 
            // ansTextBox
            // 
            this.ansTextBox.Location = new System.Drawing.Point(392, 169);
            this.ansTextBox.Name = "ansTextBox";
            this.ansTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ansTextBox.Size = new System.Drawing.Size(214, 20);
            this.ansTextBox.TabIndex = 3;
            // 
            // TestButton
            // 
            this.TestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TestButton.Location = new System.Drawing.Point(233, 434);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(173, 64);
            this.TestButton.TabIndex = 4;
            this.TestButton.Text = "TEST";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // enterQlab
            // 
            this.enterQlab.AutoSize = true;
            this.enterQlab.Location = new System.Drawing.Point(72, 162);
            this.enterQlab.Name = "enterQlab";
            this.enterQlab.Size = new System.Drawing.Size(162, 13);
            this.enterQlab.TabIndex = 9;
            this.enterQlab.Text = "Enter your custom question here:";
            // 
            // enterAnslab
            // 
            this.enterAnslab.AutoSize = true;
            this.enterAnslab.Location = new System.Drawing.Point(419, 144);
            this.enterAnslab.Name = "enterAnslab";
            this.enterAnslab.Size = new System.Drawing.Size(161, 13);
            this.enterAnslab.TabIndex = 10;
            this.enterAnslab.Text = "Enter your custom answers here:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 88);
            this.label1.TabIndex = 11;
            this.label1.Text = "MAKE YOUR OWN \r\n            QUIZ";
            // 
            // ansTextBox2
            // 
            this.ansTextBox2.Location = new System.Drawing.Point(392, 204);
            this.ansTextBox2.Name = "ansTextBox2";
            this.ansTextBox2.Size = new System.Drawing.Size(213, 20);
            this.ansTextBox2.TabIndex = 12;
            // 
            // ansTextBox3
            // 
            this.ansTextBox3.Location = new System.Drawing.Point(392, 242);
            this.ansTextBox3.Name = "ansTextBox3";
            this.ansTextBox3.Size = new System.Drawing.Size(213, 20);
            this.ansTextBox3.TabIndex = 13;
            // 
            // ansTextBox4
            // 
            this.ansTextBox4.Location = new System.Drawing.Point(392, 277);
            this.ansTextBox4.Name = "ansTextBox4";
            this.ansTextBox4.Size = new System.Drawing.Size(214, 20);
            this.ansTextBox4.TabIndex = 14;
            // 
            // answer_box
            // 
            this.answer_box.Location = new System.Drawing.Point(49, 261);
            this.answer_box.Name = "answer_box";
            this.answer_box.Size = new System.Drawing.Size(214, 20);
            this.answer_box.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter right answer here:";
            // 
            // LabelQ
            // 
            this.LabelQ.AutoSize = true;
            this.LabelQ.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelQ.Location = new System.Drawing.Point(70, 110);
            this.LabelQ.Name = "LabelQ";
            this.LabelQ.Size = new System.Drawing.Size(184, 25);
            this.LabelQ.TabIndex = 0;
            this.LabelQ.Text = "QUESTION HERE";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(36, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(234, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(441, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // quizPanel
            // 
            this.quizPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quizPanel.BackgroundImage")));
            this.quizPanel.Controls.Add(this.button3);
            this.quizPanel.Controls.Add(this.button2);
            this.quizPanel.Controls.Add(this.button1);
            this.quizPanel.Controls.Add(this.LabelQ);
            this.quizPanel.Location = new System.Drawing.Point(1, 1);
            this.quizPanel.Name = "quizPanel";
            this.quizPanel.Size = new System.Drawing.Size(654, 561);
            this.quizPanel.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 560);
            this.Controls.Add(this.quizPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answer_box);
            this.Controls.Add(this.ansTextBox4);
            this.Controls.Add(this.ansTextBox3);
            this.Controls.Add(this.ansTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterAnslab);
            this.Controls.Add(this.enterQlab);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.ansTextBox);
            this.Controls.Add(this.question_textBox);
            this.Controls.Add(this.AddAnsB);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Quiz Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.quizPanel.ResumeLayout(false);
            this.quizPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddAnsB;
        private System.Windows.Forms.TextBox question_textBox;
        private System.Windows.Forms.TextBox ansTextBox;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Label enterQlab;
        private System.Windows.Forms.Label enterAnslab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ansTextBox2;
        private System.Windows.Forms.TextBox ansTextBox3;
        private System.Windows.Forms.TextBox ansTextBox4;
        private System.Windows.Forms.TextBox answer_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelQ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel quizPanel;

    }
}

