using UnityEngine;
using System.Collections;

public class spawner_fire : MonoBehaviour {
    float tofire;
    public GameObject ball;
    public AudioClip flame1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        tofire += Time.deltaTime;
        if (tofire > 1.25f)
        {
            Instantiate(ball, transform.position, transform.localRotation);
            tofire = 0;
            AudioSource.PlayClipAtPoint(flame1, transform.localPosition);
        }

    }
}
