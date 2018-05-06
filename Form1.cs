using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teleturniej
{
    public partial class Form1 : Form
    {
        Button button0 = null;
        User user = new User(0);
        Random rand = new Random();
        public Form1()
        {

            InitializeComponent();
            quizPanel.Hide();
            Questions q1 = new Questions("End the sentence: Ala has a...", "cat", new List<string> { "cat", "dog", "hamster", "ADHD", "rabbit", "fish" });
            Questions q2 = new Questions("2 x 2 = ", "4", new List<string> { "33", "6", "4", "20", "1", "7" });
            Questions q3 = new Questions("Apple's smartphones are called: ", "iPhone", new List<string> { "Galaxy", "iPhone", "iPad", "myPhone", "Lumia", "Xperia" });
            Questions q4 = new Questions("Microsoft has created an operating system. It is called...", "Windows", new List<string> { "Mac OS", "Windows", "Linux", "Andorid", "Symbian", "iOS" });
            user.set_of_quest.InsertRange(user.set_of_quest.Count, new List<Questions> { q1, q2, q3, q4 });
            button1.Click += new EventHandler(button0_MouseClick);
            button2.Click += new EventHandler(button0_MouseClick);
            button3.Click += new EventHandler(button0_MouseClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            this.Text = "Quiz";
            quizPanel.Show();
            button2_Click(sender, e);

        }

        private void AddAnsB_Click(object sender, EventArgs e)
        {
            List<string> newAnsw = new List<string>();
            newAnsw.InsertRange(newAnsw.Count, new string[] { ansTextBox.Text, ansTextBox2.Text, answer_box.Text, ansTextBox3.Text, ansTextBox4.Text });
            Questions quest = new Questions(question_textBox.Text, answer_box.Text, Randoms.ShuffleList(newAnsw));
            user.set_of_quest.Add(quest);
            ansTextBox2.Clear();
            ansTextBox3.Clear();
            ansTextBox4.Clear();
            answer_box.Clear();
            question_textBox.Clear();
            ansTextBox.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (user.currQuest != null)
            {
                if (button2.Text == user.currQuest.answer)
                {
                    user.points = user.points + 1;
                }
            }
            if (!user.set_of_quest.Any())
            {
                MessageBox.Show("Your score: " + user.points, "Score", MessageBoxButtons.OKCancel);


            }
            else
            {
                int randomIndex = rand.Next(0, user.set_of_quest.Count);
                user.currQuest = user.set_of_quest[randomIndex];
                LabelQ.Text = user.currQuest.question;
                button1.Text = user.currQuest.allAnswers[0];
                button2.Text = user.currQuest.allAnswers[1];
                button3.Text = user.currQuest.allAnswers[2];
        

                user.set_of_quest.RemoveAt(randomIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (user.currQuest != null)
            {
                if (button3.Text == user.currQuest.answer)
                {
                    user.points = user.points + 1;
                }
            }
            if (!user.set_of_quest.Any())
            {
                MessageBox.Show("Your score: " + user.points, "Score", MessageBoxButtons.OKCancel);

            }
            else
            {
                int randomIndex = rand.Next(0, user.set_of_quest.Count);
                user.currQuest = user.set_of_quest[randomIndex];
                LabelQ.Text = user.currQuest.question;
                button1.Text = user.currQuest.allAnswers[0];
                button2.Text = user.currQuest.allAnswers[1];
                button3.Text = user.currQuest.allAnswers[2];
               

                user.set_of_quest.RemoveAt(randomIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.currQuest != null)
            {
                if (button1.Text == user.currQuest.answer)
                {
                    user.points = user.points + 1;
                }
            }
            if (!user.set_of_quest.Any())
            {
                MessageBox.Show("Your score: " + user.points, "Score", MessageBoxButtons.OKCancel);

            }
            else
            {
                int randomIndex = rand.Next(0, user.set_of_quest.Count);
                user.currQuest = user.set_of_quest[randomIndex];
                LabelQ.Text = user.currQuest.question;
                button1.Text = user.currQuest.allAnswers[0];
                button2.Text = user.currQuest.allAnswers[1];
                button3.Text = user.currQuest.allAnswers[2];
               

                user.set_of_quest.RemoveAt(randomIndex);
            }
        }

        private void button0_MouseClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                button0 = (Button)sender;
            }
        }

        
        
    }
}
