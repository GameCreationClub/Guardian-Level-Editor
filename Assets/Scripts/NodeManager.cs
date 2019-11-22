﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeManager : GlobalEnums
{
    public ClickMode clickMode;

    public SpriteValue currentSpriteValue;

    public Image currentSpriteImage;

    private Node[,] nodes;

    private Main main;
    private PropertiesPanel propertiesPanel;

    private void Start()
    {
        main = FindObjectOfType<Main>();
        propertiesPanel = FindObjectOfType<PropertiesPanel>();
    }

    public void InitializeNodeMatrix(int width, int height)
    {
        nodes = new Node[width, height];
    }

    public void AddNode(Node node)
    {
        nodes[node.x, node.y] = node;
    }

    public void HandleNodeClick(Node node)
    {
        if (clickMode.Equals(ClickMode.Add))
        {
            if (currentSpriteValue.type.Equals(ObjectType.Floor))
            {
                node.SetFloorValue(currentSpriteValue);
            }
            else if (currentSpriteValue.type.Equals(ObjectType.Object))
            {
                node.SetSpriteValue(currentSpriteValue);
            }
        }
        else if (clickMode.Equals(ClickMode.Erase))
        {
            if (node.spriteValue.IsNull())
            {
                node.SetFloorValue(SpriteValue.Null());
            }
            else
            {
                node.SetSpriteValue(SpriteValue.Null());
            }
        }

        propertiesPanel.DisplayProperties(node);
    }

    public void SetClickMode(int clickMode)
    {
        this.clickMode = (ClickMode)clickMode;
    }

    public void GetCurrentSpriteValueFromMain()
    {
        currentSpriteValue = main.ChosenSprite;
        currentSpriteImage.sprite = currentSpriteValue.sprite;
    }
}
