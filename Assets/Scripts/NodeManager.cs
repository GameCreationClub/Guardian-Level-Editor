using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeManager : GlobalEnums
{
    public ClickMode clickMode;

    public SpriteValue currentSpriteValue;

    private Main main;
    private PropertiesPanel propertiesPanel;

    private void Start()
    {
        main = FindObjectOfType<Main>();
        propertiesPanel = FindObjectOfType<PropertiesPanel>();

        //REMOVE LATER:
        currentSpriteValue = main.spriteValues[0];
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
            node.SetSpriteValue(SpriteValue.Null());
        }

        propertiesPanel.DisplayProperties(node);
    }

    public void SetClickMode(int clickMode)
    {
        this.clickMode = (ClickMode)clickMode;
    }
}
