using System;
using Xamarin.Forms;

namespace SampleForms9Patch
{
    public partial class SampleForms9PatchPage : ContentPage
    {
        public Forms9Patch.ModalPopup qrImageModal;

        public SampleForms9PatchPage()
        {
            InitializeComponent();

            Uri uri = new Uri("https://zxing.org/w/chart?cht=qr&chs=700x700&margin=1&chld=H&choe=UTF-8&chl=Transfyr+-+123");
            Uri uri2 = new Uri("https://images.pexels.com/photos/248797/pexels-photo-248797.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500");
            qrImage.Source = ImageSource.FromUri(uri2);
            var modal = new Forms9Patch.ModalPopup()
            {
                BackgroundImage = new Forms9Patch.Image
                {
                    Source = ImageSource.FromUri(uri)
                }
            };
            qrImageModal = modal;
        }

        public void qrImagePopup(object sender, System.EventArgs e)
        {
            //get the popup once the qr image is pressed
            qrImageModal.IsVisible = true;
        }
    }
}
