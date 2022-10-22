using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignment_col : MonoBehaviour
{ //day determines which collider is being entered/exited
    public string day = "Mo";
    public bool triggered;

    public void OnTriggerEnter2D(Collider2D other)
    { //whenever an assignment enters the specific collider, the trigger is turned on
        if (other.tag == day)
        {
            triggered = true;

        }
    }
    public void OnTriggerExit2D(Collider2D other)
    { //trigger turned off when exiting the collider
        if (other.tag == day)
        {
            triggered = false;

        }

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && triggered == true)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
