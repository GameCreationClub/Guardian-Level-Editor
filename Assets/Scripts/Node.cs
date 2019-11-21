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

    public void NodeEnter()
    {
        MouseHoverAnimation(true);

        if (Input.GetMouseButton(0))
        {
            nodeManager.HandleNodeClick(this);
        }
    }

    public void NodeExit()
    {
        MouseHoverAnimation(false);
    }

    private void CheckSpriteValueEmpty()
    {
        if (spriteValue.IsNull())
        {
            objectImage.sprite = floorValue.sprite;
        }
    }

    private void MouseHoverAnimation(bool mouseEnter)
    {
        if (mouseEnter)
        {
            objectImage.color = new Color(0.9f, 0.9f, 0.9f);
            floorImage.color = new Color(0.9f, 0.9f, 0.9f);
        }
        else
        {
            objectImage.color = Color.white;
            floorImage.color = Color.white;
        }
    }
}
