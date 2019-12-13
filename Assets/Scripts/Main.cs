using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public string levelName;

    public List<SpriteValue> spriteValues = new List<SpriteValue>();

    public GameObject pauseMenu;

    private SpriteValue chosenSprite;
    public SpriteValue ChosenSprite
    {
        get { return chosenSprite; }
    }

    private UnityEvent chooseSpriteEvent;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(!pauseMenu.activeInHierarchy);
        }
    }

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

    public SpriteValue GetSpriteValueFromName(string name)
    {
        foreach (SpriteValue o in spriteValues)
        {
            if (o.name.Equals(name)) return o;
        }

        return SpriteValue.Null(); ;
    }

    public SpriteValue[] GetSpriteValues()
    {
        return spriteValues.ToArray();
    }

    public SpriteValue[] GetSpriteValues(GlobalEnums.ObjectType type)
    {
        List<SpriteValue> spriteValues = new List<SpriteValue>();

        foreach (SpriteValue spriteValue in this.spriteValues)
        {
            if (spriteValue.type.Equals(type))
            {
                spriteValues.Add(spriteValue);
            }
        }

        return spriteValues.ToArray();
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

    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        Application.Quit();
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
