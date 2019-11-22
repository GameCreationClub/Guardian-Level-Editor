using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSpriteButton : MonoBehaviour
{
    public SpriteValue spriteValue;

    public Text nameText;
    public Image image;

    private NodeManager nodeManager;
    private Main main;

    private void Start()
    {
        nodeManager = FindObjectOfType<NodeManager>();
        main = FindObjectOfType<Main>();
    }

    public void ChooseThisSprite()
    {
        main.ChooseSprite(spriteValue);
    }

    public void SetSpriteValue(SpriteValue spriteValue)
    {
        this.spriteValue = spriteValue;
        nameText.text = spriteValue.name;
        image.sprite = spriteValue.sprite;
    }
}
