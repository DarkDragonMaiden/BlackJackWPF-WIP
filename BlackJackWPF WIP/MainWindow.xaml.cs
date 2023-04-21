using BlackJackWPF_WIP;
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

namespace BlackJackWPF_WIP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Rectangle playerCard = new Rectangle();
            playerCard.Width = 130;
            playerCard.Height = 192;
            playerCard.Fill = Brushes.White;
            playerCard.Stroke = Brushes.Black;
            Canvas.SetLeft(playerCard, 50);

        }
        Deck deck = new Deck();

        Player player = new Player("Player");
        Dealer dealer = new Dealer();

        private void HitButton_Click(object sender, RoutedEventArgs e)
        {
            Rectangle newRect = new Rectangle();
            newRect.Width = 130;
            newRect.Height = 192;
            newRect.Fill = Brushes.White;
            newRect.Stroke = Brushes.Black;
            Canvas.SetLeft(newRect, 100);
            Canvas.SetTop(newRect, 100);
            myCanvas.Children.Add(newRect);

            player.AddCard(deck.DrawCard());
            player.DisplayHand();

        }

        private void StandButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            for (int card = 1; card <= 2; card++) { }
                Rectangle playerCard = new Rectangle();
                playerCard.Width = 130;
                playerCard.Height = 192;
                playerCard.Fill = Brushes.White;
                playerCard.Stroke = Brushes.Black;
                Canvas.SetLeft(playerCard, 250);
                Canvas.SetTop(playerCard, 220);
                myCanvas.Children.Add(playerCard);
        }
    }
}
/*
 *         static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");

            Deck deck = new Deck();
            deck.Shuffle();

            Player player = new Player("Player");
            Dealer dealer = new Dealer();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Dealing cards...");
                Console.WriteLine();

                player.ClearHand();
                dealer.ClearHand();

                player.AddCard(deck.DrawCard());
                dealer.AddCard(deck.DrawCard());
                player.AddCard(deck.DrawCard());
                dealer.AddCard(deck.DrawCard());

                player.DisplayHand();
                dealer.DisplayHand(true);

                while (true)
                {
                    Console.Write("Do you want to hit or stand? ");
                    string input = Console.ReadLine();
                    Console.WriteLine();

                    if (input.ToLower() == "hit")
                    {
                        player.AddCard(deck.DrawCard());
                        player.DisplayHand();
                        if (player.TotalValue > 21)
                        {
                            Console.WriteLine("You busted!");
                            break;
                        }
                    }
                    else if (input.ToLower() == "stand")
                    {
                        dealer.DisplayHand(false);
                        while (dealer.ShouldHit())
                        {
                            dealer.AddCard(deck.DrawCard());
                            dealer.DisplayHand(false);
                            if (dealer.TotalValue > 21)
                            {
                                Console.WriteLine("Dealer busted! You win!");
                                break;
                            }
                        }
                        if (dealer.TotalValue == player.TotalValue)
                        {
                            Console.WriteLine("It's a tie!");
                        }
                        else if (dealer.TotalValue >= player.TotalValue && dealer.TotalValue <= 21)
                        {
                            Console.WriteLine("Dealer wins!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'hit' or 'stand'.");
                    }
                }

                Console.Write("Do you want to play again? ");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "yes")
                {
                    break;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }

*/

