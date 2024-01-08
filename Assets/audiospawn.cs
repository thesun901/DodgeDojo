using UnityEngine;
using System.Collections;

public class audiospawn : MonoBehaviour {
    public AudioClip spawningsound;
	// Use this for initialization
	void Start () {
        AudioSource.PlayClipAtPoint(spawningsound, transform.localPosition);
    }
	
}
