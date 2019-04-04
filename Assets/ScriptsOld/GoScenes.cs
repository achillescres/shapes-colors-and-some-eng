using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoScenes : MonoBehaviour
{
    public string ToBeOn;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        Application.LoadLevel(ToBeOn);
    }
}