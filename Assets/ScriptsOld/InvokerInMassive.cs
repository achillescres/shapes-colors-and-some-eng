using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokerInMassive : MonoBehaviour {
    public GameObject[] MassiveTrue;
    public GameObject[] MassiveFalse;
    private void Awake()
    {
        PlayerPrefs.SetInt("Score", 0);
    }
    void Start()
    {
        StartCoroutine("Ins");
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("Score") == 40)
        {
            Application.LoadLevel(6);
        }
    }

    IEnumerator Ins()
    {
        yield return new WaitForSeconds(1.2f);
        if (Mathf.Round(Random.Range(1f, 2f)) == 1)
        {
            Instantiate(MassiveTrue[(int)Mathf.Round(Random.Range(1f, 6f))-1], new Vector3(Random.Range(-4.0f, 4.25f), Random.Range(7.0f, 9.0f), -1), Quaternion.Euler(0, 0, Random.Range(1, 360)));
        }
        else
        {
            Instantiate(MassiveFalse[(int)Mathf.Round(Random.Range(1f, 6f))-1], new Vector3(Random.Range(-4.0f, 4.25f), Random.Range(7.0f, 9.0f), -1), Quaternion.Euler(0, 0, Random.Range(1, 360)));
        }
        StartCoroutine("Ins");
    }
}
