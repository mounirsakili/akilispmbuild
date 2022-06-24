using UnityEngine;
using UnityEngine.SceneManagement;

public class nicolasberman : MonoBehaviour
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

    public void valariemcgrath()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
