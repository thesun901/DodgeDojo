using UnityEngine;
using System.Collections;

public class shuriken : MonoBehaviour {

    public GameObject mini_shur1;
    public GameObject mini_shur2;
    public GameObject mini_shur3;
    public float todes;
    public AudioClip triple;
    public int speed;
	// Use this for initialization
	void Start () {
      //  speed = 11;
	}
	
	// Update is called once per frame
	void Update () {

        transform.position += transform.right * speed * Time.deltaTime;
        todes += Time.deltaTime;
       
        if (todes > 1.8f)
        {
            AudioSource.PlayClipAtPoint(triple, transform.localPosition, 100f);
            Instantiate(mini_shur1, transform.position, mini_shur1.transform.rotation * transform.localRotation);
            Instantiate(mini_shur2, transform.position, mini_shur2.transform.rotation * transform.localRotation);
            Instantiate(mini_shur3, transform.position, mini_shur3.transform.rotation * transform.localRotation);

            Destroy(this.gameObject);
        }
    }
}
