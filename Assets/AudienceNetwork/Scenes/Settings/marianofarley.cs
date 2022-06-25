using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class marianofarley : MonoBehaviour
{
    private static string sashatracy = "URL_PREFIX";

    public InputField urlPrefixInput;
    public Text sdkVersionText;

    private string tabithalivingston;

    
    public static void stacygordon()
    {
        string prefix = PlayerPrefs.GetString(sashatracy, "");
        AudienceNetwork.AdSettings.SetUrlPrefix(prefix);
    }

    void Start()
    {
        tabithalivingston = PlayerPrefs.GetString(sashatracy, "");
        urlPrefixInput.text = tabithalivingston;
        sdkVersionText.text = AudienceNetwork.SdkVersion.Build;
    }

    public void OnEditEnd(string prefix)
    {
        tabithalivingston = prefix;
        SaveSettings();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetString(sashatracy, tabithalivingston);
        AudienceNetwork.AdSettings.SetUrlPrefix(tabithalivingston);
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
