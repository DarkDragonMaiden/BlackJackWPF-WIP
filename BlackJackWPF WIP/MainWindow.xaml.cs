﻿using BlackJackWPF_WIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
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

            ResetGame();
        }
        Deck deck = new Deck();
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            //List<TextBlock> Card1 = new List<TextBlock>()
            //{
            //    pCard1, pCard2, dCard1, dCard2
            //};
            //foreach(TextBlock c in Card1)
            //{
              //  c.Tag = 
            //}
            /*
            #region Card Creater Card 1
            // Creates a new card from a rectangle
            Rectangle card1 = new Rectangle();
            card1.Width = 120; card1.Height = 175; card1.Fill = Brushes.White; card1.Stroke = Brushes.Black;

            // Creates a new TextBlock for the suit of the first card
            TextBlock card1Suit = new TextBlock();
            card1Suit.Width = 90; card1Suit.Height = 40; card1Suit.FontSize = 20;

            // Creates a new TextBlock for the rank of the first card
            TextBlock card1Rank = new TextBlock();
            card1Rank.Width = 80; card1Rank.Height = 25; card1Rank.FontSize = 20;

            // Sets the position of the Card and adds it as a child of the canvas
            Canvas.SetLeft(card1, 70); Canvas.SetTop(card1, 230);
            myCanvas.Children.Add(card1);

            // Set the position of the TextBlock for the suit
            Canvas.SetLeft(card1Suit, 87); Canvas.SetTop(card1Suit, 325);
            myCanvas.Children.Add(card1Suit);

            // Set the position of the TextBlock for the rank
            Canvas.SetLeft(card1Rank, 100); Canvas.SetTop(card1Rank, 250);
            myCanvas.Children.Add(card1Rank);
            #endregion
            #region Card Creater Card 2
            Rectangle card2 = new Rectangle();
            card2.Width = 120; card2.Height = 175; card2.Fill = Brushes.White; card2.Stroke = Brushes.Black;

            TextBlock card2Suit = new TextBlock();
            card2Suit.Width = 90; card2Suit.Height = 40; card2Suit.FontSize = 20;

            TextBlock card2Rank = new TextBlock();
            card2Rank.Width = 80; card2Rank.Height = 25; card2Rank.FontSize = 20;

            Canvas.SetLeft(card2, 200); Canvas.SetTop(card2, 230);
            myCanvas.Children.Add(card2);

            Canvas.SetLeft(card2Suit, 217); Canvas.SetTop(card2Suit, 325);
            myCanvas.Children.Add(card2Suit);

            Canvas.SetLeft(card2Rank, 225); Canvas.SetTop(card2Rank, 250);
            myCanvas.Children.Add(card2Rank);
            #endregion
            */
            // Shuffles the first and second card to begin the game
            Card c1 = deck.DrawCard();
            Card c2 = deck.DrawCard();
            deck.Shuffle();
            // shows the first two cards.
            pCardSuit1.Text = c1.Suit; pCardRank1.Text = c1.Rank; pCard1.Tag = c1.Value;
            pCardSuit2.Text = c1.Suit; pCardRank2.Text = c1.Rank; pCard2.Tag = c1.Value;
            dCardSuit1.Text = c2.Suit; dCardRank1.Text = c2.Rank; dCard1.Tag = c2.Value;
            dCardSuit2.Text = c2.Suit; dCardRank2.Text = c2.Rank; dCard2.Tag = c2.Value;
            pCard1.Visibility = Visibility.Visible; pCard2.Visibility = Visibility.Visible; dCard1.Visibility = Visibility.Visible; dCard2.Visibility = Visibility.Visible;
            StartButton.Content = "New Game";
            int cV1 = c1.Value;
            int cV2 = c2.Value;
            if (cV1 == 21)
            {
                MessageBox.Show("BlackJack! You win!");
            }
            else if (cV2 == 21)
            {
                MessageBox.Show("Dealer BlackJacked! Dealer Wins!");
            }
        }

        private void HitButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            #region Card Creater Card 3
            Rectangle card3 = new Rectangle();
            card3.Width = 120; card3.Height = 175; card3.Fill = Brushes.White; card3.Stroke = Brushes.Black;

            TextBlock card3Suit = new TextBlock();
            card3Suit.Width = 90; card3Suit.Height = 40; card3Suit.FontSize = 20;

            TextBlock card3Rank = new TextBlock();
            card3Rank.Width = 80; card3Rank.Height = 25; card3Rank.FontSize = 20;

            Canvas.SetLeft(card3, 330); Canvas.SetTop(card3, 230);
            myCanvas.Children.Add(card3);

            Canvas.SetLeft(card3Suit, 347); Canvas.SetTop(card3Suit, 325);
            myCanvas.Children.Add(card3Suit);

            Canvas.SetLeft(card3Rank, 350); Canvas.SetTop(card3Rank, 250);
            myCanvas.Children.Add(card3Rank);
            #endregion
            */
            // Shuffles the next 3 cards
            deck.Shuffle();
            Card c = deck.DrawCard();
            // determines whether a card is hidden and if it is make it visible and after every click makes the next card visible
            if (pCard3.Visibility == Visibility.Hidden)
            {
                pCardSuit3.Text = c.Suit; pCardRank3.Text = c.Rank; pCard3.Tag = c.Value;
                pCard3.Visibility = Visibility.Visible;
            }
            else if (pCard4.Visibility == Visibility.Hidden)
            {
                pCardSuit4.Text = c.Suit; pCardRank4.Text = c.Rank; pCard4.Tag = c.Value;
                pCard4.Visibility = Visibility.Visible;
            }
            else
            {
                pCardSuit5.Text = c.Suit; pCardRank5.Text = c.Rank; pCard5.Tag = c.Value;
                pCard5.Visibility = Visibility.Visible;
            }

        }

        private void StandButton_Click(object sender, RoutedEventArgs e)
        {
            // Adds up all the cards
            int pV = (int)pCard1.Tag + (int)pCard2.Tag + (int)pCard3.Tag + (int)pCard4.Tag + (int)pCard5.Tag;
            int cV = (int)dCard1.Tag + (int)dCard2.Tag + (int)dCard3.Tag + (int)dCard4.Tag + (int)dCard5.Tag;

            if (pV > 21)
            {
                MessageBox.Show("You busted!");
            }
            else if (pV < cV && pV < 21)
            {
                MessageBox.Show("You lost!");
            }
            else if (cV > 21)
            {
                MessageBox.Show("Dealer busted! You win!");
            }
            else
            {
                MessageBox.Show("You win!");
            }

            ResetGame();
        }
        private void ResetGame()
        {
            // puts all the rectangles in a list same with the textblocks to suits and ranks
            List<Rectangle> Cards = new List<Rectangle>()
            {
                pCard1, pCard2, pCard3, pCard4, pCard5,
                dCard1, dCard2, dCard3, dCard4, dCard5
            };
            List<TextBlock> SuitsAndRanks = new List<TextBlock>()
            {
                pCardRank1, pCardRank2, pCardRank3, pCardRank4, pCardRank5, pCardSuit1, pCardSuit2, pCardSuit3, pCardSuit4, pCardSuit5, 
                dCardRank1, dCardRank2, dCardRank3, dCardRank4, dCardRank5, dCardSuit1, dCardSuit2, dCardSuit3, dCardSuit4, dCardSuit5
            };
            // sets all of the values(tag) to 0 and hides it.
            foreach (Rectangle card in Cards)
            {
                card.Tag = 0;
                card.Visibility = Visibility.Hidden;
            }
            // empties out the strings of the suits and ranks in the textblocks
            foreach (TextBlock suitAndRank in SuitsAndRanks)
            {
                suitAndRank.Text = string.Empty;
            }
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
