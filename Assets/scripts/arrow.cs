using UnityEngine;
using System.Collections;

public class arrow : MonoBehaviour {

   
    public int speed;

	void Start () {
       // speed = 12;
	}
	
	
	void Update () {

        transform.position += new Vector3(-speed * Time.deltaTime, speed * Time.deltaTime, 0);
    }
}
