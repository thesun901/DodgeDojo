using UnityEngine;
using System.Collections;

public class stuner : MonoBehaviour {
    private float to_destroy;
    public int speed;
    // Use this for initialization
    void Start () {

        speed = 15;

	}
	
	// Update is called once per frame
	void Update () {

        to_destroy += Time.deltaTime;
        if(to_destroy > 10)
        {
            Destroy(gameObject);
        }


        transform.position += new Vector3(0, speed * Time.deltaTime, 0);

      
	}
}
