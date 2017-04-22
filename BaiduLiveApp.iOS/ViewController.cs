using System;

using UIKit;
using CoreGraphics;
using AVFoundation;

using BaiduLiveApp.iOSBinding;

namespace BaiduLiveApp.iOS
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
		}
		VCSimpleSession session;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			VCSimpleSessionConfiguration config = new VCSimpleSessionConfiguration();
			config.CameraOrientation = AVCaptureVideoOrientation.LandscapeLeft;
			config.VideoSize = new CGSize(640, 360);
			config.Bitrate = 1200 * 1000;
			config.CameraDevice = VCCameraState.Back;
			config.ContinuousAutofocus = false;
			config.ContinuousExposure = false;
			config.Fps = 20;
			session = new VCSimpleSession(config);
			session.AspectMode = VCAspectMode.Fill;
			session.Delegate = new CameraDelegate();
			this.View.InsertSubview(session.PreviewView, 0);
	         }


		public override void ViewDidLayoutSubviews()
		{
			session.PreviewView.Frame = View.Bounds;
			foreach (var subview in session.PreviewView.Subviews){
				subview.Frame = View.Bounds;
			}
		}


		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
		}

		partial void UIButton24_TouchUpInside(UIButton sender)
		{
			session.StartRtmpSessionWithURL("Your rtmp address","your key");
		}
	}
	public class CameraDelegate : VCSessionDelegate
	{
		public override void ConnectionStatusChanged(VCSessionState sessionState)
		{
			switch (sessionState)
			{
				case VCSessionState.PreviewStarted:
					Console.WriteLine("Preview Started");	
					break;
				case VCSessionState.Starting:
					Console.WriteLine("Starting");	
					break;
				case VCSessionState.Started:
					Console.WriteLine("Started");
					break;
				case VCSessionState.Error:
					Console.WriteLine("Error");
					break;
				case VCSessionState.Ended:
					Console.WriteLine("Ended");
					break;
                                default:
                                        break;
			};
		}
	}
}
