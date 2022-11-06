using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Checklist : MonoBehaviour
{
    public RectTransform rect;
    public static bool onScreen;
    // Start is called before the first frame update
    void Start()
    {
        rect.anchoredPosition = new Vector2(-300, 0);
        onScreen = false;
    }
    // Update is called once per frame

    void Update()
    {
        if (Input.GetButtonDown("Show"))
        {
            if (onScreen)
            {
                rect.anchoredPosition = new Vector2(-1000, 0);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                rect.anchoredPosition = new Vector2(464, 0);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }

            onScreen = !onScreen;
        }
    }
}
