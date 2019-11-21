using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    public int x;
    public int y;

    public new string name;
    public SpriteValue spriteValue;
    public SpriteValue floorValue;

    public Image objectImage;
    public Image floorImage;

    private NodeManager nodeManager;

    private void Start()
    {
        nodeManager = FindObjectOfType<NodeManager>();
    }

    public void SetSpriteValue(SpriteValue spriteValue)
    {
        this.spriteValue = spriteValue;
        name = spriteValue.name;
        objectImage.sprite = spriteValue.sprite;

        CheckSpriteValueEmpty();
    }

    public void SetFloorValue(SpriteValue floorValue)
    {
        this.floorValue = floorValue;
        floorImage.sprite = floorValue.sprite;
        CheckSpriteValueEmpty();
    }

    public void NodeClicked()
    {
        nodeManager.HandleNodeClick(this);
    }

    private void CheckSpriteValueEmpty()
    {
        if (SpriteValue.IsNull(spriteValue))
        {
            objectImage.sprite = floorValue.sprite;
        }
    }
}
