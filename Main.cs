using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public static double budget;
    public Text budgetText;
    public Text costText;
    public static double damageExpenses;
    public static double markedExpenses;
    public static int endCondition = 0;
    public static float thevolume;
    public AudioSource wind;
    public static bool brokenStatus;

    void Start()
    {
        budget = damageExpenses + Random.Range(100, 1500); //for now just makes the budget how much everything costs
        markedExpenses = 0;
        budgetText.text = "Budget: $"+budget;
        wind.volume = thevolume;
    }

    private void Update()
    {
        costText.text = "Cost: $" + markedExpenses;
    }
}
