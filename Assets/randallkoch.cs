using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class randallkoch : MonoBehaviour
{

    int joyceowens;
    AsyncOperation progress = null;
    Image progressBar;
    float kathieodell = 0;
    string heatherscott;



    
    void Start()
    {
        
        
        UnityEngine.Debug.Log("XReceived Start splashscene" + myronsinclair.taylorrobison.ToString());
        if (myronsinclair.taylorrobison)
        {
            heatherscott = "NotiSc";
        }
        else
        {
            heatherscott = glennblanton.Homenamescene  ;
        }
        
        
        

        
        if (PlayerPrefs.HasKey("appStartedNumber"))
        {
            joyceowens = PlayerPrefs.GetInt("appStartedNumber");
        }
        else
        {
            joyceowens = 0;
        }
        joyceowens++;
        PlayerPrefs.SetInt("appStartedNumber", joyceowens);
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        while (kathieodell < 5)
        {
            kathieodell += 0.05f;
            
            yield return new WaitForSeconds(0.025f);
        }
        UnityEngine.Debug.Log("XReceived LoadScene splashscene" + myronsinclair.taylorrobison.ToString());
        if (myronsinclair.taylorrobison)
        {
            heatherscott = "NotiSc";
        }
        else
        {
            heatherscott = glennblanton.Homenamescene;
        }
        SceneManager.LoadScene(heatherscott);
    }

}
