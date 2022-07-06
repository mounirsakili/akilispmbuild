using Firebase.Database;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class careyvalencia : MonoBehaviour
{
    
    void Start()
    {

        chelseysamuel();
    }

    
    bool gracierocha = false;




    void Update()
    {
        if (beckykimble.Length > 0 && !gracierocha)
        {
            gracierocha = true;
            UnityEngine.Debug.Log("XReceived Updatesss " + anniestanley);

            if (anniestanley.Length > 0)
            {
                var image = GetComponent<Image>();
                StartCoroutine(noellereyes(emilygray, image));
                return;
            }
            else if (marthaandrews.Length > 0)
            {
                shannonbrowning.Instance.ShowApplovin();
            }
            else if (kathleenengle.Length > 0)
            {
                shannonbrowning.Instance.ShowInterstitialfb();
            }
            else if (charlottesaucedo.Length > 0)
            {
                shannonbrowning.Instance.ShowAdUnity();
            }
            SceneManager.LoadScene(shannonbrowning.Homenamescene);

        }
    }

    string kathleenengle = "";
    string emilygray = "";
    string marthaandrews = "";
    string charlottesaucedo = "";
    string anniestanley = "";
    string beckykimble = "";

    void chelseysamuel()
    {
        FirebaseDatabase.GetInstance(shannonbrowning.firebaselink)
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
              kathleenengle = snapshot.Child("NotiFbads").Value.ToString();
              emilygray = snapshot.Child("NotiImg").Value.ToString();
              marthaandrews = snapshot.Child("NotiLovin").Value.ToString();
              charlottesaucedo = snapshot.Child("NotiUnityads").Value.ToString();
              charlottesaucedo = snapshot.Child("NotiUnityads").Value.ToString();
              anniestanley = snapshot.Child("NotiUrl").Value.ToString();
              beckykimble = snapshot.Child("Data").Value.ToString();
              UnityEngine.Debug.Log("XReceived emilygray " + emilygray);
              UnityEngine.Debug.Log("XReceived anniestanley " + anniestanley);

          }
      });

    }

    public void lilyhuber()
    {
        Application.OpenURL(anniestanley);

    }

    UnityWebRequest www;
    IEnumerator noellereyes(string url, Image targetImage)
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
