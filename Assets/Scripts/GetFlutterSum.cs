using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFlutterSum : MonoBehaviour {
    public GameObject f;
    private bool g;
	// Use this for initialization
	void Start () {
        g = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseOver()
    {
        if (g==false)
        {
            f.GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }
    private void OnMouseExit()
    {
        f.GetComponent<SpriteRenderer>().color = Color.white;
    }

    private void OnMouseDown()
    {
        g = true;
        print("TR");
        f.GetComponent<SpriteRenderer>().color = Color.gray;
        PlayerPrefs.SetString("sum", PlayerPrefs.GetString("sum") + this.gameObject.name);
    }
    private void OnMouseUp()
    {
        g = false;
    }
}
