using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using GoogleMobileAds.Api;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[StructLayout(3)]
public class AdManager : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x992494", Offset = "0x992494", VA = "0x992494")]
	private void Awake()
	{
		bool flag = AdManager.instance;
		GameObject obj;
		UnityEngine.Object.DestroyImmediate(obj);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000207C File Offset: 0x0000027C
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x9925A0", Offset = "0x9925A0", VA = "0x9925A0")]
	private void Start()
	{
		base.gameObject.name = "AdManager";
		this.loadRewardVideo();
		this.loadInterstitial();
		this.showBannerAd();
		EventHandler<Reward> eventHandler;
		AdManager.rewardBasedVideo.OnAdRewarded += eventHandler;
		EventHandler<EventArgs> eventHandler2;
		AdManager.rewardBasedVideo.OnAdClosed += eventHandler2;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000020C8 File Offset: 0x000002C8
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x992A9C", Offset = "0x992A9C", VA = "0x992A9C")]
	private void OnGUI()
	{
		if (this.isDebug)
		{
			this.loadRewardVideo();
			this.showBannerAd();
			this.showInterstitial();
			if ("Show Full" == null)
			{
			}
			this.showRewardVideo();
			if ("Show Video" == null)
			{
			}
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002104 File Offset: 0x00000304
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x992EC0", Offset = "0x992EC0", VA = "0x992EC0")]
	private void onInterstitialEvent(object sender, EventArgs args)
	{
		MonoBehaviour.print("OnAdLoaded event received.");
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000211C File Offset: 0x0000031C
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x992F0C", Offset = "0x992F0C", VA = "0x992F0C")]
	private void onInterstitialCloseEvent(object sender, EventArgs args)
	{
		MonoBehaviour.print("OnAdLoaded event received.");
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002134 File Offset: 0x00000334
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x992F58", Offset = "0x992F58", VA = "0x992F58")]
	private void onBannerEvent(string eventName, string msg)
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002144 File Offset: 0x00000344
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x992F5C", Offset = "0x992F5C", VA = "0x992F5C")]
	private void onadclosed(object sender, EventArgs args)
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002154 File Offset: 0x00000354
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x992F64", Offset = "0x992F64", VA = "0x992F64")]
	private void onRewardedVideoEvent(object sender, Reward args)
	{
		string <Type>k__BackingField = args.<Type>k__BackingField;
		string message;
		MonoBehaviour.print(message);
		if (this.Hint)
		{
			throw new NullReferenceException();
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000218C File Offset: 0x0000038C
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x992954", Offset = "0x992954", VA = "0x992954")]
	public void showBannerAd()
	{
		long num = 1L;
		bool flag = this.isOnTop;
		string text = this.bannerAdId;
		if (flag)
		{
			if (num == 0L)
			{
			}
			return;
		}
		BannerView bannerView;
		AdManager.bannerView = bannerView;
		AdRequest request = new AdRequest.Builder().Build();
		AdManager.bannerView.LoadAd(request);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000021D8 File Offset: 0x000003D8
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x9927E8", Offset = "0x9927E8", VA = "0x9927E8")]
	public void loadInterstitial()
	{
		AdManager.interstitial = new InterstitialAd(this.interstitialAdId);
		AdRequest request = new AdRequest.Builder().Build();
		AdManager.interstitial.LoadAd(request);
		EventHandler<EventArgs> eventHandler;
		AdManager.interstitial.OnAdOpening += eventHandler;
		EventHandler<EventArgs> eventHandler2;
		AdManager.interstitial.OnAdClosed += eventHandler2;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002228 File Offset: 0x00000428
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x992D4C", Offset = "0x992D4C", VA = "0x992D4C")]
	public void showInterstitial()
	{
		bool flag = AdManager.interstitial.IsLoaded();
		AdManager.interstitial.Show();
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002258 File Offset: 0x00000458
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x9926D4", Offset = "0x9926D4", VA = "0x9926D4")]
	public void loadRewardVideo()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		AdManager.rewardBasedVideo = RewardBasedVideoAd.instance;
		AdRequest request = new AdRequest.Builder().Build();
		RewardBasedVideoAd rewardBasedVideoAd = AdManager.rewardBasedVideo;
		string adUnitId = this.rewardVideoAdId;
		rewardBasedVideoAd.LoadAd(request, adUnitId);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0000229C File Offset: 0x0000049C
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x992DD8", Offset = "0x992DD8", VA = "0x992DD8")]
	public void showRewardVideo()
	{
		bool flag = AdManager.rewardBasedVideo.IsLoaded();
		AdManager.rewardBasedVideo.Show();
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000022CC File Offset: 0x000004CC
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x992E64", Offset = "0x992E64", VA = "0x992E64")]
	public void hideBannerAd()
	{
		AdManager.bannerView.Hide();
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000022EC File Offset: 0x000004EC
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x9930E8", Offset = "0x9930E8", VA = "0x9930E8")]
	public AdManager()
	{
	}

	// Token: 0x04000001 RID: 1
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000001")]
	public bool forreward;

	// Token: 0x04000002 RID: 2
	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000002")]
	public bool IsPortrait;

	// Token: 0x04000003 RID: 3
	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x4000003")]
	public bool IsMenuLoaded;

	// Token: 0x04000004 RID: 4
	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Token(Token = "0x4000004")]
	public bool Hint;

	// Token: 0x04000005 RID: 5
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000005")]
	public int count;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	public static AdManager instance;

	// Token: 0x04000007 RID: 7
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000007")]
	public bool IconLoaded;

	// Token: 0x04000008 RID: 8
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000008")]
	[Header("Admob Id----")]
	public string bannerAdId;

	// Token: 0x04000009 RID: 9
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000009")]
	[Header("Admob Id----")]
	public string interstitialAdId;

	// Token: 0x0400000A RID: 10
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000A")]
	[Header("Admob Id----")]
	public string rewardVideoAdId;

	// Token: 0x0400000B RID: 11
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400000B")]
	public bool isDebug;

	// Token: 0x0400000C RID: 12
	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Token(Token = "0x400000C")]
	[Header("BannerPos----")]
	public bool isOnTop;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	public static RewardBasedVideoAd rewardBasedVideo;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	private static BannerView bannerView;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	private static InterstitialAd interstitial;

	// Token: 0x04000010 RID: 16
	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000010")]
	public int adscount;
}
