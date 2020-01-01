using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSpriteMenu : MonoBehaviour
{
    public GameObject buttonPrefab;
    public Transform buttonsParent;

    public Dropdown chooseTypeDropdown;

    private Transform[] buttons;

    private GlobalEnums.ObjectType type = (GlobalEnums.ObjectType)(-1);

    private Main main;

    private void Awake()
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

        buttons = new Transform[buttonsParent.childCount];

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i] = buttonsParent.GetChild(i);
        }
    }

    private void ShowButtons()
    {
        foreach (Transform button in buttons)
        {
            if (type.Equals((GlobalEnums.ObjectType)(-1)))
            {
                button.gameObject.SetActive(true);
            }
            else if (button.GetComponent<ChooseSpriteButton>().spriteValue.type.Equals(type))
            {
                button.gameObject.SetActive(true);
            }
            else
            {
                button.gameObject.SetActive(false);
            }
        }
    }

    public void OpenMenu()
    {
        type = (GlobalEnums.ObjectType)(-1);
        gameObject.SetActive(true);
        ShowButtons();

        chooseTypeDropdown.gameObject.SetActive(true);
    }

    public void OpenMenu(int type)
    {
        this.type = (GlobalEnums.ObjectType)type;
        gameObject.SetActive(true);
        ShowButtons();

        chooseTypeDropdown.gameObject.SetActive(false);
    }

    public void ChooseTypeDrowpdown()
    {
        type = (GlobalEnums.ObjectType)(chooseTypeDropdown.value - 1);
        ShowButtons();
    }
}
