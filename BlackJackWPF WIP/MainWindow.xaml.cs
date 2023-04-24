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

        }
        Deck deck = new Deck();
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // Shuffles the first and second card to begin the game
            deck.Shuffle();
            Card c1 = deck.DrawCard(); card1Suit.Text = c1.Suit; card1Rank.Text = c1.Rank;
            deck.Shuffle();
            Card c2 = deck.DrawCard(); card1Suit1.Text = c2.Suit; card1Rank1.Text = c2.Rank;

        }

        private void HitButton_Click(object sender, RoutedEventArgs e)
        {
            // Shuffles the next 3 cards only does the 3rd one atm
            deck.Shuffle();
            Card c3 = deck.DrawCard(); card1Suit2.Text = c3.Suit; card1Rank2.Text = c3.Rank;

        }

        private void StandButton_Click(object sender, RoutedEventArgs e)
        {
            // Filler
            MessageBox.Show("You win!");

            // Empties the text blocks
            card1Suit.Text = string.Empty; card1Rank.Text = string.Empty;
            card1Suit1.Text = string.Empty; card1Rank1.Text = string.Empty;
            card1Suit2.Text = string.Empty; card1Rank2.Text = string.Empty;
        }
    }
}
#region random code
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
#endregion
/* Rectangle
*Rectangle newRect = new Rectangle();
newRect.Width = 130;
newRect.Height = 192;
newRect.Fill = Brushes.White;
newRect.Stroke = Brushes.Black;
Canvas.SetLeft(newRect, 100);
Canvas.SetTop(newRect, 100);
myCanvas.Children.Add(newRect);
*/
/* Canvas
        // Create the application's main window
        mainWindow = new Window();

        // Create a canvas sized to fill the window
        Canvas myCanvas = new Canvas();
        myCanvas.Background = Brushes.LightSteelBlue;

        // Add a "Hello World!" text element to the Canvas
        TextBlock txt1 = new TextBlock();
        txt1.FontSize = 14;
        txt1.Text = "Hello World!";
        Canvas.SetTop(txt1, 100);
        Canvas.SetLeft(txt1, 10);
        myCanvas.Children.Add(txt1);

        // Add a second text element to show how absolute positioning works in a Canvas
        TextBlock txt2 = new TextBlock();
        txt2.FontSize = 22;
        txt2.Text = "Isn't absolute positioning handy?";
        Canvas.SetTop(txt2, 200);
        Canvas.SetLeft(txt2, 75);
        myCanvas.Children.Add(txt2);
        mainWindow.Content = myCanvas;
        mainWindow.Title = "Canvas Sample";
        mainWindow.Show();
*/
/* TextBlock
 * TextBlock textBlock1 = new TextBlock();
TextBlock textBlock2 = new TextBlock();

textBlock1.TextWrapping = textBlock2.TextWrapping = TextWrapping.Wrap;
textBlock2.Background = Brushes.AntiqueWhite;
textBlock2.TextAlignment = TextAlignment.Center;

textBlock1.Inlines.Add(new Bold(new Run("TextBlock")));
textBlock1.Inlines.Add(new Run(" is designed to be "));
textBlock1.Inlines.Add(new Italic(new Run("lightweight")));
textBlock1.Inlines.Add(new Run(", and is geared specifically at integrating "));
textBlock1.Inlines.Add(new Italic(new Run("small")));
textBlock1.Inlines.Add(new Run(" portions of flow content into a UI."));

textBlock2.Text =
    "By default, a TextBlock provides no UI beyond simply displaying its contents.";
 */
