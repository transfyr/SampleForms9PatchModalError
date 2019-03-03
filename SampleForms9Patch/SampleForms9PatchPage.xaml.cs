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

            Label label1 = new Label
            {
                Text = "Hello Modal popup",
                TextColor = Color.Black,
                BackgroundColor = Color.White
            };
            AbsoluteLayout.SetLayoutFlags(label1, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(label1, new Rectangle(0, 0, 0.5, 0.5));
            Label label2 = new Label
            {
                Text = "HelloModalpopup22",
                TextColor = Color.Black,
                BackgroundColor = Color.White
            };
            AbsoluteLayout.SetLayoutFlags(label2, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(label2, new Rectangle(1, 1, 0.5, 0.5));

            var modal = new Forms9Patch.ModalPopup()
            {
                BackgroundImage = new Forms9Patch.Image
                {
                    Source = ImageSource.FromUri(uri)
                },
                HeightRequest = 500,
                WidthRequest = 500,
                Content = new AbsoluteLayout
                {
                    Children =
                    {
                        label1, label2,
                    }
                },
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
