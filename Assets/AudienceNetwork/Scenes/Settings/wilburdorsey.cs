using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class wilburdorsey : MonoBehaviour
{
    private static string carolgray = "URL_PREFIX";

    public InputField urlPrefixInput;
    public Text sdkVersionText;

    private string lilliandavison;

    
    public static void mablepham()
    {
        string prefix = PlayerPrefs.GetString(carolgray, "");
        AudienceNetwork.AdSettings.SetUrlPrefix(prefix);
    }

    void Start()
    {
        lilliandavison = PlayerPrefs.GetString(carolgray, "");
        urlPrefixInput.text = lilliandavison;
        sdkVersionText.text = AudienceNetwork.SdkVersion.Build;
    }

    public void OnEditEnd(string prefix)
    {
        lilliandavison = prefix;
        SaveSettings();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetString(carolgray, lilliandavison);
        AudienceNetwork.AdSettings.SetUrlPrefix(lilliandavison);
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
