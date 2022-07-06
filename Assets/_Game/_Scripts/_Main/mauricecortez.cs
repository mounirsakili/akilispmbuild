using UnityEngine;

public class mauricecortez : MonoBehaviour
{
    public AudioClip clickSound, cameraSound;

    public static mauricecortez USE;

    private AudioSource liliaosborne;

    private void Awake()
    {
       
        if (USE == null)
        {
            USE = this;
            DontDestroyOnLoad(gameObject);

            liliaosborne = transform.GetChild(0).GetComponent<AudioSource>();

            melindabray();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void melindabray()
    {
        
        AudioListener.volume = PlayerPrefs.GetInt("MusicSetting", 1);
    }

    public void dionnemay()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;

        PlayerPrefs.SetInt("MusicSetting", (int)AudioListener.volume);
        PlayerPrefs.Save();
    }

    public void nicolemorrison(AudioClip clip)
    {
        liliaosborne.PlayOneShot(clip);
    }
}
