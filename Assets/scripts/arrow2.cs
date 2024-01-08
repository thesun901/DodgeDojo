using UnityEngine;
using System.Collections;

public class arrow2 : MonoBehaviour {
  
    public int speed;

	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        

        transform.position += new Vector3(speed * Time.deltaTime, -speed * Time.deltaTime, 0);
    }
}
