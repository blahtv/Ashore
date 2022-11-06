using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class MainMenu : MonoBehaviour
{
    public bool changeScene = false;

    public void ChangeScene(bool changeScene)
    {
        Main.damageExpenses = 0;
        SceneManager.LoadScene("Menu");
    }
}