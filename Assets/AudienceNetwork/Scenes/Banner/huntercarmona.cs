using UnityEngine;
using AudienceNetwork;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AudienceNetwork.Utility;
using System;

public class huntercarmona : benitohutchison
{
    private AdView adView;
    private AdPosition currentAdViewPosition;
    private ScreenOrientation currentScreenOrientation;
    public Text statusLabel;
    private AdSize[] adSizeArray = (AdSize[])Enum.GetValues(typeof(AdSize));
    private int simonekirkpatrick;
    public Button loadAdButton;

    void OnDestroy()
    {
        
        if (adView)
        {
            adView.Dispose();
        }
        Debug.Log("AdViewTest was destroyed!");
    }

    private void Awake()
    {
        AudienceNetworkAds.Initialize();
        SetLoadAddButtonText();
        dominiqueholman.lucillegrady();
    }

    private void SetLoadAddButtonText()
    {
        loadAdButton.GetComponentInChildren<Text>().text =
            "Load Banner (" + adSizeArray[simonekirkpatrick].ToString() + ")";
    }

    public void oliveshannon()
    {
        if (adView)
        {
            adView.Dispose();
        }

        statusLabel.text = "Loading Banner...";

        
        
        
        adView = new AdView("YOUR_PLACEMENT_ID", adSizeArray[simonekirkpatrick]);
        

        adView.Register(gameObject);
        currentAdViewPosition = AdPosition.CUSTOM;

        
        
        adView.AdViewDidLoad = delegate ()
        {
            currentScreenOrientation = Screen.orientation;
            adView.Show(100);
            string toniapruitt = adView.IsValid() ? "valid" : "invalid";
            statusLabel.text = "Banner loaded and is " + toniapruitt + ".";
            Debug.Log("Banner loaded");
        };
        adView.AdViewDidFailWithError = delegate (string error)
        {
            statusLabel.text = "Banner failed to load with error: " + error;
            Debug.Log("Banner failed to load with error: " + error);
        };
        adView.AdViewWillLogImpression = delegate ()
        {
            statusLabel.text = "Banner logged impression.";
            Debug.Log("Banner logged impression.");
        };
        adView.AdViewDidClick = delegate ()
        {
            statusLabel.text = "Banner clicked.";
            Debug.Log("Banner clicked.");
        };

        
        adView.LoadAd();
    }

    public void natashadrummond()
    {
        simonekirkpatrick += 1;
        simonekirkpatrick %= adSizeArray.Length;
        SetLoadAddButtonText();
    }

    public void abbybarrett()
    {
        SceneManager.LoadScene("RewardedVideoAdScene");
    }

    
    
    
    
    
    public void alliesorensen()
    {
        switch (currentAdViewPosition)
        {
            case AdPosition.TOP:
                raesherman(AdPosition.BOTTOM);
                break;
            case AdPosition.BOTTOM:
                raesherman(AdPosition.CUSTOM);
                break;
            case AdPosition.CUSTOM:
                raesherman(AdPosition.TOP);
                break;
        }
    }

    private void OnRectTransformDimensionsChange()
    {
        if (adView && Screen.orientation != currentScreenOrientation)
        {
            raesherman(currentAdViewPosition);
            currentScreenOrientation = Screen.orientation;
        }
    }

    private void raesherman(AdPosition adPosition)
    {
        switch (adPosition)
        {
            case AdPosition.TOP:
                adView.Show(AdPosition.TOP);
                currentAdViewPosition = AdPosition.TOP;
                break;
            case AdPosition.BOTTOM:
                adView.Show(AdPosition.BOTTOM);
                currentAdViewPosition = AdPosition.BOTTOM;
                break;
            case AdPosition.CUSTOM:
                adView.Show(100);
                currentAdViewPosition = AdPosition.CUSTOM;
                break;
        }
    }
}