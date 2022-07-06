using UnityEngine;
using UnityEngine.UI;

public class bobbielucero : MonoBehaviour
{
    public Camera cameraObj;
    public mauriceferris coloringMenu, paintingMenu;

    [System.Serializable]
    public class mauriceferris
    {
        public GameObject pearliewilhelm;
        public Color color;
        public Image image;
        public Sprite andreagregory;
        public Sprite belindavarner;
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

        paintingMenu.pearliewilhelm.SetActive(isPainting);
        coloringMenu.pearliewilhelm.SetActive(!isPainting);

        cameraObj.backgroundColor = isPainting ? paintingMenu.color : coloringMenu.color;
        paintingMenu.image.sprite = isPainting ? paintingMenu.andreagregory : paintingMenu.belindavarner;
        coloringMenu.image.sprite = !isPainting ? coloringMenu.andreagregory : coloringMenu.belindavarner;
    }

    public void tommieburnett()
    {
       
    }
}
