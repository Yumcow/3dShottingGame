using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshMoveBack : MonoBehaviour
{
    private Vector3 x = new Vector3(-1, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= -15)
        {
            Destroy(transform.gameObject);
        }
        transform.Translate(x * 3 * Time.deltaTime);
    }
}
