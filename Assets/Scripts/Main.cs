using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Main : MonoBehaviour
{
    public string levelName;

    public List<SpriteValue> spriteValues = new List<SpriteValue>();

    private SpriteValue chosenSprite;
    public SpriteValue ChosenSprite
    {
        get { return chosenSprite; }
    }

    private UnityEvent chooseSpriteEvent;

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

    public void ChooseSprite(SpriteValue spriteValue)
    {
        chosenSprite = spriteValue;
        chooseSpriteEvent.Invoke();
    }

    public void SetChooseSpriteEvent(UnityEvent e)
    {
        chooseSpriteEvent = e;
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

    public bool IsNull()
    {
        try
        {
            return name.Equals("") && sprite.Equals(null);
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
