using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBlock : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
    }
    public float distance = -1f;

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance); // переменной записываються координаты мыши по иксу и игрику
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition); // переменной - объекту присваиваеться переменная с координатами мыши
        GetComponent<Rigidbody2D>().mass = 0;
        GetComponent<Rigidbody2D>().gravityScale = 0;
        objPosition.z = -1;
        transform.position = Vector3.MoveTowards(transform.position, objPosition, 100000.0f);
        GetComponent<Rigidbody2D>().mass = 1;
        GetComponent<Rigidbody2D>().gravityScale = 0.4f;
    }
}