using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Rulet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int numbers = 37;
        private const int drawnNumbers = 4;
        private const int columns = 3;
        private const int rows = 3;
        private const int colors = 2;
        private const int evens = 2;
        private const int halfs = 2;
        private const int columnLimit = 18;
        private Storyboard sb;
        private DispatcherTimer timer1;
        private DispatcherTimer timer2;
        private DispatcherTimer timer3;
        private int chip;
        private bool selectchip1;
        private bool selectchip2;
        private bool selectchip3;
        private bool selectchip4;
        private int drawnNumber;
        private int totalAmount;
        private int betAmount;
        private int winAmount;
        private SoundPlayer player;
        private SoundPlayer player1;
        private List<Label> drawnNumbersLabels;
        private List<Label> numbersOnBoardlabels;
        private List<int> sums,sumsColor, sumsEven, sumsColumn, sumsHalf, sumsRows;
        private Dictionary<Label, int> mappedLabels;
        private List<Image> chipImage;
        private VariablePaytable paytable;
        private int[] multiplicator;

        public MainWindow()
        {

            

            InitializeComponent();
            paytable = ConfigurationLoader.getInstance().getPaytable();
            multiplicator = new int[37];
            numbersOnBoardlabels = new List<Label>();
            sums = new List<int>();
            sumsEven = new List<int>();
            sumsColumn = new List<int>();
            sumsHalf = new List<int>();
            sumsColor = new List<int>();
            sumsRows = new List<int>();
            drawnNumbersLabels = new List<Label>();
            mappedLabels = new Dictionary<Label, int>();
            for (int i = 0; i<numbers;i++)
            {
                var label = this.FindName("labelN" + i);
                mappedLabels.Add((label as Label), i);
                numbersOnBoardlabels.Add((label as Label));
                sums.Add(0);
                (label as Label).MouseLeftButtonDown += newClick;
            }

            for (int i = 0; i<columns; i++)
            {
                var label = this.FindName("labelColumn" + i);
                mappedLabels.Add((label as Label), i);
                sumsColumn.Add(0);
                (label as Label).MouseLeftButtonDown += clickColumn;
            }
            for (int i = 0; i < halfs; i++)
            {
                var label = this.FindName("labelHalf" + i);
                mappedLabels.Add((label as Label), i);
                sumsHalf.Add(0);
                (label as Label).MouseLeftButtonDown += clickHalf;
            }
            for (int i = 0; i < evens; i++)
            {
                var label = this.FindName("labelEven" + i);
                mappedLabels.Add((label as Label), i);
                sumsEven.Add(0);
                (label as Label).MouseLeftButtonDown += clickEven;
            }
            for (int i = 0; i < colors; i++)
            {
                var label = this.FindName("labelColor" + i);
                mappedLabels.Add((label as Label), i);
                sumsColor.Add(0);
                (label as Label).MouseLeftButtonDown += clickColor;
            }
            for (int i = 0; i < rows; i++)
            {
                var label = this.FindName("labelRow" + i);
                mappedLabels.Add((label as Label), i);
                sumsRows.Add(0);
                (label as Label).MouseLeftButtonDown += clickRow;
            }
            for (int i = 0; i < drawnNumbers; i++)
            {
                var label = this.FindName("labelIN" + (i+1));
                drawnNumbersLabels.Add((label as Label));
            }

            Loaded += new RoutedEventHandler(pauseWheel);
            chip = 0;
            selectchip1 = false;
            selectchip2 = false;
            selectchip3 = false;
            selectchip4 = false;
           
            drawnNumber = 0;
            
            totalAmount = 10000;
            betAmount = 0;
            winAmount = 0;
            setCash();
            BetCash();
            ball.Visibility = Visibility.Hidden;
        }

        private void clickRow(object sender, MouseButtonEventArgs e)
        {
            Label label = (sender as Label);
            int position = mappedLabels[label];
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sumsRows[position] += chip;
                label.Content = sumsRows[position].ToString();
                betAmount += chip;
                totalAmount -= chip;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void clickColor(object sender, MouseButtonEventArgs e)
        {
            Label label = (sender as Label);
            int position = mappedLabels[label];
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sumsColor[position] += chip;
                label.Content = sumsColor[position].ToString();
                betAmount += chip;
                totalAmount -= chip;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void clickEven(object sender, MouseButtonEventArgs e)
        {
            Label label = (sender as Label);
            int position = mappedLabels[label];
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sumsEven[position] += chip;
                label.Content = sumsEven[position].ToString();
                betAmount += chip;
                totalAmount -= chip;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void clickHalf(object sender, MouseButtonEventArgs e)
        {
            Label label = (sender as Label);
            int position = mappedLabels[label];
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sumsHalf[position] += chip;
                label.Content = sumsHalf[position].ToString();
                betAmount += chip;
                totalAmount -= chip;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void clickColumn(object sender, MouseButtonEventArgs e)
        {
            Label label = (sender as Label);
            int position = mappedLabels[label];
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sumsColumn[position] += chip;
                label.Content = sumsColumn[position].ToString();
                betAmount += chip;
                totalAmount -= chip;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void newClick(object sender, MouseButtonEventArgs e)
        {
            Label label = (sender as Label);
            int position = mappedLabels[label];
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sums[position] += chip;
                label.Content = sums[position].ToString();
                betAmount += chip;
                totalAmount -= chip;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();

        }

        public void setCash()
        {
            labelCash.Content = totalAmount.ToString();
        }
        public void BetCash()
        {
            betCash.Content = betAmount.ToString();
            
            labelCash.Content = totalAmount.ToString();
            
        }
        
        public int getNumber()
        {
            int number;
            Random random = new Random();
            number = random.Next(0, 36);
            return number;
        }

        
        public void pauseWheel(object sender, RoutedEventArgs e)
        {
            sb = this.FindResource("Storyboard1") as Storyboard;
           
            sb.Begin();
            sb.Stop();
        }

        
        public void StopWheel()
        {
           
            drawnNumber = getNumber();
            Random random = new Random();
            multiplicator = paytable.GenerateVariableOdds(random.Next(4));
            for (int i = 0;i<multiplicator.Length;i++)
            {
                numbersOnBoardlabels[i].Content = ("x" + multiplicator[i]).ToString();
            }


            sb.Begin();
            timer1 = new DispatcherTimer();
                timer1.Tick += timer1_tick;

           
            switch (drawnNumber)
            {
                case 0:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num0);
                    break;
                case 1:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num1);
                    break;
                case 2:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num2);
                    break;
                case 3:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num3);
                    break;
                case 4:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num4);
                    break;
                case 5:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num5);
                    break;
                case 6:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num6);
                    break;
                case 7:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num7);
                    break;
                case 8:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num8);
                    break;
                case 9:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num9);
                    break;
                case 10:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num10);
                    break;
                case 11:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num11);
                    break;
                case 12:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num12);
                    break;
                case 13:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num13);
                    break;
                case 14:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num14);
                    break;
                case 15:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num15);
                    break;
                case 16:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num16);
                    break;
                case 17:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num17);
                    break;
                case 18:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num18);
                    break;
                case 19:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num19);
                    break;
                case 20:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num20);
                    break;
                case 21:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num21);
                    break;
                case 22:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num22);
                    break;
                case 23:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num23);
                    break;
                case 24:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num24);
                    break;
                case 25:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num25);
                    break;
                case 26:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num26);
                    break;
                case 27:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num27);
                    break;
                case 28:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num28);
                    break;
                case 29:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num29);
                    break;
                case 30:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num30);
                    break;
                case 31:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num31);
                    break;
                case 32:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num32);
                    break;
                case 33:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num33);
                    break;
                case 34:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num34);
                    break;
                case 35:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num35);
                    break;
                case 36:
                    timer1.Interval = TimeSpan.FromSeconds(Constants.num36);
                    break;
                default:
                    break;


            }
            timer1.Start();

        }
        
        public void timer1_tick(object sender, EventArgs e)
        {

            sb.Pause();
            timer2 = new DispatcherTimer();
            timer2.Tick += timer2_tick;
            timer2.Interval = TimeSpan.FromSeconds(4);
            timer2.Start();
            timer1.Stop();
            for (int i = 3; i >= 1; i--)
            {
                if (drawnNumbersLabels[i - 1].Content != null && drawnNumbersLabels[i - 1].Content.ToString().Length > 0)
                    drawnNumbersLabels[i].Content = drawnNumbersLabels[i - 1].Content.ToString();
            }
            drawnNumbersLabels[0].Content = drawnNumber.ToString();
            
            getMoney();
        }
        
        public void timer2_tick(object sender, EventArgs e)
        {
            ball.Visibility = Visibility.Hidden;
            sb.Begin();
            sb.Stop();
            sb.Seek(TimeSpan.Zero);
            sb.Pause();
            timer2.Stop();
        }
        
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ball.Visibility = Visibility.Visible;
            StopWheel();
            timer3 = new DispatcherTimer();
            timer3.Tick += timer3_tick;
            timer3.Interval = TimeSpan.FromSeconds(16);
            timer3.Start();
            disableAll();
            player = new SoundPlayer(Rulet.Sounds.Resource1.no_more_bets);
            player.Play();
          
        }
        

        public void timer3_tick(object sender, EventArgs e)
        {
            timer3.Stop();
            ClearAllBet();
            enableAll();
            
        }


        private void Picture1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            chip = 1;
            selectchip1 = true;
            selectchip2 = false;
            selectchip3 = false;
            selectchip4 = false;

            Canvas canvas = sender as Canvas;
            Image img = sender as Image;
            
            Border bdr = new Border();
            if (selectchip1)
            {
                bdr.Visibility = Visibility.Visible;
                c1.Visibility = Visibility.Visible;
                c2.Visibility = Visibility.Hidden;
                c3.Visibility = Visibility.Hidden;
                c4.Visibility = Visibility.Hidden;
            }
            
            bdr.BorderBrush = Brushes.Red;
            bdr.BorderThickness = new Thickness(5);
            bdr.Width = img.Width;
            bdr.Height = img.Height;
            if (c1.Children.Contains(canvas))
            {
                c1.Children.Remove(canvas);
                bdr.Child = img;
            }
            c1.Children.Add(bdr);
            
        }

        private void Picture2_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            chip = 5;
            selectchip1 = false;
            selectchip2 = true;
            selectchip3 = false;
            selectchip4 = false;
            Canvas canvas = sender as Canvas;
            Image img = sender as Image;

            Border bdr = new Border();
            if (selectchip2)
            {
                bdr.Visibility = Visibility.Visible;
                c2.Visibility = Visibility.Visible;
                c1.Visibility = Visibility.Hidden;
                c3.Visibility = Visibility.Hidden;
                c4.Visibility = Visibility.Hidden;
            }
            

            bdr.BorderBrush = Brushes.Red;
            bdr.BorderThickness = new Thickness(5);
            bdr.Width = img.Width;
            bdr.Height = img.Height;
            if (c2.Children.Contains(canvas))
            {
                c2.Children.Remove(canvas);
                bdr.Child = img;
            }
            c2.Children.Add(bdr);

        }

        private void Picture3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            chip = 25;
            selectchip1 = false;
            selectchip2 = false;
            selectchip3 = true;
            selectchip4 = false;
            Canvas canvas = sender as Canvas;
            Image img = sender as Image;

            Border bdr = new Border();
            if (selectchip3)
            {
                bdr.Visibility = Visibility.Visible;
                c3.Visibility = Visibility.Visible;
                c1.Visibility = Visibility.Hidden;
                c2.Visibility = Visibility.Hidden;
                c4.Visibility = Visibility.Hidden;
            }


            bdr.BorderBrush = Brushes.Red;
            bdr.BorderThickness = new Thickness(5);
            bdr.Width = img.Width;
            bdr.Height = img.Height;
            if (c3.Children.Contains(canvas))
            {
                c3.Children.Remove(canvas);
                bdr.Child = img;
            }
            c3.Children.Add(bdr);
        }

        private void Picture4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            chip = 100;
            selectchip1 = false;
            selectchip2 = false;
            selectchip3 = false;
            selectchip4 = true;

            Canvas canvas = sender as Canvas;
            Image img = sender as Image;

            Border bdr = new Border();
            if (selectchip4)
            {
                bdr.Visibility = Visibility.Visible;
                c4.Visibility = Visibility.Visible;
                c1.Visibility = Visibility.Hidden;
                c3.Visibility = Visibility.Hidden;
                c2.Visibility = Visibility.Hidden;
            }


            bdr.BorderBrush = Brushes.Red;
            bdr.BorderThickness = new Thickness(5);
            bdr.Width = img.Width;
            bdr.Height = img.Height;
            if (c4.Children.Contains(canvas))
            {
                c4.Children.Remove(canvas);
                bdr.Child = img;
            }
            c4.Children.Add(bdr);
        }

        #region board
   
        #endregion
        public void getMoney()
        {
            winAmount += sums[drawnNumber] * multiplicator[drawnNumber];
            // If drawn number is even than color should be black, and black is in position 1 in sumsColor
            winAmount += (drawnNumber == 0) ? 0 : sumsColor[(drawnNumber % 2 == 0) ? 1 : 0] * colors;
            winAmount += (drawnNumber == 0) ? 0 : sumsHalf[(drawnNumber <= columnLimit) ? 0 : 1] * halfs;
            winAmount += (drawnNumber == 0) ? 0 : sumsColumn[(drawnNumber <= 12) ? 0 : (drawnNumber > 12 && drawnNumber <= 24) ? 1 : 2] * columns;
            winAmount += (drawnNumber == 0) ? 0 : sumsEven[drawnNumber % 2] * evens;
            winAmount += (drawnNumber == 0) ? 0 : sumsRows[(drawnNumber % 3 == 0) ? 0 : (drawnNumber % 3 == 2) ? 1 : 2] * rows;
            winningAmount.Content = winAmount.ToString();
            totalAmount += winAmount;
            labelCash.Content = totalAmount.ToString();
            
        }
        private void ClearAllBet()
        {
            betAmount = 0;
            winAmount = 0;
            betCash.Content = "";
            winningAmount.Content = "";
            foreach (var item in mappedLabels)
            {
                (item.Key as Label).Content = "";
            }
            for (int i = 0;i<sums.Count();i++)
            {
                sums[i] = 0;
            }
            for (int i = 0; i < sumsColor.Count(); i++)
            {
                sumsColor[i] = 0;
            }
            for (int i = 0; i < sumsHalf.Count(); i++)
            {
                sumsHalf[i] = 0;
            }
            for (int i = 0; i < sumsColumn.Count(); i++)
            {
                sumsColumn[i] = 0;
            }
            for (int i = 0; i < sumsEven.Count(); i++)
            {
                sumsEven[i] = 0;
            }
            for (int i = 0; i< sumsRows.Count(); i++)
            {
                sumsRows[i] = 0;
            }
        }

        public void disableAll()
        {
            spinWheel.IsEnabled = false;
            butonClear.IsEnabled = false;
            picture1.IsEnabled = false;
            picture2.IsEnabled = false;
            picture3.IsEnabled = false;
            picture4.IsEnabled = false;
            foreach (var item in mappedLabels)
            {
                (item.Key as Label).IsEnabled = false;
            }
        }
        public void enableAll()
        {
            spinWheel.IsEnabled = true;
            butonClear.IsEnabled = true;
            picture1.IsEnabled = true;
            picture2.IsEnabled = true;
            picture3.IsEnabled = true;
            picture4.IsEnabled = true;
            foreach (var item in mappedLabels)
            {
                (item.Key as Label).IsEnabled = true;
            }
        }

        private void click_clearBet(object sender, RoutedEventArgs e)
        {
            totalAmount += betAmount;
            betAmount = 0;
            winAmount = 0;

            betCash.Content = "";
            labelCash.Content = totalAmount.ToString();
            ClearAllBet();
        }



    }

}
