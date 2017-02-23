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
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.FromHex("#000000"),
                Children = {
                    new Label {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Kyle (Me)",
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromHex("#FFFFFF")
                    },
                    new Label {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Ashley (Girlfriend)",
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromHex("#FFFFFF")

                    },
                    new Label {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Joey (Dog)",
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromHex("#FFFFFF")

                },
                    new Label {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Oscar (Cat)",
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromHex("#FFFFFF")

                },
                    new Label {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Knight (Rabbit)",
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromHex("#FFFFFF")

                }
             }
          };
       }
   }
}
