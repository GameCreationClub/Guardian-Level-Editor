using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public List<SpriteValue> spriteValues = new List<SpriteValue>();

    public Sprite GetSpriteFromName(string name)
    {
        foreach (SpriteValue o in spriteValues)
        {
            if (o.name.Equals(name)) return o.sprite;
        }

        return null;
    }

    public string GetNameFromSprite(Sprite sprite)
    {
        foreach (SpriteValue o in spriteValues)
        {
            if (o.sprite.Equals(sprite)) return o.name;
        }

        return null;
    }
}

[System.Serializable]
public struct SpriteValue
{
    public string name;
    public Sprite sprite;
}
