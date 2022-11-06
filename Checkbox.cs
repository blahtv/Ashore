using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkbox : MonoBehaviour
{

    public void bruhSoundEffect()
    {
        Main.brokenStatus = !Main.brokenStatus;
    }

    public void Awake()
    {
        Main.brokenStatus = false;
    }

}
