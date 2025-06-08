using UnityEngine;
using System;

public class AdsManager : MonoBehaviour
{
    public static AdsManager Instance;
    public bool disableAds;

#if UNITY_ANDROID
    private string appKey = "your_app_key_here"; // Replace with your IronSource App Key
#endif

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        IronSource.Agent.validateIntegration();
        IronSource.Agent.init(appKey);
    }

    private void OnEnable()
    {
        IronSourceEvents.onSdkInitializationCompletedEvent += OnSdkInitialized;

        // Interstitial
        IronSourceInterstitialEvents.onAdReadyEvent += OnInterstitialReady;
        IronSourceInterstitialEvents.onAdLoadFailedEvent += OnInterstitialLoadFailed;
        IronSourceInterstitialEvents.onAdOpenedEvent += OnInterstitialOpened;
        IronSourceInterstitialEvents.onAdClosedEvent += OnInterstitialClosed;

        // Rewarded
        IronSourceRewardedVideoEvents.onAdAvailableEvent += OnRewardedAvailable;
        IronSourceRewardedVideoEvents.onAdUnavailableEvent += OnRewardedUnavailable;
        IronSourceRewardedVideoEvents.onAdOpenedEvent += OnRewardedOpened;
        IronSourceRewardedVideoEvents.onAdClosedEvent += OnRewardedClosed;
        IronSourceRewardedVideoEvents.onAdRewardedEvent += OnRewardedRewarded;
        IronSourceRewardedVideoEvents.onAdShowFailedEvent += OnRewardedShowFailed;

        // Banner
        IronSourceBannerEvents.onAdLoadedEvent += OnBannerLoaded;
        IronSourceBannerEvents.onAdLoadFailedEvent += OnBannerLoadFailed;
    }

    private void OnApplicationPause(bool isPaused)
    {
        IronSource.Agent.onApplicationPause(isPaused);
    }

    private void OnSdkInitialized()
    {
        Debug.Log("IronSource SDK Initialized.");
        LoadInterstitial(); // Load interstitial on startup
        LoadBanner();       // Load banner on startup
    }

    #region Rewarded Video

    public void ShowRewardedVideo(Action onRewarded = null)
    {   if(!disableAds){
        if (IronSource.Agent.isRewardedVideoAvailable())
        {
            this.onUserRewarded = onRewarded;
            IronSource.Agent.showRewardedVideo();
        }
        else
        {
            Debug.Log("Rewarded Video not available.");
        }
    }
    }

    private Action onUserRewarded;

    void OnRewardedAvailable(IronSourceAdInfo adInfo)
    {
        Debug.Log("Rewarded Video Available");
    }

    void OnRewardedUnavailable()
    {
        Debug.Log("Rewarded Video Unavailable");
    }

    void OnRewardedOpened(IronSourceAdInfo adInfo)
    {
        Debug.Log("Rewarded Video Opened");
    }

    void OnRewardedClosed(IronSourceAdInfo adInfo)
    {
        Debug.Log("Rewarded Video Closed");
    }

    void OnRewardedRewarded(IronSourcePlacement placement, IronSourceAdInfo adInfo)
    {
        Debug.Log("User Rewarded: " + placement.getRewardName());
        onUserRewarded?.Invoke();
        onUserRewarded = null;
    }

    void OnRewardedShowFailed(IronSourceError error, IronSourceAdInfo adInfo)
    {
        Debug.LogError("Rewarded Video Failed: " + error.getDescription());
    }

    #endregion

    #region Interstitial

    public void LoadInterstitial()
    {
        IronSource.Agent.loadInterstitial();
    }

    public void ShowInterstitial()
    {   if(!disableAds){
        if (IronSource.Agent.isInterstitialReady())
        {
            IronSource.Agent.showInterstitial();
        }
        else
        {
            Debug.Log("Interstitial not ready");
        }
    }
    }

    void OnInterstitialReady(IronSourceAdInfo adInfo)
    {
        Debug.Log("Interstitial Ready");
    }

    void OnInterstitialLoadFailed(IronSourceError error)
    {
        Debug.LogError("Interstitial Load Failed: " + error.getDescription());
    }

    void OnInterstitialOpened(IronSourceAdInfo adInfo)
    {
        Debug.Log("Interstitial Opened");
    }

    void OnInterstitialClosed(IronSourceAdInfo adInfo)
    {
        Debug.Log("Interstitial Closed");
        LoadInterstitial(); // Reload after close
    }

    #endregion

    #region Banner

    public void LoadBanner()
    {  if(!disableAds)
        IronSource.Agent.loadBanner(IronSourceBannerSize.BANNER, IronSourceBannerPosition.BOTTOM);
    }

    public void DestroyBanner()
    {
        IronSource.Agent.destroyBanner();
    }

    void OnBannerLoaded(IronSourceAdInfo adInfo)
    {
        Debug.Log("Banner Loaded");
    }

    void OnBannerLoadFailed(IronSourceError error)
    {
        Debug.LogError("Banner Load Failed: " + error.getDescription());
    }

    #endregion
}
