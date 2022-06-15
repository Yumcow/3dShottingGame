using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshAimMove : MonoBehaviour
{
    private Vector3 pos;
    public cshJoystick sJoystick;
    public float speedLimit;
    private float width;
    private float height;

    // Start is called before the first frame update
    void Start()
    {
        height = transform.parent.gameObject.GetComponent<RectTransform>().rect.height / 2;
        width = transform.parent.gameObject.GetComponent<RectTransform>().rect.width / 2;
    }

    // Update is called once per frame
    void Update()
    {
        MoveAim();   
    }

    void MoveAim()
    {
        float h = sJoystick.GetHorizontalValue();
        float v = sJoystick.GetVerticalValue();

        pos = new Vector3(h, v, 0);
        pos = pos / speedLimit;
        
        if(transform.localPosition.x <= -width)
        {
            if(pos.x < 0)
            {
                pos.x = 0;
            }
        } 
        else if (transform.localPosition.x >= width)
        {
            if (pos.x > 0)
            {
                pos.x = 0;
            }
        }

        if (transform.localPosition.y <= -height)
        {
            if (pos.y < 0)
            {
                pos.y = 0;
            }
        }
        else if (transform.localPosition.y >= height)
        {
            if (pos.y > 0)
            {
                pos.y = 0;
            }
        }

        transform.Translate(pos * Time.deltaTime);
        Debug.Log(transform.localPosition);
    }
}
