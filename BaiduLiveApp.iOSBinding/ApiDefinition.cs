using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
//using VideoCore;
using AVFoundation;


namespace BaiduLiveApp.iOSBinding
{
	[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double VideoCoreVersionNumber;
		[Field("VideoCoreVersionNumber", "__Internal")]
		double VideoCoreVersionNumber { get; }

		// extern const unsigned char [] VideoCoreVersionString;
		//[Field("VideoCoreVersionString", "__Internal")]
		//byte[] VideoCoreVersionString { get; }
	}

	// @interface VCSimpleSessionConfiguration : NSObject
	[BaseType(typeof(NSObject))]
	interface VCSimpleSessionConfiguration
	{
		// @property (assign, nonatomic) BOOL videoEnabled;
		[Export("videoEnabled")]
		bool VideoEnabled { get; set; }

		// @property (assign, nonatomic) CGSize videoSize;
		[Export("videoSize", ArgumentSemantic.Assign)]
		CGSize VideoSize { get; set; }

		// @property (assign, nonatomic) NSUInteger bitrate;
		[Export("bitrate")]
		nuint Bitrate { get; set; }

		// @property (assign, nonatomic) NSUInteger fps;
		[Export("fps")]
		nuint Fps { get; set; }

		// @property (assign, nonatomic) VCH264Profile profile;
		[Export("profile", ArgumentSemantic.Assign)]
		VCH264Profile Profile { get; set; }

		// @property (assign, nonatomic) NSUInteger gopLength;
		[Export("gopLength")]
		nuint GopLength { get; set; }

		// @property (assign, nonatomic) BOOL audioEnabled;
		[Export("audioEnabled")]
		bool AudioEnabled { get; set; }

		// @property (assign, nonatomic) VCAudioBitrate audioBitrate;
		[Export("audioBitrate", ArgumentSemantic.Assign)]
		VCAudioBitrate AudioBitrate { get; set; }

		// @property (assign, nonatomic) NSUInteger audioChannelCount;
		[Export("audioChannelCount")]
		nuint AudioChannelCount { get; set; }

		// @property (assign, nonatomic) VCAudioSampleRate audioSampleRate;
		[Export("audioSampleRate", ArgumentSemantic.Assign)]
		VCAudioSampleRate AudioSampleRate { get; set; }

		// @property (assign, nonatomic) VCCameraState cameraDevice;
		[Export("cameraDevice", ArgumentSemantic.Assign)]
		VCCameraState CameraDevice { get; set; }

		// @property (assign, nonatomic) AVCaptureVideoOrientation cameraOrientation;
		[Export("cameraOrientation", ArgumentSemantic.Assign)]
		AVCaptureVideoOrientation CameraOrientation { get; set; }

		// @property (assign, nonatomic) BOOL torch;
		[Export("torch")]
		bool Torch { get; set; }

		// @property (assign, nonatomic) BOOL continuousAutofocus;
		[Export("continuousAutofocus")]
		bool ContinuousAutofocus { get; set; }

		// @property (assign, nonatomic) BOOL continuousExposure;
		[Export("continuousExposure")]
		bool ContinuousExposure { get; set; }

		// @property (assign, nonatomic) float micGain;
		[Export("micGain")]
		float MicGain { get; set; }

		// @property (assign, nonatomic) BOOL pauseAudioWhenInBackground;
		[Export("pauseAudioWhenInBackground")]
		bool PauseAudioWhenInBackground { get; set; }

		// @property (assign, nonatomic) BOOL useAdaptiveBitrate;
		[Export("useAdaptiveBitrate")]
		bool UseAdaptiveBitrate { get; set; }

		// @property (assign, nonatomic) NSUInteger sensibility;
		[Export("sensibility")]
		nuint Sensibility { get; set; }

		// @property (assign, nonatomic) NSUInteger maxBitrate;
		[Export("maxBitrate")]
		nuint MaxBitrate { get; set; }

		// @property (assign, nonatomic) NSUInteger minBitrate;
		[Export("minBitrate")]
		nuint MinBitrate { get; set; }
	}

	// @protocol VCSessionDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface VCSessionDelegate
	{
		// @required -(void)connectionStatusChanged:(VCSessionState)sessionState;
		[Abstract]
		[Export("connectionStatusChanged:")]
		void ConnectionStatusChanged(VCSessionState sessionState);

		// @optional -(void)didAddCameraSource:(VCSimpleSession *)session;
		[Export("didAddCameraSource:")]
		void DidAddCameraSource(VCSimpleSession session);

		// @optional -(void)onError:(VCErrorCode)error;
		[Export("onError:")]
		void OnError(VCErrorCode error);
	}

	// @interface VCSimpleSession : NSObject
	[BaseType(typeof(NSObject))]
	interface VCSimpleSession
	{
		// @property (readonly, nonatomic) VCSessionState rtmpSessionState;
		[Export("rtmpSessionState")]
		VCSessionState RtmpSessionState { get; }

		// @property (readonly, nonatomic, strong) UIView * previewView;
		[Export("previewView", ArgumentSemantic.Strong)]
		UIView PreviewView { get; }

		// @property (assign, nonatomic) CGSize videoSize;
		[Export("videoSize", ArgumentSemantic.Assign)]
		CGSize VideoSize { get; set; }

		// @property (assign, nonatomic) int bitrate;
		[Export("bitrate")]
		int Bitrate { get; set; }

		// @property (assign, nonatomic) int fps;
		[Export("fps")]
		int Fps { get; set; }

		// @property (assign, nonatomic) AVCaptureVideoOrientation cameraOrientation;
		[Export("cameraOrientation", ArgumentSemantic.Assign)]
		AVCaptureVideoOrientation CameraOrientation { get; set; }

		// @property (assign, nonatomic) VCCameraState cameraState;
		[Export("cameraState", ArgumentSemantic.Assign)]
		VCCameraState CameraState { get; set; }

		// @property (assign, nonatomic) BOOL torch;
		[Export("torch")]
		bool Torch { get; set; }

		// @property (assign, nonatomic) float videoZoomFactor;
		[Export("videoZoomFactor")]
		float VideoZoomFactor { get; set; }

		// @property (assign, nonatomic) int audioChannelCount;
		[Export("audioChannelCount")]
		int AudioChannelCount { get; set; }

		// @property (assign, nonatomic) float audioSampleRate;
		[Export("audioSampleRate")]
		float AudioSampleRate { get; set; }

		// @property (assign, nonatomic) float micGain;
		[Export("micGain")]
		float MicGain { get; set; }

		// @property (assign, nonatomic) float musicGain;
		[Export("musicGain")]
		float MusicGain { get; set; }

		// @property (assign, nonatomic) CGPoint focusPointOfInterest;
		[Export("focusPointOfInterest", ArgumentSemantic.Assign)]
		CGPoint FocusPointOfInterest { get; set; }

		// @property (assign, nonatomic) CGPoint exposurePointOfInterest;
		[Export("exposurePointOfInterest", ArgumentSemantic.Assign)]
		CGPoint ExposurePointOfInterest { get; set; }

		// @property (assign, nonatomic) BOOL continuousAutofocus;
		[Export("continuousAutofocus")]
		bool ContinuousAutofocus { get; set; }

		// @property (assign, nonatomic) BOOL continuousExposure;
		[Export("continuousExposure")]
		bool ContinuousExposure { get; set; }

		// @property (readonly, nonatomic) int estimatedThroughput;
		[Export("estimatedThroughput")]
		int EstimatedThroughput { get; }

		// @property (assign, nonatomic) VCAspectMode aspectMode;
		[Export("aspectMode", ArgumentSemantic.Assign)]
		VCAspectMode AspectMode { get; set; }

		// @property (assign, nonatomic) VCFilter filter;
		[Export("filter", ArgumentSemantic.Assign)]
		VCFilter Filter { get; set; }

		[Wrap("WeakDelegate")]
		VCSessionDelegate Delegate { get; set; }

		// @property (assign, nonatomic) id<VCSessionDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) BOOL useAdaptiveBitrate;
		[Export("useAdaptiveBitrate")]
		bool UseAdaptiveBitrate { get; set; }

		// @property (assign, nonatomic) int sensibility;
		[Export("sensibility")]
		int Sensibility { get; set; }

		// @property (assign, nonatomic) int maxBitrate;
		[Export("maxBitrate")]
		int MaxBitrate { get; set; }

		// @property (assign, nonatomic) int minBitrate;
		[Export("minBitrate")]
		int MinBitrate { get; set; }

		// @property (assign, nonatomic) VCH264Profile profile;
		[Export("profile", ArgumentSemantic.Assign)]
		VCH264Profile Profile { get; set; }

		// @property (assign, nonatomic) NSUInteger gopLength;
		[Export("gopLength")]
		nuint GopLength { get; set; }

		// @property (assign, nonatomic) VCBeautyLevel beautyLevel;
		[Export("beautyLevel", ArgumentSemantic.Assign)]
		VCBeautyLevel BeautyLevel { get; set; }

		// -(instancetype)initWithConfiguration:(VCSimpleSessionConfiguration *)configuration;
		[Export("initWithConfiguration:")]
		IntPtr Constructor(VCSimpleSessionConfiguration configuration);

		// -(void)startRtmpSessionWithURL:(NSString *)streamUrl;
		[Export("startRtmpSessionWithURL:")]
		void StartRtmpSessionWithURL(string streamUrl);

		// -(void)startRtmpSessionWithURL:(NSString *)rtmpUrl andStreamKey:(NSString *)streamKey;
		[Export("startRtmpSessionWithURL:andStreamKey:")]
		void StartRtmpSessionWithURL(string rtmpUrl, string streamKey);

		// -(void)switchCamera;
		[Export("switchCamera")]
		void SwitchCamera();

		// -(float)getMaxZoomLevel;
		[Export("getMaxZoomLevel")]
		//[Verify(MethodToProperty)]
		float MaxZoomLevel { get; }

		// -(void)zoomVideo:(float)zoomFactor withCenter:(CGPoint)center;
		[Export("zoomVideo:withCenter:")]
		void ZoomVideo(float zoomFactor, CGPoint center);

		// -(void)endRtmpSession;
		[Export("endRtmpSession")]
		void EndRtmpSession();

		// -(double)getCurrentUploadBandwidthKbps;
		[Export("getCurrentUploadBandwidthKbps")]
		//[Verify(MethodToProperty)]
		double CurrentUploadBandwidthKbps { get; }

		// -(double)getRealtimeBitrate;
		[Export("getRealtimeBitrate")]
		//[Verify(MethodToProperty)]
		double RealtimeBitrate { get; }

		// -(double)getRealtimeFPS;
		[Export("getRealtimeFPS")]
		//[Verify(MethodToProperty)]
		double RealtimeFPS { get; }

		// -(void)setAudioEnabled:(BOOL)isEnable;
		[Export("setAudioEnabled:")]
		void SetAudioEnabled(bool isEnable);

		// -(void)setVideoEnabled:(BOOL)isEnable;
		[Export("setVideoEnabled:")]
		void SetVideoEnabled(bool isEnable);

		// -(void)enableBeautyEffect:(BOOL)isEnable;
		[Export("enableBeautyEffect:")]
		void EnableBeautyEffect(bool isEnable);

		// -(void)setBeatyEffect:(float)bright withSmooth:(float)smooth withPink:(float)pink;
		[Export("setBeatyEffect:withSmooth:withPink:")]
		void SetBeatyEffect(float bright, float smooth, float pink);

		// -(UIImage *)getScreenShot;
		[Export("getScreenShot")]
		//[Verify(MethodToProperty)]
		UIImage ScreenShot { get; }

		// -(void)addPixelBufferSource:(UIImage *)image withRect:(CGRect)rect;
		[Export("addPixelBufferSource:withRect:")]
		void AddPixelBufferSource(UIImage image, CGRect rect);
	}

	// @interface DEPRECATED (VCSimpleSession)
	[Category]
	[BaseType(typeof(VCSimpleSession))]
	interface VCSimpleSession_DEPRECATED
	{
		// -(instancetype)initWithVideoSize:(CGSize)videoSize frameRate:(int)fps bitrate:(int)bps;
		[Export("initWithVideoSize:frameRate:bitrate:")]
		IntPtr initWithVideoSizeframeRate(CGSize videoSize, int fps, int bps);

		// -(instancetype)initWithVideoSize:(CGSize)videoSize frameRate:(int)fps bitrate:(int)bps useInterfaceOrientation:(BOOL)useInterfaceOrientation;
		[Export("initWithVideoSize:frameRate:bitrate:useInterfaceOrientation:")]
		IntPtr initWithVideoSizeOrientation(CGSize videoSize, int fps, int bps, bool useInterfaceOrientation);

		// -(instancetype)initWithVideoSize:(CGSize)videoSize frameRate:(int)fps bitrate:(int)bps useInterfaceOrientation:(BOOL)useInterfaceOrientation cameraState:(VCCameraState)cameraState;
		[Export("initWithVideoSize:frameRate:bitrate:useInterfaceOrientation:cameraState:")]
		IntPtr initWithVideoSizeState(CGSize videoSize, int fps, int bps, bool useInterfaceOrientation, VCCameraState cameraState);

		// -(instancetype)initWithVideoSize:(CGSize)videoSize frameRate:(int)fps bitrate:(int)bps useInterfaceOrientation:(BOOL)useInterfaceOrientation cameraState:(VCCameraState)cameraState aspectMode:(VCAspectMode)aspectMode;
		[Export("initWithVideoSize:frameRate:bitrate:useInterfaceOrientation:cameraState:aspectMode:")]
		IntPtr initWithVideoSizeMode(CGSize videoSize, int fps, int bps, bool useInterfaceOrientation, VCCameraState cameraState, VCAspectMode aspectMode);
	}
}
