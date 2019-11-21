using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeManager : GlobalEnums
{
    public ClickMode clickMode;

    private Main main;
    private PropertiesPanel propertiesPanel;

    private void Start()
    {
        main = FindObjectOfType<Main>();
        propertiesPanel = FindObjectOfType<PropertiesPanel>();
    }

    public void HandleNodeClick(Node node)
    {
        if (clickMode.Equals(ClickMode.Add))
        {
            node.SetSpriteValue(main.spriteValues[0]);
        }
        else if (clickMode.Equals(ClickMode.Erase))
        {
            node.SetSpriteValue(SpriteValue.empty);
        }

        propertiesPanel.DisplayProperties(node);
    }

    public void SetClickMode(int clickMode)
    {
        this.clickMode = (ClickMode)clickMode;
    }
}
