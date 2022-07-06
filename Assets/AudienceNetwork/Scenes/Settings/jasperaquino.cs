using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class jasperaquino : MonoBehaviour
{
    private static string nellboggs = "URL_PREFIX";

    public InputField urlPrefixInput;
    public Text sdkVersionText;

    private string jannieshelton;

    
    public static void charlenefry()
    {
        string prefix = PlayerPrefs.GetString(nellboggs, "");
        AudienceNetwork.AdSettings.SetUrlPrefix(prefix);
    }

    void Start()
    {
        jannieshelton = PlayerPrefs.GetString(nellboggs, "");
        urlPrefixInput.text = jannieshelton;
        sdkVersionText.text = AudienceNetwork.SdkVersion.Build;
    }

    public void OnEditEnd(string prefix)
    {
        jannieshelton = prefix;
        SaveSettings();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetString(nellboggs, jannieshelton);
        AudienceNetwork.AdSettings.SetUrlPrefix(jannieshelton);
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
