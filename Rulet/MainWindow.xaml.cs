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


        private Storyboard sb;
        private DispatcherTimer timer1;
        private DispatcherTimer timer2;
        private DispatcherTimer timer3;
        private int cheap;
        private bool selectCheap1;
        private bool selectCheap2;
        private bool selectCheap3;
        private bool selectCheap4;
        private int sum;
        private int sum1, sum2,sum3,sum4,sum5, sum6, sum7, sum8, sum9, sum10, sum11, sum12, sum13, sum14, sum15;
        private int sum16, sum17, sum18, sum19, sum20, sum21, sum22, sum23, sum24, sum25, sum26, sum27, sum28, sum29, sum30;
        private int sum31, sum32, sum33, sum34, sum35, sum36, sum37, sum38, sum39, sum40, sum41, sum42, sum43, sum44, sum45, sum46;
        private int counter;
        private int drawnNumber;
        private int totalAmount;
        private int betAmount;
        private int winAmount;
        private SoundPlayer player;
        private SoundPlayer player1;
        
        public MainWindow()
        {

            

            InitializeComponent();

            Loaded+= new RoutedEventHandler(pauseWheel);
            cheap = 0;
            selectCheap1 = false;
            selectCheap2 = false;
            selectCheap3 = false;
            selectCheap4 = false;
            sum = 0;
            sum1 = 0;
            sum2 = 0; sum3 = 0; sum4 = 0; sum5 = 0; sum6 = 0;sum7 = 0; sum8 = 0;sum9 = 0; sum10 = 0;sum11 = 0; sum12 = 0; sum13 = 0;
            sum14 = 0;sum15 = 0; sum16 = 0; sum17 = 0; sum18 = 0;sum19 = 0; sum20 = 0;sum21 = 0;sum22 = 0;sum23 = 0;sum24 = 0;sum25 =0;
            sum26 = 0;sum27 = 0;sum28 = 0;sum29 = 0;sum30 = 0; sum31 = 0; sum32 = 0; sum33 = 0; sum34 = 0; sum35 = 0;sum36 = 0;
            sum37 = 0;sum38 = 0;sum39 = 0;sum40 = 0;sum41 = 0;sum42 = 0;sum43 = 0;sum44 = 0;sum45 = 0;sum46 = 0;
           
            counter = 0;
            drawnNumber = 0;
            
            totalAmount = 10000;
            betAmount = 0;
            winAmount = 0;
            setCash();
            BetCash();
            ball.Visibility = Visibility.Hidden;
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
            if (counter == 0)
            {
                labelIN1.Content = drawnNumber.ToString();
                
            }
            else if(counter==1){
                labelIN2.Content = drawnNumber.ToString();
                
            }
            else if (counter == 2)
            {
                labelIN3.Content = drawnNumber.ToString();
                
            }
            else if(counter==3){
                labelIN4.Content = drawnNumber.ToString();
            }
            counter++;
            if (counter == 4)
            {
                counter = 0;
            }
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
            cheap = 1;
            selectCheap1 = true;
            selectCheap2 = false;
            selectCheap3 = false;
            selectCheap4 = false;

            Canvas canvas = sender as Canvas;
            Image img = sender as Image;
            
            Border bdr = new Border();
            if (selectCheap1)
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
            cheap = 5;
            selectCheap1 = false;
            selectCheap2 = true;
            selectCheap3 = false;
            selectCheap4 = false;
            Canvas canvas = sender as Canvas;
            Image img = sender as Image;

            Border bdr = new Border();
            if (selectCheap2)
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
            cheap = 25;
            selectCheap1 = false;
            selectCheap2 = false;
            selectCheap3 = true;
            selectCheap4 = false;
            Canvas canvas = sender as Canvas;
            Image img = sender as Image;

            Border bdr = new Border();
            if (selectCheap3)
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
            cheap = 100;
            selectCheap1 = false;
            selectCheap2 = false;
            selectCheap3 = false;
            selectCheap4 = true;

            Canvas canvas = sender as Canvas;
            Image img = sender as Image;

            Border bdr = new Border();
            if (selectCheap4)
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
        private void LabelRed_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum3 += cheap;
                labelRed.Content = sum3.ToString();
                betAmount += cheap;
                totalAmount -= cheap;
                
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelBlack_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum4 += cheap;
                labelBlack.Content = sum4.ToString();
                betAmount += cheap;
                totalAmount -= cheap;
                
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelOdd_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
            sum5 += cheap;
            labelOdd.Content = sum5.ToString();
            betAmount += cheap;
            totalAmount -= cheap;
            
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        

        private void Label0_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum += cheap;

                label0.Content = sum.ToString();
                betAmount += cheap;
                totalAmount -= cheap;
                
            }
            else
            { 
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();

         }

        private void Label1to18_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
            sum1 += cheap;
            label1to18.Content = sum1.ToString();
            betAmount += cheap;
            totalAmount -= cheap;
            
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();

        }

        

        private void LabelEven_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
            sum2 += cheap;
            labelEven.Content = sum2.ToString();
            betAmount += cheap;
            totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN16_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum16 += cheap;
            labelN16.Content = sum16.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();

        }
        private void LabelN19_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum17 += cheap;
            labelN19.Content = sum17.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }


        private void LabelN22_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum18 += cheap;
            labelN22.Content = sum18.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }
        private void LabelN25_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum19 += cheap;
            labelN25.Content = sum19.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }
        private void LabelN28_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum20 += cheap;
            labelN28.Content = sum20.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }
        private void LabelN31_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum21 += cheap;
            labelN31.Content = sum21.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN34_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum22 += cheap;
            labelN34.Content = sum22.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }
        private void LabelN2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum23 += cheap;
            labelN2.Content = sum23.ToString();
            betAmount += cheap;
                totalAmount -= cheap;

            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }
        private void LabelN5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum24 += cheap;
            labelN5.Content = sum24.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }
        private void LabelN8_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum25 += cheap;
            labelN8.Content = sum25.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }
        private void LabelN11_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum26 += cheap;
            labelN11.Content = sum26.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN14_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum27 += cheap;
            labelN14.Content = sum27.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN17_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum28 += cheap;
            labelN17.Content = sum28.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN20_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum29 += cheap;
            labelN20.Content = sum29.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN23_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum30 += cheap;
            labelN23.Content = sum30.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN26_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum31 += cheap;
            labelN26.Content = sum31.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN29_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum32 += cheap;
            labelN29.Content = sum32.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN32_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum33 += cheap;
            labelN32.Content = sum33.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN35_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum34 += cheap;
            labelN35.Content = sum34.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum35 += cheap;
            labelN3.Content = sum35.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum36 += cheap;
            labelN6.Content = sum36.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }


        private void LabelN9_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum37 += cheap;
            labelN9.Content = sum37.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN12_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum38 += cheap;
            labelN12.Content = sum38.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN15_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum39 += cheap;
            labelN15.Content = sum39.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN18_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum40 += cheap;
            labelN18.Content = sum40.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN21_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum41 += cheap;
            labelN21.Content = sum41.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN24_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum42 += cheap;
            labelN24.Content = sum42.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN27_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum43 += cheap;
            labelN27.Content = sum43.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN30_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum44 += cheap;
            labelN30.Content = sum44.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN33_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum45 += cheap;
            labelN33.Content = sum45.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN36_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum46 += cheap;
            labelN36.Content = sum46.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();

        }
        private void Label19to36_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum6 += cheap;
            label19to36.Content = sum6.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void Label1st12_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum7 += cheap;
            label1st12.Content = sum7.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }


        private void Label2nd12_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum8 += cheap;
            label2nd12.Content = sum8.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void Label3rd12_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum9 += cheap;
            label3rd12.Content = sum9.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void Label2to1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum10 += cheap;
            label2to1.Content = sum10.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }


        private void LabelN1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum11 += cheap;
            labelN1.Content = sum11.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum12 += cheap;
            labelN4.Content = sum12.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN7_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum13 += cheap;
            labelN7.Content = sum13.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }

        private void LabelN10_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount > 0)
            {
                sum14 += cheap;
            labelN10.Content = sum14.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }


        private void LabelN13_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (betAmount < totalAmount || totalAmount>0)
            {
                sum15 += cheap;
            labelN13.Content = sum15.ToString();
            betAmount += cheap;
                totalAmount -= cheap;
            }
            else
            {
                MessageBox.Show("You don't have enought money!");
            }
            BetCash();
        }
        #endregion
        public void getMoney()
        {
            if (drawnNumber == 13)
            {
                winAmount += sum15 * 36;
            }
            if (drawnNumber == 10)
            {
                winAmount += sum14 * 36;
            }
            if (drawnNumber == 7)
            {
                winAmount += sum13 * 36;
            }
            if (drawnNumber == 4)
            {
                winAmount += sum12 * 36;
            }
            if (drawnNumber == 1)
            {
                winAmount += sum11 * 36;
            }
            if (drawnNumber>10)
            {
                winAmount += sum10 * 2;
            }
            if (drawnNumber>3 && drawnNumber<12)
            {
                winAmount += sum9 * 5;
            }
            if (drawnNumber>2 && drawnNumber<12)
            {
                winAmount += sum8 * 4;
            }
            if (drawnNumber >1 && drawnNumber<12)
            {
                winAmount += sum7 * 3;
            }
            if (drawnNumber> 19 && drawnNumber<36)
            {
                winAmount += sum6 * 2;
            }
            if (drawnNumber == 36)
            {
                winAmount += sum46 * 36;
            }
            if (drawnNumber == 33)
            {
                winAmount += sum45 * 36;
            }
            if (drawnNumber == 30)
            {
                winAmount += sum44 * 36;
            }
            if (drawnNumber == 27)
            {
                winAmount += sum43 * 36;
            }
            if (drawnNumber == 24)
            {
                winAmount += sum42 * 36;
            }
            if (drawnNumber == 21)
            {
                winAmount += sum41 * 36;
            }
            if (drawnNumber == 18)
            {
                winAmount += sum40 * 36;
            }
            if (drawnNumber == 15)
            {
                winAmount += sum39 * 36;
            }
            if (drawnNumber == 12)
            {
                winAmount += sum38 * 36;
            }
            if (drawnNumber == 9)
            {
                winAmount += sum37 * 36;
            }
            if (drawnNumber == 6)
            {
                winAmount += sum36 * 36;
            }
            if (drawnNumber == 3)
            {
                winAmount += sum35 * 36;
            }
            if (drawnNumber == 35)
            {
                winAmount += sum34 * 36;
            }
            if (drawnNumber == 32)
            {
                winAmount += sum33 * 36;
            }
            if (drawnNumber == 29)
            {
                winAmount += sum32 * 36;
            }
            if (drawnNumber == 26)
            {
                winAmount += sum31 * 36;
            }
            if (drawnNumber == 23)
            {
                winAmount += sum30 * 36;
            }
            if (drawnNumber == 20)
            {
                winAmount += sum29 * 36;
            }
            if (drawnNumber == 17)
            {
                winAmount += sum28 * 36;
            }
            if (drawnNumber == 14)
            {
                winAmount += sum27 * 36;
            }
            if (drawnNumber == 11)
            {
                winAmount += sum26 * 36;
            }
            if (drawnNumber == 8)
            {
                winAmount += sum25 * 36;
            }
            if (drawnNumber == 5)
            {
                winAmount += sum24 * 36;
            }
            if (drawnNumber == 2)
            {
                winAmount += sum23 * 36;
            }
            if (drawnNumber == 34)
            {
                winAmount += sum22 * 36;
            }
            if (drawnNumber == 31)
            {
                winAmount += sum21 * 36;
            }
            if (drawnNumber == 28)
            {
                winAmount += sum20 * 36;
            }
            if (drawnNumber == 25)
            {
                winAmount += sum19 * 36;
            }
            if (drawnNumber == 22)
            {
                winAmount += sum18 * 36;
            }
            if (drawnNumber == 19)
            {
                winAmount += sum17 * 36;
            }
            if (drawnNumber == 16)
            {
                winAmount += sum16 * 36;
            }
            if (drawnNumber >20)
            {
                winAmount += sum2 * 10;
            }
            if (drawnNumber >1 && drawnNumber<18)
            {
                winAmount += sum1 * 5;
            }
            if (drawnNumber == 0)
            {
                winAmount += sum * 50;
            }
            if (drawnNumber >29)
            {
                winAmount += sum5 * 20;
            }
            if (drawnNumber == 2 || drawnNumber==4 || drawnNumber==6 || drawnNumber==8 || drawnNumber==10 || drawnNumber==11 || drawnNumber==13
                || drawnNumber==15 || drawnNumber==17 || drawnNumber==20 || drawnNumber==22 || drawnNumber==24 || drawnNumber==26
                || drawnNumber==28 || drawnNumber==29 || drawnNumber==31 || drawnNumber==33 || drawnNumber==35)
                
            {
                winAmount += sum4 * 2;
            }
            if (drawnNumber == 1 || drawnNumber == 3 || drawnNumber == 5 || drawnNumber == 7 || drawnNumber == 9 || drawnNumber == 12 || drawnNumber == 14
                || drawnNumber == 16 || drawnNumber == 18 || drawnNumber == 19 || drawnNumber == 21 || drawnNumber == 23 || drawnNumber == 25
                || drawnNumber == 27 || drawnNumber == 30 || drawnNumber == 32 || drawnNumber == 34 || drawnNumber == 36)

            {
                winAmount += sum3 * 2;
            }
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
            label0.Content = "";
            labelN3.Content = "";
            labelN6.Content = "";
            labelN9.Content = "";
            labelN12.Content = "";
            labelN15.Content = "";
            labelN18.Content = "";
            labelN21.Content = "";
            labelN24.Content = "";
            labelN27.Content = "";
            labelN30.Content = "";
            labelN33.Content = "";
            labelN36.Content = "";
            label2to1.Content = "";
            labelN2.Content = "";
            labelN5.Content = "";
            labelN8.Content = "";
            labelN11.Content = "";
            labelN14.Content = "";
            labelN17.Content = "";
            labelN20.Content = "";
            labelN23.Content = "";
            labelN26.Content = "";
            labelN29.Content = "";
            labelN32.Content = "";
            labelN35.Content = "";
            labelN1.Content = "";
            labelN4.Content = "";
            labelN7.Content = "";
            labelN10.Content = "";
            labelN13.Content = "";
            labelN16.Content = "";
            labelN19.Content = "";
            labelN22.Content = "";
            labelN25.Content = "";
            labelN28.Content = "";
            labelN31.Content = "";
            labelN34.Content = "";
            labelN34.Content = "";
            label2nd12.Content = "";
            label3rd12.Content = "";
            label1to18.Content = "";
            labelEven.Content = "";
            labelRed.Content = "";
            labelBlack.Content = "";
            labelOdd.Content = "";
            label19to36.Content = "";
            label1st12.Content = "";
            sum = 0;
            sum1 = 0;
            sum2 = 0; sum3 = 0; sum4 = 0; sum5 = 0; sum6 = 0; sum7 = 0; sum8 = 0; sum9 = 0; sum10 = 0; sum11 = 0; sum12 = 0; sum13 = 0;
            sum14 = 0; sum15 = 0; sum16 = 0; sum17 = 0; sum18 = 0; sum19 = 0; sum20 = 0; sum21 = 0; sum22 = 0; sum23 = 0; sum24 = 0; sum25 = 0;
            sum26 = 0; sum27 = 0; sum28 = 0; sum29 = 0; sum30 = 0; sum31 = 0; sum32 = 0; sum33 = 0; sum34 = 0; sum35 = 0; sum36 = 0;
            sum37 = 0; sum38 = 0; sum39 = 0; sum40 = 0; sum41 = 0; sum42 = 0; sum43 = 0; sum44 = 0; sum45 = 0; sum46 = 0;
            
        }

        public void disableAll()
        {
            spinWheel.IsEnabled = false;
            butonClear.IsEnabled = false;
            picture1.IsEnabled = false;
            picture2.IsEnabled = false;
            picture3.IsEnabled = false;
            picture4.IsEnabled = false;
            label0.IsEnabled = false;
            labelN3.IsEnabled = false;
            labelN6.IsEnabled = false;
            labelN9.IsEnabled = false;
            labelN12.IsEnabled = false;
            labelN15.IsEnabled = false;
            labelN18.IsEnabled = false;
            labelN21.IsEnabled = false;
            labelN24.IsEnabled = false;
            labelN27.IsEnabled = false;
            labelN30.IsEnabled = false;
            labelN33.IsEnabled = false;
            labelN36.IsEnabled = false;
            label2to1.IsEnabled = false;
            labelN2.IsEnabled = false;
            labelN5.IsEnabled = false;
            labelN8.IsEnabled = false;
            labelN11.IsEnabled = false;
            labelN14.IsEnabled = false;
            labelN17.IsEnabled = false;
            labelN20.IsEnabled = false;
            labelN23.IsEnabled = false;
            labelN26.IsEnabled = false;
            labelN29.IsEnabled = false;
            labelN32.IsEnabled = false;
            labelN35.IsEnabled = false;
            labelN1.IsEnabled = false;
            labelN4.IsEnabled = false;
            labelN7.IsEnabled = false;
            labelN10.IsEnabled = false;
            labelN13.IsEnabled = false;
            labelN16.IsEnabled = false;
            labelN19.IsEnabled = false;
            labelN22.IsEnabled = false;
            labelN25.IsEnabled = false;
            labelN28.IsEnabled = false;
            labelN31.IsEnabled = false;
            labelN34.IsEnabled = false;
            labelN34.IsEnabled = false;
            label2nd12.IsEnabled = false;
            label3rd12.IsEnabled = false;
            label1to18.IsEnabled = false;
            labelEven.IsEnabled = false;
            labelRed.IsEnabled = false;
            labelBlack.IsEnabled = false;
            labelOdd.IsEnabled = false;
            label19to36.IsEnabled = false;
            label1st12.IsEnabled = false;
        }
        public void enableAll()
        {
            spinWheel.IsEnabled = true;
            butonClear.IsEnabled = true;
            picture1.IsEnabled = true;
            picture2.IsEnabled = true;
            picture3.IsEnabled = true;
            picture4.IsEnabled = true;
            label0.IsEnabled = true;
            labelN3.IsEnabled = true;
            labelN6.IsEnabled = true;
            labelN9.IsEnabled = true;
            labelN12.IsEnabled = true;
            labelN15.IsEnabled = true;
            labelN18.IsEnabled = true;
            labelN21.IsEnabled = true;
            labelN24.IsEnabled = true;
            labelN27.IsEnabled = true;
            labelN30.IsEnabled = true;
            labelN33.IsEnabled = true;
            labelN36.IsEnabled = true;
            label2to1.IsEnabled = true;
            labelN2.IsEnabled = true;
            labelN5.IsEnabled = true;
            labelN8.IsEnabled = true;
            labelN11.IsEnabled = true;
            labelN14.IsEnabled = true;
            labelN17.IsEnabled = true;
            labelN20.IsEnabled = true;
            labelN23.IsEnabled = true;
            labelN26.IsEnabled = true;
            labelN29.IsEnabled = true;
            labelN32.IsEnabled = true;
            labelN35.IsEnabled = true;
            labelN1.IsEnabled = true;
            labelN4.IsEnabled = true;
            labelN7.IsEnabled = true;
            labelN10.IsEnabled = true;
            labelN13.IsEnabled = true;
            labelN16.IsEnabled = true;
            labelN19.IsEnabled = true;
            labelN22.IsEnabled = true;
            labelN25.IsEnabled = true;
            labelN28.IsEnabled = true;
            labelN31.IsEnabled = true;
            labelN34.IsEnabled = true;
            labelN34.IsEnabled = true;
            label2nd12.IsEnabled = true;
            label3rd12.IsEnabled = true;
            label1to18.IsEnabled = true;
            labelEven.IsEnabled = true;
            labelRed.IsEnabled = true;
            labelBlack.IsEnabled = true;
            labelOdd.IsEnabled = true;
            label19to36.IsEnabled = true;
            label1st12.IsEnabled = true;
        }

        private void click_clearBet(object sender, RoutedEventArgs e)
        {
            totalAmount += betAmount;
            betAmount = 0;
            winAmount = 0;

            betCash.Content = "";
            labelCash.Content = totalAmount.ToString();
            winningAmount.Content = "";
            label0.Content = "";
            labelN3.Content = "";
            labelN6.Content = "";
            labelN9.Content = "";
            labelN12.Content = "";
            labelN15.Content = "";
            labelN18.Content = "";
            labelN21.Content = "";
            labelN24.Content = "";
            labelN27.Content = "";
            labelN30.Content = "";
            labelN33.Content = "";
            labelN36.Content = "";
            label2to1.Content = "";
            labelN2.Content = "";
            labelN5.Content = "";
            labelN8.Content = "";
            labelN11.Content = "";
            labelN14.Content = "";
            labelN17.Content = "";
            labelN20.Content = "";
            labelN23.Content = "";
            labelN26.Content = "";
            labelN29.Content = "";
            labelN32.Content = "";
            labelN35.Content = "";
            labelN1.Content = "";
            labelN4.Content = "";
            labelN7.Content = "";
            labelN10.Content = "";
            labelN13.Content = "";
            labelN16.Content = "";
            labelN19.Content = "";
            labelN22.Content = "";
            labelN25.Content = "";
            labelN28.Content = "";
            labelN31.Content = "";
            labelN34.Content = "";
            labelN34.Content = "";
            label2nd12.Content = "";
            label3rd12.Content = "";
            label1to18.Content = "";
            labelEven.Content = "";
            labelRed.Content = "";
            labelBlack.Content = "";
            labelOdd.Content = "";
            label19to36.Content = "";
            label1st12.Content = "";
            sum = 0;
            sum1 = 0;
            sum2 = 0; sum3 = 0; sum4 = 0; sum5 = 0; sum6 = 0; sum7 = 0; sum8 = 0; sum9 = 0; sum10 = 0; sum11 = 0; sum12 = 0; sum13 = 0;
            sum14 = 0; sum15 = 0; sum16 = 0; sum17 = 0; sum18 = 0; sum19 = 0; sum20 = 0; sum21 = 0; sum22 = 0; sum23 = 0; sum24 = 0; sum25 = 0;
            sum26 = 0; sum27 = 0; sum28 = 0; sum29 = 0; sum30 = 0; sum31 = 0; sum32 = 0; sum33 = 0; sum34 = 0; sum35 = 0; sum36 = 0;
            sum37 = 0; sum38 = 0; sum39 = 0; sum40 = 0; sum41 = 0; sum42 = 0; sum43 = 0; sum44 = 0; sum45 = 0; sum46 = 0;
        }



    }

}
