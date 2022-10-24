using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BedControls : MonoBehaviour
{ //NOT ACTUALLY BED CONTROLS. REUSE FOR COMPUTER /W/ VARIABLE FOR SCENE.

    //renderers for sparkles
    public Renderer re_1;
    public Renderer re_2;

    //make minigame scene variable!!!

    // sparkles don't show up until player hovers over bed
    void Awake()
    { 
        re_1 = GameObject.Find("sparkles_1").GetComponent<Renderer>();
        re_1.enabled = false;

        re_2 = GameObject.Find("sparkles_2").GetComponent<Renderer>();
        re_2.enabled = false;

    }


    private void OnMouseOver()
    { //player hovering over bed

        re_1.enabled = true;
        re_2.enabled = true;
    }

    private void OnMouseExit()
    { //player not hovering over bed

        re_1.enabled = false;
        re_2.enabled = false;

    }
}
