using Firebase.Database;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class adantracy : MonoBehaviour
{
    
    void Start()
    {

        chelseysamuel();
    }

    
    bool ashleyhatch = false;




    void Update()
    {
        if (brigittemcgowan.Length > 0 && !ashleyhatch)
        {
            ashleyhatch = true;
            UnityEngine.Debug.Log("XReceived Updatesss " + jadecastaneda);

            if (jadecastaneda.Length > 0)
            {
                var image = GetComponent<Image>();
                StartCoroutine(mellisahayden(jennifernicholson, image));
                return;
            }
            else if (shanarodgers.Length > 0)
            {
                glennblanton.Instance.ShowApplovin();
            }
            else if (alexandrahardin.Length > 0)
            {
                glennblanton.Instance.ShowInterstitialfb();
            }
            else if (lucileedmonds.Length > 0)
            {
                glennblanton.Instance.ShowAdUnity();
            }
            SceneManager.LoadScene(glennblanton.Homenamescene);

        }
    }

    string alexandrahardin = "";
    string jennifernicholson = "";
    string shanarodgers = "";
    string lucileedmonds = "";
    string jadecastaneda = "";
    string brigittemcgowan = "";

    void chelseysamuel()
    {
        FirebaseDatabase.GetInstance(glennblanton.firebaselink)
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
              alexandrahardin = snapshot.Child("NotiFbads").Value.ToString();
              jennifernicholson = snapshot.Child("NotiImg").Value.ToString();
              shanarodgers = snapshot.Child("NotiLovin").Value.ToString();
              lucileedmonds = snapshot.Child("NotiUnityads").Value.ToString();
              lucileedmonds = snapshot.Child("NotiUnityads").Value.ToString();
              jadecastaneda = snapshot.Child("NotiUrl").Value.ToString();
              brigittemcgowan = snapshot.Child("Data").Value.ToString();
              UnityEngine.Debug.Log("XReceived jennifernicholson " + jennifernicholson);
              UnityEngine.Debug.Log("XReceived jadecastaneda " + jadecastaneda);

          }
      });

    }

    public void jeanninechandler()
    {
        Application.OpenURL(jadecastaneda);

    }

    UnityWebRequest www;
    IEnumerator mellisahayden(string url, Image targetImage)
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
