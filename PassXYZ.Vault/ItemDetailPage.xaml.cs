using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

namespace PassXYZ.Vault;

public partial class ItemDetailPage : ContentPage
{

    //private string description;
    //[ObservableProperty]
    //public string Description
    //{
    //    get => description;
    //    set => SetProperty(ref description, value);
    //}
    public ItemDetailPage()
    {
        InitializeComponent();
    }

    public async void LoadItemId(string itemId)
    {
        if (itemId == null)
        {
            throw new ArgumentNullException(nameof(itemId));
        }
        //       var item = await dataStore.GetItemAsync(itemId);
        //       if (item == null)
        //       {
        //         //  Logger.LogDebug("cannot find {item}", itemId); 


        //       return;
        //       }
        //       Id = item.Id;
        //      Name = item.Name;
        //       Description = item.Description;
        //}

    }
}