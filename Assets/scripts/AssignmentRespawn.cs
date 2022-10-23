using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentRespawn : MonoBehaviour
{
    //variables for different assignment types
    public GameObject mon;
    public GameObject tues;
    public GameObject wed;
    public GameObject thurs;
    public GameObject fri;
    public GameObject sat;
    public GameObject sun;

    //for assignment respawn position
    private assignment_movement am;

    void Start()
    { //coroutines for respawning assignments
        StartCoroutine(RespawnAssignment(mon));
        StartCoroutine(RespawnAssignment(tues));
        StartCoroutine(RespawnAssignment(wed));
        StartCoroutine(RespawnAssignment(thurs));
        StartCoroutine(RespawnAssignment(fri));
        StartCoroutine(RespawnAssignment(sat));
        StartCoroutine(RespawnAssignment(sun));
    }

    IEnumerator RespawnAssignment(GameObject day)
    {
        while (day == null) 
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("created assignment");
            Instantiate(day, new Vector3(-7f, -1.5f, 0f), Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
