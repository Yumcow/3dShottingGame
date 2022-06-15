using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cshGameEnd : MonoBehaviour
{
    public GameObject gameCanvas;
    public GameObject endCanvas;
    public GameObject Aim;
    public cshScore scoreScript;

    public void GameEnd()
    {
        gameCanvas.SetActive(false);
        endCanvas.SetActive(true);
        Aim.SetActive(false);

        Text endScore = endCanvas.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>();
        Text highestCombo = endCanvas.transform.GetChild(0).transform.GetChild(2).GetComponent<Text>();
        int[] scoreAndCombo = scoreScript.GetScore();

        endScore.text = string.Format("Score : {0}", scoreAndCombo[0]);
        highestCombo.text = string.Format("Best Combo : {0}", scoreAndCombo[1]);
    }
}
