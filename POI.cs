using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class POI : MonoBehaviour
{
    public int cost;
    public int costAdded;
    public int brokenProb;
    public bool broken;
    public Mesh brokenMesh;

    private void Awake()
    {
        costAdded = -1;
        int rand = Random.Range(0, 100);
        print(gameObject.name + " : " + rand);
        if (rand < brokenProb)
        {
            broken = true;
            GetComponent<MeshFilter>().sharedMesh = brokenMesh;
            foreach(Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }
            Main.damageExpenses += cost;
        }
    }

    public void toggleCost()
    {
        costAdded *= -1;
        Main.markedExpenses += costAdded * cost;
    }
}


