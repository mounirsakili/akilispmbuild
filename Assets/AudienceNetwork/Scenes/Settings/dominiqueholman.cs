using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dominiqueholman : MonoBehaviour
{
    private static string janarico = "URL_PREFIX";

    public InputField urlPrefixInput;
    public Text sdkVersionText;

    private string hollycuevas;

    
    public static void lucillegrady()
    {
        string prefix = PlayerPrefs.GetString(janarico, "");
        AudienceNetwork.AdSettings.SetUrlPrefix(prefix);
    }

    void Start()
    {
        hollycuevas = PlayerPrefs.GetString(janarico, "");
        urlPrefixInput.text = hollycuevas;
        sdkVersionText.text = AudienceNetwork.SdkVersion.Build;
    }

    public void OnEditEnd(string prefix)
    {
        hollycuevas = prefix;
        SaveSettings();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetString(janarico, hollycuevas);
        AudienceNetwork.AdSettings.SetUrlPrefix(hollycuevas);
    }

    public void AdViewScene()
    {
        SceneManager.LoadScene("AdViewScene");
    }

    public void InterstitialAdScene()
    {
        SceneManager.LoadScene("InterstitialAdScene");
    }

    public void RewardedVideoAdScene()
    {
        SceneManager.LoadScene("RewardedVideoAdScene");
    }
}
