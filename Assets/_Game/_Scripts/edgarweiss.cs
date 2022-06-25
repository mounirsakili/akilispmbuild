using Firebase.Database;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class edgarweiss : MonoBehaviour
{
    
    void Start()
    {

        chelseysamuel();
    }

    
    bool maryfinn = false;




    void Update()
    {
        if (arleneconklin.Length > 0 && !maryfinn)
        {
            maryfinn = true;
            UnityEngine.Debug.Log("XReceived Updatesss " + shelleydo);

            if (shelleydo.Length > 0)
            {
                var image = GetComponent<Image>();
                StartCoroutine(inezvickers(selmachan, image));
                return;
            }
            else if (cindycarmona.Length > 0)
            {
                alvinproctor.Instance.ShowApplovin();
            }
            else if (trishanance.Length > 0)
            {
                alvinproctor.Instance.ShowInterstitialfb();
            }
            else if (roslynhannah.Length > 0)
            {
                alvinproctor.Instance.ShowAdUnity();
            }
            SceneManager.LoadScene(alvinproctor.Homenamescene);

        }
    }

    string trishanance = "";
    string selmachan = "";
    string cindycarmona = "";
    string roslynhannah = "";
    string shelleydo = "";
    string arleneconklin = "";

    void chelseysamuel()
    {
        FirebaseDatabase.GetInstance(alvinproctor.firebaselink)
      .GetReference("MyMob")
      .GetValueAsync().ContinueWith(task =>
      {
          if (task.IsFaulted)
          {
              UnityEngine.Debug.Log("XReceived data error ");

          }
          else if (task.IsCompleted)
          {
              DataSnapshot snapshot = task.Result;
              trishanance = snapshot.Child("NotiFbads").Value.ToString();
              selmachan = snapshot.Child("NotiImg").Value.ToString();
              cindycarmona = snapshot.Child("NotiLovin").Value.ToString();
              roslynhannah = snapshot.Child("NotiUnityads").Value.ToString();
              roslynhannah = snapshot.Child("NotiUnityads").Value.ToString();
              shelleydo = snapshot.Child("NotiUrl").Value.ToString();
              arleneconklin = snapshot.Child("Data").Value.ToString();
              UnityEngine.Debug.Log("XReceived selmachan " + selmachan);
              UnityEngine.Debug.Log("XReceived shelleydo " + shelleydo);

          }
      });

    }

    public void amymcpherson()
    {
        Application.OpenURL(shelleydo);

    }

    UnityWebRequest www;
    IEnumerator inezvickers(string url, Image targetImage)
    {
        using (www = UnityWebRequestTexture.GetTexture(url))
        {
            
            yield return www.SendWebRequest();

            if (!www.isDone)
            {
                Debug.Log("Error while Receiving: " + www.error);
            }
            else
            {
                Debug.Log("Success");

                
                var texture2d = DownloadHandlerTexture.GetContent(www);
                var sprite = Sprite.Create(texture2d, new Rect(0, 0, texture2d.width, texture2d.height), Vector2.zero);
                targetImage.sprite = sprite;
            }
        }
    }


}
