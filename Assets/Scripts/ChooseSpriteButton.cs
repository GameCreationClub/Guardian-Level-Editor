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

    private void Start()
    {
        nodeManager = FindObjectOfType<NodeManager>();
    }

    public void ChooseThisSprite()
    {
        nodeManager.SetCurrentSpriteValue(spriteValue);
    }

    public void SetSpriteValue(SpriteValue spriteValue)
    {
        this.spriteValue = spriteValue;
        nameText.text = spriteValue.name;
        image.sprite = spriteValue.sprite;
    }
}
