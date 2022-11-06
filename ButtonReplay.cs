using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class ButtonReplay : MonoBehaviour
{
    public bool changeScene = false;

    public void ChangeScene(bool changeScene)
    {
        if (SceneManager.GetActiveScene().name != "Playground")
        {
            Main.damageExpenses = 0;
            SceneManager.LoadScene("Playground");
        }
        else
        {
            if (Main.markedExpenses == Main.damageExpenses) //maybe should also check if they actually picked the right stuff
                Main.endCondition = 4;
            else if (Main.markedExpenses >= Main.damageExpenses)
                Main.endCondition = 3;
            else if (Main.markedExpenses <= Main.damageExpenses)
                Main.endCondition = 2;
            SceneManager.LoadScene("end");
        }
    }
}