using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChooseSpriteMenuOpener : MonoBehaviour
{
    public UnityEvent chooseSpriteEvent;

    private Main main;

    private void Start()
    {
        main = FindObjectOfType<Main>();
    }

    public void ButtonClicked()
    {
        main.SetChooseSpriteEvent(chooseSpriteEvent);
    }
}
