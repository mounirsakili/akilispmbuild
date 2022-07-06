using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ralphmontalvo : MonoBehaviour
{

    int rhodawynn;
    AsyncOperation progress = null;
    Image progressBar;
    float kimcramer = 0;
    string josefinareece;



    
    void Start()
    {
        
        
        UnityEngine.Debug.Log("XReceived Start splashscene" + mikemackey.camillewhitman.ToString());
        if (mikemackey.camillewhitman)
        {
            josefinareece = "NotiSc";
        }
        else
        {
            josefinareece = shannonbrowning.Homenamescene  ;
        }
        
        
        

        
        if (PlayerPrefs.HasKey("appStartedNumber"))
        {
            rhodawynn = PlayerPrefs.GetInt("appStartedNumber");
        }
        else
        {
            rhodawynn = 0;
        }
        rhodawynn++;
        PlayerPrefs.SetInt("appStartedNumber", rhodawynn);
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        while (kimcramer < 5)
        {
            kimcramer += 0.05f;
            
            yield return new WaitForSeconds(0.025f);
        }
        UnityEngine.Debug.Log("XReceived LoadScene splashscene" + mikemackey.camillewhitman.ToString());
        if (mikemackey.camillewhitman)
        {
            josefinareece = "NotiSc";
        }
        else
        {
            josefinareece = shannonbrowning.Homenamescene;
        }
        SceneManager.LoadScene(josefinareece);
    }

}
