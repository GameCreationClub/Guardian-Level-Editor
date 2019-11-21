using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    public int x;
    public int y;

    public new string name;
    public SpriteValue spriteValue = SpriteValue.empty;
    public SpriteValue floorValue = SpriteValue.empty;

    private Image image;

    private NodeManager nodeManager;

    private void Start()
    {
        image = GetComponent<Image>();
        nodeManager = FindObjectOfType<NodeManager>();
    }

    public void SetSpriteValue(SpriteValue spriteValue)
    {
        this.spriteValue = spriteValue;
        name = spriteValue.name;
        image.sprite = spriteValue.sprite;

        CheckSpriteValueEmpty();
    }

    public void SetFloorValue(SpriteValue floorValue)
    {
        this.floorValue = floorValue;
        CheckSpriteValueEmpty();
    }

    public void NodeClicked()
    {
        nodeManager.HandleNodeClick(this);
    }

    private void CheckSpriteValueEmpty()
    {
        if (spriteValue.Equals(SpriteValue.empty))
        {
            image.sprite = floorValue.sprite;
        }
    }
}
