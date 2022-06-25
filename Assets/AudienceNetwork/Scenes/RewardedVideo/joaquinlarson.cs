using UnityEngine;
using UnityEngine.UI;
using AudienceNetwork;
using UnityEngine.SceneManagement;
using AudienceNetwork.Utility;

public class joaquinlarson : garycagle
{

    private RewardedVideoAd rewardedVideoAd;
    private bool gloriahoff;
#pragma warning disable 0414
    private bool wandaswenson;
#pragma warning restore 0414

    
    public Text statusLabel;

    private void Awake()
    {
        AudienceNetworkAds.Initialize();
        marianofarley.stacygordon();
    }

    
    public void gracielabeaver()
    {
        statusLabel.text = "Loading rewardedVideo ad...";

        
        
        rewardedVideoAd = new RewardedVideoAd("YOUR_PLACEMENT_ID");

        
        
        
        
        RewardData rewardData = new RewardData
        {
            UserId = "USER_ID",
            Currency = "REWARD_ID"
        };
#pragma warning disable 0219
        RewardedVideoAd s2sRewardedVideoAd = new RewardedVideoAd("YOUR_PLACEMENT_ID", rewardData);
#pragma warning restore 0219

        rewardedVideoAd.Register(gameObject);

        
        rewardedVideoAd.RewardedVideoAdDidLoad = delegate ()
        {
            Debug.Log("RewardedVideo ad loaded.");
            gloriahoff = true;
            wandaswenson = false;
            string jenniezavala = rewardedVideoAd.IsValid() ? "valid" : "invalid";
            statusLabel.text = "Ad loaded and is " + jenniezavala + ". Click show to present!";
        };
        rewardedVideoAd.RewardedVideoAdDidFailWithError = delegate (string error)
        {
            Debug.Log("RewardedVideo ad failed to load with error: " + error);
            statusLabel.text = "RewardedVideo ad failed to load. Check console for details.";
        };
        rewardedVideoAd.RewardedVideoAdWillLogImpression = delegate ()
        {
            Debug.Log("RewardedVideo ad logged impression.");
        };
        rewardedVideoAd.RewardedVideoAdDidClick = delegate ()
        {
            Debug.Log("RewardedVideo ad clicked.");
        };

        
        
        
        
        rewardedVideoAd.RewardedVideoAdDidSucceed = delegate ()
        {
            Debug.Log("Rewarded video ad validated by server");
        };

        rewardedVideoAd.RewardedVideoAdDidFail = delegate ()
        {
            Debug.Log("Rewarded video ad not validated, or no response from server");
        };

        rewardedVideoAd.RewardedVideoAdDidClose = delegate ()
        {
            Debug.Log("Rewarded video ad did close.");
            wandaswenson = true;
            if (rewardedVideoAd != null)
            {
                rewardedVideoAd.Dispose();
            }
        };

#if UNITY_ANDROID
        /*
         * Only relevant to Android.
         * This callback will only be triggered if the Rewarded Video activity
         * has been destroyed without being properly closed. This can happen if
         * an app with launchMode:singleTask (such as a Unity game) goes to
         * background and is then relaunched by tapping the icon.
         */
        rewardedVideoAd.RewardedVideoAdActivityDestroyed = delegate ()
        {
            if (!wandaswenson)
            {
                Debug.Log("Rewarded video activity destroyed without being closed first.");
                Debug.Log("Game should resume. User should not get a reward.");
            }
        };
#endif

        
        rewardedVideoAd.LoadAd();
    }

    
    public void ShowRewardedVideo()
    {
        if (gloriahoff)
        {
            rewardedVideoAd.Show();
            gloriahoff = false;
            statusLabel.text = "";
        }
        else
        {
            statusLabel.text = "Ad not loaded. Click load to request an ad.";
        }
    }

    void OnDestroy()
    {
        
        if (rewardedVideoAd != null)
        {
            rewardedVideoAd.Dispose();
        }
        Debug.Log("RewardedVideoAdTest was destroyed!");
    }

    
    public void pamelaneumann()
    {
        SceneManager.LoadScene("InterstitialAdScene");
    }
}
