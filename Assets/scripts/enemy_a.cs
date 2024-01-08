using UnityEngine;
using System.Collections;

public class enemy_a : MonoBehaviour {

    public Vector3 goingto;


	void Start () {
        goingto = this.transform.position;
	}
	

	void Update () {

	    if (Vector3.Distance(this.transform.position, goingto) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(this.transform.position, goingto, 5.5f * Time.deltaTime);
            goingto.z = this.transform.position.z;
        }

        else
        {
            goingto.x = Random.Range(-8.0f, 9.1f);
            goingto.y = Random.Range(-7.0f, 9.1f);

        }







	}
}
