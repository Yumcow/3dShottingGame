using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cshScore : MonoBehaviour
{
    private int score = 0;
    private int highestCombo = 0;

    void Start()
    {
        GetComponent<Text>().text = string.Format("Score : {0}\nCombo : 0", score);
    }

    public void AddScore(int score, int combo)
    {
        this.score += score;
        if (combo > highestCombo) highestCombo = combo;
        GetComponent<Text>().text = string.Format("Score : {0}\nCombo : {1}", this.score, combo);
    }

    public void UpdateCombo(int combo)
    {
        GetComponent<Text>().text = string.Format("Score : {0}\nCombo : {1}", score, combo);
    }

    public int[] GetScore()
    {
        int[] temp = new int[2];
        temp[0] = score;
        temp[1] = highestCombo;
        return temp;
    }
}
