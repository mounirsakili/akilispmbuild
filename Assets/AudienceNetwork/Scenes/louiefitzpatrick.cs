using UnityEngine;
using UnityEngine.SceneManagement;

public class louiefitzpatrick : MonoBehaviour
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

    public void lorirandall()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
