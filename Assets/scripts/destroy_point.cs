using UnityEngine;
using System.Collections;

public class destroy_point : MonoBehaviour {
    public float dest;

	// Use this for initialization
	void Start () {
        dest = 0;
	}
	
	// Update is called once per frame
	void Update () {
        dest += Time.deltaTime;

        if(dest >= 1f)
        {
            Destroy(this.gameObject);
        }
	}
}
