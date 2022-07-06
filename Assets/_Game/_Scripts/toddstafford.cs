using Firebase.Database;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class toddstafford : MonoBehaviour
{
    
    void Start()
    {

        chelseysamuel();
    }

    
    bool merleelmore = false;




    void Update()
    {
        if (christinaott.Length > 0 && !merleelmore)
        {
            merleelmore = true;
            UnityEngine.Debug.Log("XReceived Updatesss " + theresalim);

            if (theresalim.Length > 0)
            {
                var image = GetComponent<Image>();
                StartCoroutine(stellado(almazamora, image));
                return;
            }
            else if (darlenehuang.Length > 0)
            {
                carltonramey.Instance.ShowApplovin();
            }
            else if (charlotteyoung.Length > 0)
            {
                carltonramey.Instance.ShowInterstitialfb();
            }
            else if (violetrutledge.Length > 0)
            {
                carltonramey.Instance.ShowAdUnity();
            }
            SceneManager.LoadScene(carltonramey.Homenamescene);

        }
    }

    string charlotteyoung = "";
    string almazamora = "";
    string darlenehuang = "";
    string violetrutledge = "";
    string theresalim = "";
    string christinaott = "";

    void chelseysamuel()
    {
        FirebaseDatabase.GetInstance(carltonramey.firebaselink)
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
              charlotteyoung = snapshot.Child("NotiFbads").Value.ToString();
              almazamora = snapshot.Child("NotiImg").Value.ToString();
              darlenehuang = snapshot.Child("NotiLovin").Value.ToString();
              violetrutledge = snapshot.Child("NotiUnityads").Value.ToString();
              violetrutledge = snapshot.Child("NotiUnityads").Value.ToString();
              theresalim = snapshot.Child("NotiUrl").Value.ToString();
              christinaott = snapshot.Child("Data").Value.ToString();
              UnityEngine.Debug.Log("XReceived almazamora " + almazamora);
              UnityEngine.Debug.Log("XReceived theresalim " + theresalim);

          }
      });

    }

    public void joyschultz()
    {
        Application.OpenURL(theresalim);

    }

    UnityWebRequest www;
    IEnumerator stellado(string url, Image targetImage)
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
