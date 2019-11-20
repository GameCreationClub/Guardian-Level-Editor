using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public int X = 16;
    public int Y = 16;

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
                node.transform.position = new Vector3(33 * (x - Mathf.Floor(X / 2f)) + 696, 33 * (y - Mathf.Floor(Y / 2f)) + 391.5f);
                node.x = x;
                node.y = y;
            }
        }
    }
}
