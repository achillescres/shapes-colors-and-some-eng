using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    public GameObject obj;

    public void Setup(GameObject object1)
    {
        obj = object1;
        StartCoroutine("DesTime");
    }

    IEnumerator DesTime()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(obj);
    }
}
