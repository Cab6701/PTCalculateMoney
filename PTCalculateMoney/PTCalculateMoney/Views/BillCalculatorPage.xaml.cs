using Camera.MAUI;

namespace PTCalculateMoney.Views;

public partial class BillCalculatorPage : ContentPage
{
	public BillCalculatorPage()
	{
		InitializeComponent();
	}

    private void cameraView_BarcodeDetected(object sender, Camera.MAUI.ZXingHelper.BarcodeEventArgs args)
    {
        Console.WriteLine("BarcodeText=" + args.Result[0].Text);
    }

    //private void cameraView_CamerasLoaded(object sender, EventArgs e)
    //{
    //    if (cameraView.NumCamerasDetected > 0)
    //    {
    //        if (cameraView.NumMicrophonesDetected > 0)
    //            cameraView.Microphone = cameraView.Microphones.First();
    //        cameraView.Camera = cameraView.Cameras.First();
    //        MainThread.BeginInvokeOnMainThread(async () =>
    //        {
    //            if (await cameraView.StartCameraAsync() == CameraResult.Success)
    //            {
    //                controlButton.Text = "Stop";
    //            }
    //        });
    //    }
    //}
}