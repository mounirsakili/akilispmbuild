using UnityEngine;
using UnityEngine.UI;

public class tylergilmore : MonoBehaviour
{
    public Camera cameraObj;
    public robinmoran coloringMenu, paintingMenu;

    [System.Serializable]
    public class robinmoran
    {
        public GameObject esmeraldahightower;
        public Color color;
        public Image image;
        public Sprite valeriacalhoun;
        public Sprite janietracy;
    }

    void Awake()
    {
        Camera.main.aspect = 16 / 9f;
    }

    void Start()
    {
                OnMenuButtonClicked(PlayerPrefs.GetInt("isPainting", 0) == 1);
    }

    public void OnMenuButtonClicked(bool isPainting)
    {
        PlayerPrefs.SetInt("isPainting", isPainting ? 1 : 0);
        PlayerPrefs.Save();

        paintingMenu.esmeraldahightower.SetActive(isPainting);
        coloringMenu.esmeraldahightower.SetActive(!isPainting);

        cameraObj.backgroundColor = isPainting ? paintingMenu.color : coloringMenu.color;
        paintingMenu.image.sprite = isPainting ? paintingMenu.valeriacalhoun : paintingMenu.janietracy;
        coloringMenu.image.sprite = !isPainting ? coloringMenu.valeriacalhoun : coloringMenu.janietracy;
    }

    public void johnnieochoa()
    {
       
    }
}
