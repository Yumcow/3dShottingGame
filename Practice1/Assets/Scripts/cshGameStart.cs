using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cshGameStart : MonoBehaviour
{
    private int time = 3;
    public Text countdown;
    public GameObject Aim;
    
    void Start()
    {
        InvokeRepeating("CountDown", 0, 1);
    }

    void CountDown()
    {
        if (time <= 0)
        {
            countdown.transform.gameObject.SetActive(false);
            Aim.SetActive(true);
            GetComponent<cshSpawnObject>().GameStart();
            CancelInvoke("CountDown");
        }
        countdown.text = time.ToString();
        time--;
    }
}
