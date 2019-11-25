using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationManager : MonoBehaviour
{
    public Text notificationText;

    public Animator animator;

    public void DisplayNotification(string text)
    {
        notificationText.text = text;
        notificationText.color = new Color(0.2745f, 0.8863f, 0f, 1f);

        animator.Play("Fade Out");
    }

    public void DisplayNotification(string text, Color color)
    {
        notificationText.text = text;
        notificationText.color = color;

        animator.Play("Fade Out");
    }
}
