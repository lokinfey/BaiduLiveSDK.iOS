using System;
using ObjCRuntime;

namespace BaiduLiveApp.iOSBinding
{
	[Native]
public enum VCCameraState : ulong
{
	Front,
	Back
}

[Native]
public enum VCH264Profile : ulong
{
	Baseline,
	High
}

[Native]
public enum VCAudioSampleRate : ulong
{
	VCAudioSampleRate22050 = 22050,
	VCAudioSampleRate44100 = 44100
}

[Native]
public enum VCAudioBitrate : ulong
{
	VCAudioBitrate64000 = 64000,
	VCAudioBitrate96000 = 96000,
	VCAudioBitrate128000 = 128000,
	VCAudioBitrate192000 = 192000
}

[Native]
public enum VCBeautyLevel : ulong
{
	None,
	Natural,
	Whiten,
	Pink,
	Magic
}

[Native]
public enum VCSessionState : ulong
{
	None,
	PreviewStarted,
	Starting,
	Started,
	Ended,
	Error
}

[Native]
public enum VCAspectMode : long
{
	Fit,
	Fill,
	Scale
}

[Native]
public enum VCFilter : long
{
	Normal,
	Gray,
	InvertColors,
	Sepia,
	Fisheye,
	Glow,
	GussBlur
}

[Native]
public enum VCErrorCode : long
{
	PrepareSessionFailed = -1,
	ConnectToServerFailed = -2,
	DisconnectFromServerFailed = -3,
	OpenMicFailed = -4,
	OpenCameraFailed = -5,
	UnknownStreamingError = -6,
	WeakConnection = -7,
	ServerNetworkError = -8,
	LocalNetworkError = -9
}

}
