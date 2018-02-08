using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterestManager : MonoBehaviour
{
    public GameObject m_winScreen;
    public GameObject m_loseScreen;

    int diagScore = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Score = " + diagScore);
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

    void CheckDiagScore()
    {
        if(diagScore == 6)
        {
            Debug.Log("You docked");
        } else if (diagScore < 6)
        {
            Debug.Log("You may not be compatible");
        }
    }

    public void ShowWin()
    {
        m_winScreen.SetActive(false);
    }
    public void ShowLose()
    {
        m_loseScreen.SetActive(false);
    }
}
