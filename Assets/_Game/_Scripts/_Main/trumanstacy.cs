using UnityEngine;
using UnityEngine.UI;

public class trumanstacy : MonoBehaviour
{
    public Camera cameraObj;
    public kellylay coloringMenu, paintingMenu;

    [System.Serializable]
    public class kellylay
    {
        public GameObject ebonybowman;
        public Color color;
        public Image image;
        public Sprite melisapotter;
        public Sprite carmelabain;
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

        paintingMenu.ebonybowman.SetActive(isPainting);
        coloringMenu.ebonybowman.SetActive(!isPainting);

        cameraObj.backgroundColor = isPainting ? paintingMenu.color : coloringMenu.color;
        paintingMenu.image.sprite = isPainting ? paintingMenu.melisapotter : paintingMenu.carmelabain;
        coloringMenu.image.sprite = !isPainting ? coloringMenu.melisapotter : coloringMenu.carmelabain;
    }

    public void janiceself()
    {
       
    }
}
