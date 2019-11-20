using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    public int x;
    public int y;

    public SpriteValue spriteValue;

    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    public void SetSpriteValue(SpriteValue spriteValue)
    {
        this.spriteValue = spriteValue;
        image.sprite = spriteValue.sprite;
    }
}
