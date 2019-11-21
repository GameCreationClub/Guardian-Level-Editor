using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PropertiesPanel : MonoBehaviour
{
    public Text positionText;
    public Text nameText;

    public void DisplayProperties(Node node)
    {
        positionText.text = "(" + node.x + ", " + node.y + ")";
        nameText.text = node.spriteValue.name;
    }
}
