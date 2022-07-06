using UnityEngine;
using UnityEngine.SceneManagement;

public class benitohutchison : MonoBehaviour
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

    public void carolinagranados()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
