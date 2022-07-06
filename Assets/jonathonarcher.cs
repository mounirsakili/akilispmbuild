using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class jonathonarcher : MonoBehaviour
{

    int hannahnoel;
    AsyncOperation progress = null;
    Image progressBar;
    float eunicefry = 0;
    string caitlincosta;



    
    void Start()
    {
        
        
        UnityEngine.Debug.Log("XReceived Start splashscene" + saulblevins.aileengardner.ToString());
        if (saulblevins.aileengardner)
        {
            caitlincosta = "NotiSc";
        }
        else
        {
            caitlincosta = carltonramey.Homenamescene  ;
        }
        
        
        

        
        if (PlayerPrefs.HasKey("appStartedNumber"))
        {
            hannahnoel = PlayerPrefs.GetInt("appStartedNumber");
        }
        else
        {
            hannahnoel = 0;
        }
        hannahnoel++;
        PlayerPrefs.SetInt("appStartedNumber", hannahnoel);
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        while (eunicefry < 5)
        {
            eunicefry += 0.05f;
            
            yield return new WaitForSeconds(0.025f);
        }
        UnityEngine.Debug.Log("XReceived LoadScene splashscene" + saulblevins.aileengardner.ToString());
        if (saulblevins.aileengardner)
        {
            caitlincosta = "NotiSc";
        }
        else
        {
            caitlincosta = carltonramey.Homenamescene;
        }
        SceneManager.LoadScene(caitlincosta);
    }

}
