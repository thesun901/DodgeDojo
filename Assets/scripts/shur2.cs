using UnityEngine;
using System.Collections;

public class shur2 : MonoBehaviour {
    float todes_m;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        todes_m += Time.deltaTime;
        transform.position += transform.right * 20 * Time.deltaTime;
        if (todes_m > 4)
        {
            Destroy(this.gameObject);
        }
    }
}
