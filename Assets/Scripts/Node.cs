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
        image.sprite = spriteValue.sprite;
        name = spriteValue.name;
    }

    public void NodeClicked()
    {
        nodeManager.HandleNodeClick(this);
    }
}
