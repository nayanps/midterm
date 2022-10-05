using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignment_col : MonoBehaviour
{
    public string day = "Mo";
    public bool triggered;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == day)
        {
            triggered = true;

        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == day)
        {
            triggered = false;

        }

    }
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0) && triggered == true)
        //{
        //    Destroy(gameObject);
        //}

    }
}
