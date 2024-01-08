using UnityEngine;
using System.Collections;

public class sword_spawner : MonoBehaviour {

    private float cut;
    public GameObject swrd;
    public GameObject swrd2;
    public AudioClip sword_swing;
    public bool wasshot;
	// Use this for initialization
	void Start () {
        wasshot = false;
	}
	
	// Update is called once per frame
	void Update () {
        cut += Time.deltaTime;
        if (cut > 1.1f && wasshot == false)
        {
            Instantiate(swrd, transform.localPosition + new Vector3(40, 0, 0), swrd2.transform.rotation);
            Instantiate(swrd, transform.localPosition + new Vector3(0, -40, 0), swrd.transform.rotation);
            wasshot = true;
            
        }

        if (cut > 1.8f)
        {
            AudioSource.PlayClipAtPoint(sword_swing, transform.localPosition);
            Destroy(gameObject);
        }

    }
}