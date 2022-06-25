using UnityEngine;
using UnityEngine.SceneManagement;

public class garycagle : MonoBehaviour
{
    
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
                return;
            }
        }
    }

    public void maudemelton()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
