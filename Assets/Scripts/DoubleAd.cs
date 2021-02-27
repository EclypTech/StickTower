using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine.UI;
using System;

public class DoubleAd : MonoBehaviour
{
    private RewardedAd rewarded;
    private GameObject gameOverCanvas;
    private GameObject mainCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas = GameObject.Find("GameOverCanvas(Clone)");
        mainCamera = GameObject.Find("Main Camera");

        //mainCamera.GetComponent<DoubleAd>().rewardedAd = new RewardedAd(mainCamera.GetComponent<DoubleInit>().adUnitId);
        rewarded = mainCamera.GetComponent<DoubleInit>().rewardedAd;

        
        // Called when an ad request has successfully loaded.
        rewarded.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        rewarded.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        rewarded.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
        rewarded.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        rewarded.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        rewarded.OnAdClosed += HandleRewardedAdClosed;
    }


    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        Debug.Log("reklam yüklendi");
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        Debug.Log("reklam yüklenemedi");
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        Debug.Log("reklam açýldý");
        
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        Debug.Log("reklam gösterilirken bir hata oluþtu");
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        this.CreateAndLoadRewardedAd();
        
        MonoBehaviour.print("HandleRewardedAdClosed event received");
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        gameOverCanvas = GameObject.Find("GameOverCanvas(Clone)");
        gameOverCanvas.GetComponent<GameOver>().DoubleOpal();
    }

    public void CreateAndLoadRewardedAd()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3693789240473561/2535926559";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
            string adUnitId = "unexpected_platform";
#endif

        this.rewarded = new RewardedAd(adUnitId);

        this.rewarded.OnAdLoaded += HandleRewardedAdLoaded;
        this.rewarded.OnUserEarnedReward += HandleUserEarnedReward;
        this.rewarded.OnAdClosed += HandleRewardedAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewarded.LoadAd(request);
    }


    public void UserChoseToWatchAd()
    {
        if (rewarded.IsLoaded())
        {
            rewarded.Show();
        }
    }
}
