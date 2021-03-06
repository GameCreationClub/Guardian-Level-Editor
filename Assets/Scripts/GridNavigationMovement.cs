﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridNavigationMovement : MonoBehaviour
{
    public bool canNavigate = true;

    private void Update()
    {
        if (canNavigate)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.down);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.up);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.left);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.right);
            }

            if (Input.GetAxisRaw("Mouse ScrollWheel") > 0f)
            {
                transform.localScale += Vector3.one * 0.1f;
            }
            else if (Input.GetAxisRaw("Mouse ScrollWheel") < 0f)
            {
                transform.localScale -= Vector3.one * 0.1f;
            }
        }
    }
}
