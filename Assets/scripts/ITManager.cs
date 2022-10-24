using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ITManager : MonoBehaviour
{
    public GameObject it;
    public int it_total=0;
    public static ITManager instance;
    public HealthManager healthManager;

    private void Awake()
    {
        instance = this;
        healthManager = FindObjectOfType<HealthManager>();
    }
    void Start()
    {
        StartCoroutine(GenerateIT());

    }

    IEnumerator GenerateIT()
    { //generates its every 0.25s
        while (it_total < 120)
        {
            var it_pos_range = new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-5.0f, 5.0f),0);
            Instantiate(it,it_pos_range,Quaternion.identity);
            it_total+=1;
            Debug.Log(it_total);

            yield return new WaitForSeconds(0.25f);
        }

        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene("room");
        healthManager.MinusHealth();

        yield break;
    }

    public void ClickIT()
    {
        it_total-=1;
    }
}
