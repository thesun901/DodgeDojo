using UnityEngine;
using System.Collections;

public class ninja : MonoBehaviour {
    public int range;
    public Transform player;
    public Vector3 player_b;
    public float toshot;
    public GameObject shur1;
   
    
	// Use this for initialization
	void Start () {
       // range = 5;
	}
	
	// Update is called once per frame
	void Update () {


        Vector2 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 40 * Time.deltaTime);

        toshot += Time.deltaTime;

        if (toshot > 0.9f)
        {

            if (Random.Range(1, range) == 1)
            {
                Instantiate(shur1, transform.position, transform.localRotation);
            }

            toshot = 0;

        }


    }

}
