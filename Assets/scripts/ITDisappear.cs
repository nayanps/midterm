using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITDisappear : MonoBehaviour
{
    public Renderer re;

    void Start()
    {
        re = GetComponent<Renderer>();
        StartCoroutine(Disappear());
    }

    IEnumerator Disappear()
    { //thoughts disappear after 10s, reappear after 3s
        while (true) 
        {
            re.enabled = true;
            yield return new WaitForSeconds(10f);
            re.enabled = false;
            yield return new WaitForSeconds(3f);
        }
        
    }
}
