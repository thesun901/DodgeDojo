using UnityEngine;
using System.Collections;

public class arrow_spawner : MonoBehaviour {

    public GameObject arr;
    public float as_timer;
    public AudioClip swoop;
    public int range;

	// Use this for initialization
	void Start () {

        
    }
	
	// Update is called once per frame
	void Update () {
        as_timer += Time.deltaTime;

        if(as_timer > 1.25f)
        {
            as_timer = 0;
            if (Random.Range(1, range) == 1)
            {
                Instantiate(arr, transform.position, transform.localRotation);
                AudioSource.PlayClipAtPoint(swoop, transform.localPosition);
            }
        }
	
	}
}
