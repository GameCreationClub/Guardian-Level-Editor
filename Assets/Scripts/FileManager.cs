using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Crosstales.FB;

public class FileManager : MonoBehaviour
{
    private Main main;
    private NodeManager nodeManager;
    private GridGenerator gridGenerator;

    private void Start()
    {
        main = FindObjectOfType<Main>();
        nodeManager = FindObjectOfType<NodeManager>();
        gridGenerator = FindObjectOfType<GridGenerator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadLevel();
        }
    }

    public void SaveLevel()
    {
        string levelName = main.levelName;
        int width = nodeManager.GetWidth();
        int height = nodeManager.GetHeight();
        NodeData[] nodeData = nodeManager.GetNodeData();

        SaveFile saveFile = new SaveFile(levelName, width, height, nodeData);
        string path = FileBrowser.SaveFile(levelName, "json");
        string json = JsonUtility.ToJson(saveFile);
        System.IO.File.WriteAllText(path, json);
    }

    public void LoadLevel()
    {
        string path = FileBrowser.OpenSingleFile("json");
        string json = System.IO.File.ReadAllText(path);

        SaveFile saveFile = JsonUtility.FromJson<SaveFile>(json);
        gridGenerator.GenerateGrid(saveFile.width, saveFile.height);

        foreach (NodeData nodeData in saveFile.nodeData)
        {
            nodeManager.SetNodeFromNodeData(nodeData);
        }
    }
}

[System.Serializable]
public class SaveFile
{
    public string levelName;
    public int width;
    public int height;
    public NodeData[] nodeData;

    public SaveFile()
    {

    }

    public SaveFile(string levelName, int width, int height, NodeData[] nodeData)
    {
        this.levelName = levelName;
        this.width = width;
        this.height = height;
        this.nodeData = nodeData;
    }
}

[System.Serializable]
public class NodeData
{
    public int x;
    public int y;
    public string spriteValue;
    public string floorValue;

    public NodeData()
    {

    }

    public NodeData(int x, int y, string spriteValue, string floorValue)
    {
        this.x = x;
        this.y = y;
        this.spriteValue = spriteValue;
        this.floorValue = floorValue;
    }
}
