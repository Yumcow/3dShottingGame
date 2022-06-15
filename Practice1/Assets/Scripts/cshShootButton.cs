using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cshShootButton : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject Aim;
    public cshScore scoreScript;
    private int combo = 0;
    private Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Shoot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        RaycastHit hit;
        Vector3 vec = (Aim.transform.position - mainCamera.transform.position).normalized;
        if(Physics.Raycast(mainCamera.transform.position, vec, out hit, 100))
        {
            if(hit.transform.tag == "BreakableObject")
            {
                hit.transform.gameObject.GetComponent<cshBreakableObject>().PlayEffect();
                Destroy(hit.transform.gameObject);
                combo++;
                scoreScript.AddScore(100 + (combo * 10), combo);
            } else
            {
                combo = 0;
                scoreScript.UpdateCombo(combo);
            }
        }
    }
}
