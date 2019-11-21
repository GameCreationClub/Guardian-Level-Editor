using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSpriteMenu : MonoBehaviour
{
    public GameObject buttonPrefab;
    public Transform buttonsParent;

    private Main main;

    private void Start()
    {
        main = FindObjectOfType<Main>();

        GenerateButtons();
    }

    private void GenerateButtons()
    {
        foreach (SpriteValue spriteValue in main.spriteValues)
        {
            ChooseSpriteButton button = Instantiate(buttonPrefab, buttonsParent).GetComponent<ChooseSpriteButton>();
            button.SetSpriteValue(spriteValue);
        }
    }
}
