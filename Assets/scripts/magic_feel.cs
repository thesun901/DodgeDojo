using UnityEngine;
using System.Collections;

public class magic_feel : MonoBehaviour {
    public GameObject magicball;
    public int range;
	void Start () {
        range = 5;
	}

	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            if (Random.Range(1, range) == 1)
            {
                Instantiate(magicball, transform.localPosition, transform.rotation);
            }
        }
    }
}
