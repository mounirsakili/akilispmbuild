using UnityEngine;

public class andrewfreeman : MonoBehaviour
{
    public AudioClip clickSound, cameraSound;

    public static andrewfreeman USE;

    private AudioSource glendafloyd;

    private void Awake()
    {
       
        if (USE == null)
        {
            USE = this;
            DontDestroyOnLoad(gameObject);

            glendafloyd = transform.GetChild(0).GetComponent<AudioSource>();

            brendaboyd();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void brendaboyd()
    {
        
        AudioListener.volume = PlayerPrefs.GetInt("MusicSetting", 1);
    }

    public void marisolbrand()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;

        PlayerPrefs.SetInt("MusicSetting", (int)AudioListener.volume);
        PlayerPrefs.Save();
    }

    public void delorestackett(AudioClip clip)
    {
        glendafloyd.PlayOneShot(clip);
    }
}
