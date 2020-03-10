using Android.Graphics;
using Plugin.Media;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElectionMobileApp.Views.mama
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class addMessage : ContentPage
	{
		public addMessage ()
		{
			InitializeComponent ();
		}
        private async void btnCaptureClicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            Dictionary<Permission, PermissionStatus> result = new Dictionary<Permission, PermissionStatus>();


            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Location); //<LocationPermission>
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Location))
                    {
                        await DisplayAlert("Need location", "Gunna need that location", "OK");
                    }

                    result = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Location);
                }

                if (result[Permission.Location] == PermissionStatus.Granted)
                {
                    //Query permission
                }
                else if (status != PermissionStatus.Unknown)
                {
                    await DisplayAlert("Location Denied", "Can not continue, try again.", "OK");
                }
            }
            catch (Exception ex)
            {
                //Something went wrong
            }

            if (!CrossMedia.Current.IsPickPhotoSupported && !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("Message", "Photo capture and photo upload is not available","OK");
            }
            else
            {
                var file = await CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
                {
                    PhotoSize = Plugin.Media.Abstractions.PhotoSize.Full,
                    CompressionQuality = 40
                    //Directory = "Images",
                    //Name=DateTime.Now+"_test.jpg"
                });
                if(file==null)
                {
                    return;
                }

                await DisplayAlert("File path", file.Path, "OK");
               // byte[] imageArray = System.IO.File.ReadAllBytes(file.Path);
                //Bitmap bitmap = BitmapFactory.DecodeByteArray(imageArray, 0, imageArray.Length);
                

                image.Source = ImageSource.FromStream(() =>
                  {
                      var stream = file.GetStream();
                      return stream;
                  });
            }
        }
    }
}