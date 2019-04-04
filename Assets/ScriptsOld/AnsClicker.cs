using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnsClicker : MonoBehaviour {
    public GameObject Manager;
    private ClickManager scr;
	// Use this for initialization
	void Start () {
        scr = Manager.GetComponent<ClickManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        scr.OnClick((int)this.gameObject.name[0]-49);
    }
}
