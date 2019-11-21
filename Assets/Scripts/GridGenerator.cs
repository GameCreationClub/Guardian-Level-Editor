using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public int X;
    public int Y;

    public GameObject nodePrefab;
    public Transform gridParent;

    private void Start()
    {
        GenerateGrid();
    }

    public void GenerateGrid()
    {
        for (int x = 0; x < X; x++)
        {
            for (int y = 0; y < Y; y++)
            {
                Node node = Instantiate(nodePrefab, gridParent).GetComponent<Node>();
                node.GetComponent<RectTransform>().anchoredPosition = new Vector3(33 * (x - X / 2.5f), 33 * (y - Y / 2.5f));
                node.x = x;
                node.y = y;
            }
        }
    }
}
