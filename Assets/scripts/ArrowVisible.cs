using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowVisible : MonoBehaviour
{
    public Renderer re;

    void Start()
    { //arrow isn't visible when not hovering over wall
        re = GetComponent<Renderer>();
        re.enabled = false;

    }

    void OnMouseOver()
    { //arrow visible
        re.enabled = true;
    }

    private void OnMouseExit()
    { //arrow not visible again
        re.enabled = false;
    }
}
