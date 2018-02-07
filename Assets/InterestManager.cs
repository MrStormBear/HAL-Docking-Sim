using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterestManager : MonoBehaviour
{

    int diagScore = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Score = " + diagScore);
    }

    void VeryGood()
    {
        diagScore += 2;
    }

    void Good()
    {
        diagScore += 1;
    }
    
    void Bad()
    {
        diagScore -= 1;
    }
    void VeryBad()
    {
        diagScore -= 2;
    }
}
