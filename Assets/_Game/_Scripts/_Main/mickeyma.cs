using UnityEngine;

public class mickeyma : MonoBehaviour
{
    public AudioClip clickSound, cameraSound;

    public static mickeyma USE;

    private AudioSource faithrosales;

    private void Awake()
    {
       
        if (USE == null)
        {
            USE = this;
            DontDestroyOnLoad(gameObject);

            faithrosales = transform.GetChild(0).GetComponent<AudioSource>();

            sonyajung();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void sonyajung()
    {
        
        AudioListener.volume = PlayerPrefs.GetInt("MusicSetting", 1);
    }

    public void renamchugh()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;

        PlayerPrefs.SetInt("MusicSetting", (int)AudioListener.volume);
        PlayerPrefs.Save();
    }

    public void jodiedouglas(AudioClip clip)
    {
        faithrosales.PlayOneShot(clip);
    }
}
