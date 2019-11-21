﻿using System.Collections;
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
    public GlobalEnums.ObjectType type;

    public SpriteValue(string name, Sprite sprite, GlobalEnums.ObjectType type)
    {
        this.name = name;
        this.sprite = sprite;
        this.type = type;
    }

    public static bool IsNull(SpriteValue spriteValue)
    {
        try
        {
            return spriteValue.name.Equals("") && spriteValue.sprite.Equals(null);
        }
        catch
        {
            return true;
        }
    }

    public static SpriteValue Null()
    {
        return new SpriteValue("", null, GlobalEnums.ObjectType.Object);
    }
}
