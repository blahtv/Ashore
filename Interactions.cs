using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactions : MonoBehaviour
{
    public Text text;
    public RectTransform panel;
    private void Start()
    {
        panel.gameObject.SetActive(false);
    }
    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.collider.gameObject.tag.Equals("POI"))
            {
                POI p = hit.collider.gameObject.GetComponent<POI>();
                panel.gameObject.SetActive(true);
                text.text = p.gameObject.name;
                if (p.broken && (Main.brokenStatus == true))
                    text.text += " (Broken)";
            }
            else
            {
                panel.gameObject.SetActive(false);
            }
        }
        else
        {
            panel.gameObject.SetActive(false);
        }
    }
}
