using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class cliftondye : MonoBehaviour
{

    int jeannettefletcher;
    AsyncOperation progress = null;
    Image progressBar;
    float tishatrent = 0;
    string beverlywillard;



    
    void Start()
    {
        
        
        UnityEngine.Debug.Log("XReceived Start splashscene" + lavernedixon.nellymcnamara.ToString());
        if (lavernedixon.nellymcnamara)
        {
            beverlywillard = "NotiSc";
        }
        else
        {
            beverlywillard = alvinproctor.Homenamescene  ;
        }
        
        
        

        
        if (PlayerPrefs.HasKey("appStartedNumber"))
        {
            jeannettefletcher = PlayerPrefs.GetInt("appStartedNumber");
        }
        else
        {
            jeannettefletcher = 0;
        }
        jeannettefletcher++;
        PlayerPrefs.SetInt("appStartedNumber", jeannettefletcher);
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        while (tishatrent < 5)
        {
            tishatrent += 0.05f;
            
            yield return new WaitForSeconds(0.025f);
        }
        UnityEngine.Debug.Log("XReceived LoadScene splashscene" + lavernedixon.nellymcnamara.ToString());
        if (lavernedixon.nellymcnamara)
        {
            beverlywillard = "NotiSc";
        }
        else
        {
            beverlywillard = alvinproctor.Homenamescene;
        }
        SceneManager.LoadScene(beverlywillard);
    }

}
