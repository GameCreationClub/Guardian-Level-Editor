using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public GameObject nodePrefab;
    public Transform gridParent;

    private NodeManager nodeManager;

    private void Start()
    {
        nodeManager = FindObjectOfType<NodeManager>();
    }

    public void GenerateGrid(int width, int height)
    {
        nodeManager.InitializeNodeMatrix(width, height);

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Node node = Instantiate(nodePrefab, gridParent).GetComponent<Node>();
                node.GetComponent<RectTransform>().anchoredPosition = new Vector3(33 * (x - width / 2.5f), 33 * (y - height / 2.5f));
                node.x = x;
                node.y = y;

                nodeManager.AddNode(node);
            }
        }
    }
}
