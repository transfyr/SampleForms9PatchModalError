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
        }

		protected override void OnAppearing()
		{
            base.OnAppearing();

            //mainGrid.HeightRequest = mAbsLayout.Height * 1.3;
		}
	}
}
