using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignment_col : MonoBehaviour
{ //day determines which collider is being entered/exited
    public string day = "Mo";
    public Renderer re;
    public bool triggered;
    public AudioSource click;
    private ScoreManager scoreManager;

    void Awake()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void Start()
    {
        re= GetComponent<Renderer>();
        re.enabled = true;
    }

    IEnumerator RespawnAssignment()
    {
        while (true)
        {
            click.Play();
            Debug.Log("assignment gone");
            re.enabled = false;
            yield return new WaitForSeconds(5f);

            re.enabled = true;
            yield break;
        }
    }
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
        if (Input.GetMouseButtonDown(0)) 
        {
            if (triggered == true) 
            {
                StartCoroutine(RespawnAssignment());
            }
            else if (triggered == false)
            {
                scoreManager.MinusPercent();
            }

        }
    }
}
