using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endconditiontext : MonoBehaviour
{
    public Text endText;

    // Start is called before the first frame update
    void Awake()
    {
        int end = Main.endCondition;
        if(end == 0)
        {
            endText.text = "You lose and i dont know why"; //error, don't use 0
        }
        if (end == 1)
        {
            endText.text = "You ran out of time!";
        }
        if (end == 2)
        {
            endText.text = "You lose! You didn't find all the broken parts and the ship sunk when it sailed next.";
        }
        if (end == 3)
        {
            endText.text = "You lose, you ran out of money upgrading incorrect things!";
        }
        if (end == 4)
        {
            endText.text = "You win! You've identified all broken parts.";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
