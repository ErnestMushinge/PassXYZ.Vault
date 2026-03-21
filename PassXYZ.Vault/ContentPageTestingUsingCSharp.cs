namespace PassXYZ.Vault;

public class ContentPageTestingUsingCSharp : ContentPage
{
    public ContentPageTestingUsingCSharp()
    {
        Content = new VerticalStackLayout
        {
            //Children = {
            //	new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
            //	}
            //}
            Children = {
                 new Label { Text = "Welcome to .NET MAUI!" },
                 new BoxView {
                 HeightRequest = 150,
                 WidthRequest = 150,
                 HorizontalOptions = LayoutOptions.Center,
                 Color = Color.FromRgba(192, 75, 150, 128) //[3]
                 }
            }
        };
    }
}