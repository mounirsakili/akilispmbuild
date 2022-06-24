using UnityEngine;

public class winstonhowe : MonoBehaviour
{
    public AudioClip clickSound, cameraSound;

    public static winstonhowe USE;

    private AudioSource berylholder;

    private void Awake()
    {
       
        if (USE == null)
        {
            USE = this;
            DontDestroyOnLoad(gameObject);

            berylholder = transform.GetChild(0).GetComponent<AudioSource>();

            shirleyneff();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void shirleyneff()
    {
        
        AudioListener.volume = PlayerPrefs.GetInt("MusicSetting", 1);
    }

    public void julietrichardson()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;

        PlayerPrefs.SetInt("MusicSetting", (int)AudioListener.volume);
        PlayerPrefs.Save();
    }

    public void virgiehaas(AudioClip clip)
    {
        berylholder.PlayOneShot(clip);
    }
}
