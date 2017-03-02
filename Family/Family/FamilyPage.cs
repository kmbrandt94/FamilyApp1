using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Family
{
    class FamilyPage : ContentPage
    {
        public FamilyPage()
        {
            Title = "My Family";

            StackLayout stackLayout = new StackLayout
            {
                
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#000000"),
                Children = {
                    new Label {
                        Text = "Kyle (Me) studies .NET Programming at Hennepin Technical College. Kyle loves his small family. He also enjoys video games and music. Some of his favorite music genre's include Dubstep, Riddim, And all types of Metal. His favorite game genre's are MMORPGS, RPGS, Adventure, and Horror Games. asdfdasfasdfasdfasdfasdfasdfasfasdfasdfasdfasdfasfasdfasdfasdfasdfasdf",
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromHex("#FF0000")
                    },
                    new Label {
                        Text = "Ashley (Girlfriend) works at HealthPartners. Ashley also loves her small family.",
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromHex("#CD00FF")

                    },
                    new Label {
                        Text = "Joey (Dog) is a young Yorkshire Terrier. Joey spends his time cuddling with Ashley.",
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromHex("#001BFF")

                },
                    new Label {
                        Text = "Oscar (Cat) is a young Norwegian Forest Cat. He spends his time eating and annoying his father Kyle.",
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromHex("#FBFF00")

                },
                    new Label {
                        Text = "Knight (Rabbit) is the newest addition to the family. He is a newborn French Angora Kit.",
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromHex("#0FFF00")
  
        
                }
             }
          };
            Content = new ScrollView
            {
                Content = stackLayout            };

       }
   }
}
