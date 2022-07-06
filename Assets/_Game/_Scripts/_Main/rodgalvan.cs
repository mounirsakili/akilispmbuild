using UnityEngine;
using UnityEngine.UI;

public class rodgalvan : MonoBehaviour
{
    public Camera cameraObj;
    public erwinbermudez coloringMenu, paintingMenu;

    [System.Serializable]
    public class erwinbermudez
    {
        public GameObject suzettedenton;
        public Color color;
        public Image image;
        public Sprite brendashirley;
        public Sprite jasminehorton;
    }

    void Awake()
    {
        Camera.main.aspect = 16 / 9f;
    }

    void Start()
    {
                OnMenuButtonClicked(false);
    }

    public void OnMenuButtonClicked(bool isPainting)
    {
        PlayerPrefs.SetInt("isPainting", isPainting ? 1 : 0);
        PlayerPrefs.Save();

        paintingMenu.suzettedenton.SetActive(isPainting);
        coloringMenu.suzettedenton.SetActive(!isPainting);

        cameraObj.backgroundColor = isPainting ? paintingMenu.color : coloringMenu.color;
        paintingMenu.image.sprite = isPainting ? paintingMenu.brendashirley : paintingMenu.jasminehorton;
        coloringMenu.image.sprite = !isPainting ? coloringMenu.brendashirley : coloringMenu.jasminehorton;
    }

    public void madgekirk()
    {
       
    }
}
