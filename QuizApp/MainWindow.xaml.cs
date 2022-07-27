using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int qNum = 0;

        int i;

        int score;

        public MainWindow()
        {
            InitializeComponent();
            StartGame();
            NextQuestions();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButtom = sender as Button;
            if (senderButtom.Tag.ToString() == "1")
            {
                score++;
            }
             
            if (qNum < 0)
            {
                qNum = 0;
            } else
            {
                qNum++;
            }

            ScoreText.Content = "Answerd correctly " + score + "/" + questionNumbers.Count;

            NextQuestions();
        }

        private void RestartGame()
        {
            score = 0;
            qNum = -1;
            i = 0;
            StartGame();
        }

        private void NextQuestions()
        {

            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            } else
            {
                RestartGame();
            }

            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.WhiteSmoke;

            }

            switch (i)
            {
                case 1 :
                    txtQuestions.Text = "Question 1";

                    ans1.Content = "Ans 1";
                    ans2.Content = "Ans 2 C";
                    ans3.Content = "Ans 3";
                    ans4.Content = "Ans 4";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/1.jpg"));
                    break;

                case 2:
                    txtQuestions.Text = "Question 2";

                    ans1.Content = "Ans 1 C";
                    ans2.Content = "Ans 2";
                    ans3.Content = "Ans 3";
                    ans4.Content = "Ans 4";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/2.jpg"));
                    break;

                case 3:
                    txtQuestions.Text = "Question 3";

                    ans1.Content = "Ans 1";
                    ans2.Content = "Ans 2";
                    ans3.Content = "Ans 3";
                    ans4.Content = "Ans 4 c";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/3.jpg"));
                    break;

                case 4:
                    txtQuestions.Text = "Question 2";

                    ans1.Content = "Ans 1";
                    ans2.Content = "Ans 2";
                    ans3.Content = "Ans 3";
                    ans4.Content = "Ans 4 c";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/4.jpg"));
                    break;

                case 5:
                    txtQuestions.Text = "Question 2";

                    ans1.Content = "Ans 1";
                    ans2.Content = "Ans 2";
                    ans3.Content = "Ans 3";
                    ans4.Content = "Ans 4 c";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/5.jpg"));
                    break;

                case 6:
                    txtQuestions.Text = "Question 2";

                    ans1.Content = "Ans 1";
                    ans2.Content = "Ans 2";
                    ans3.Content = "Ans 3";
                    ans4.Content = "Ans 4 c";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/6.jpg"));
                    break;

                case 7:
                    txtQuestions.Text = "Question 2";

                    ans1.Content = "Ans 1";
                    ans2.Content = "Ans 2";
                    ans3.Content = "Ans 3";
                    ans4.Content = "Ans 4 c";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/7.jpg"));
                    break;

                case 8:
                    txtQuestions.Text = "Question 2";

                    ans1.Content = "Ans 1";
                    ans2.Content = "Ans 2";
                    ans3.Content = "Ans 3";
                    ans4.Content = "Ans 4 c";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/8.jpg"));
                    break;

                case 9:
                    txtQuestions.Text = "Question 2";

                    ans1.Content = "Ans 1";
                    ans2.Content = "Ans 2";
                    ans3.Content = "Ans 3";
                    ans4.Content = "Ans 4 c";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/9.jpg"));
                    break;

                case 10:
                    txtQuestions.Text = "Question 2";

                    ans1.Content = "Ans 1";
                    ans2.Content = "Ans 2";
                    ans3.Content = "Ans 3";
                    ans4.Content = "Ans 4 c";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/10.jpg"));
                    break;

            }







        }

        private void StartGame()
        {
        
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();
            
            questionNumbers = randomList;

            QuestionOrder.Content = null;

            for (int i = 0; i < questionNumbers.Count; i++)
            {
                QuestionOrder.Content += " " + questionNumbers[i].ToString();
            }
        }


    }
}
