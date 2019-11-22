using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateLevelMenu : MonoBehaviour
{
    public InputField nameInput;
    public InputField widthInput;
    public InputField heightInput;

    public Image defaultFloorImage;

    private Main main;
    private GridGenerator gridGenerator;

    private void Start()
    {
        main = FindObjectOfType<Main>();
        gridGenerator = FindObjectOfType<GridGenerator>();
    }

    public void CreateLevel()
    {
        string levelName = nameInput.text;
        int x = int.Parse(widthInput.text);
        int y = int.Parse(heightInput.text);

        main.levelName = levelName;
        gridGenerator.GenerateGrid(x, y);

        gameObject.SetActive(false);
    }

    public void GetDefaultFloorFromMain()
    {
        defaultFloorImage.sprite = main.ChosenSprite.sprite;
    }
}
