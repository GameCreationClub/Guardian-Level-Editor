using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeManager : MonoBehaviour
{
    private Main main;

    private void Start()
    {
        main = FindObjectOfType<Main>();
    }

    public void HandleNodeClick(Node node)
    {
        node.SetSpriteValue(main.spriteValues[0]);
    }
}
