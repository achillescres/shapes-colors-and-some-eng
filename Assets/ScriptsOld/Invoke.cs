using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour {
    // Use this for initialization
    public GameObject gb;
    public GameObject rb;

    private float r;

    public void Awake()
    {
        PlayerPrefs.SetInt("Score", 0);
    }

    void Start()
    {
        StartCoroutine(Invoker());
    }

    IEnumerator Invoker()
    {
        yield return new WaitForSeconds(1f);
        r = Random.Range(1.0f, 2.0f);
        if (Mathf.Round(r) == 1)
        {
            Instantiate(gb, new Vector3(Random.Range(-4.0f, 4.25f), Random.Range(7.0f, 9.0f), -1), Quaternion.Euler(0, 0, Random.Range(1, 360)));
        }
        else
        {
            Instantiate(rb, new Vector3(Random.Range(-4.0f, 4.25f), Random.Range(7.0f, 9.0f), -1), Quaternion.Euler(0, 0, Random.Range(1, 360)));
        }
        r = 0;
        StartCoroutine(Invoker());
    }
        
}

