using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeskControls : MonoBehaviour
{ 

    //renderers for sparkles
    public Renderer re_1;
    public Renderer re_2;

    //make minigame scene variable!!!

    // sparkles don't show up until player hovers over bed
    void Awake()
    { 
        re_1 = GameObject.Find("d_sparkles_1").GetComponent<Renderer>();
        re_1.enabled = false;

        re_2 = GameObject.Find("d_sparkles_2").GetComponent<Renderer>();
        re_2.enabled = false;

    }
    public void OnMouseOver()
    { //player hovering over desk

        re_1.enabled = true;
        re_2.enabled = true;
        Debug.Log("sparkles");
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("computer_minigame");
        }
    }

    private void OnMouseExit()
    { //player not hovering over desk

        re_1.enabled = false;
        re_2.enabled = false;

    }
}
