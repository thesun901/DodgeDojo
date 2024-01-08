using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {

    public float balance_timer;
    public float speed;
    public float normal_spped;
    public float less_spped;
    public float walkrange;
    public Vector3 position2;
    public GameObject point;
    public bool alive;
    public float stuntimer;
    public Sprite hero_n1;
    public Sprite hero_n2;
    public Sprite hero_n3;
    public Sprite hero_n4;
    public Sprite hero_a;
    public Sprite hero_s;
    public AudioClip dmg;
    public AudioSource source;
    public int Health;
    public int points;

	void Start () {

        hero_a = hero_n1;
        position2 = this.transform.position;
        alive = true;
        Health = 4;
        less_spped = speed - 0.4f;
        normal_spped = speed;
     
	}
	
	// Update is called once per frame
	void Update () {

        hp();
        actualy();

        if (alive == false)
        {
            stuntimer += Time.deltaTime;
            if(stuntimer > 1.8f)
            {
                alive = true;
                stuntimer = 0;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = hero_a;
            }
        }

        walkrange = Vector3.Distance(position2, this.transform.position);

        if (alive == true)
        {
            if (Input.GetMouseButtonDown(1) && Time.timeScale > 0)
            {
                position2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                position2.z = this.transform.position.z;
                Instantiate(point, position2, Quaternion.identity);
                speed = normal_spped;
                balance_timer = 0;
                
            }

           /* if (Input.GetMouseButton(1))
            {
                position2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                position2.z = this.transform.position.z;
                balance_timer += Time.deltaTime;            
            } 

            if (balance_timer > 0.2f)
            {
                speed = less_spped;

            } */


            if (Vector3.Distance(position2, this.transform.position) > 0.1f)
            {
                transform.position = Vector3.MoveTowards(this.transform.position, position2, speed * Time.deltaTime);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                position2 = transform.position;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "stun")
        {
            alive = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hero_s;
        }

        if (col.gameObject.tag == "evil")
        {
            source.PlayOneShot(dmg);
            Health -= 1;
        }

        if (col.gameObject.tag == "points")
        {
            points += 1;
        }
    }

    void hp()
    {

        if (Health == 4 && alive == true)
        {
            hero_a = hero_n1;
        }

        if (Health == 3 && alive == true)
        {
            hero_a = hero_n2;
        }

        if (Health == 2 && alive == true)
        {
            hero_a = hero_n3;
        }

        if (Health == 1 && alive == true)
        {
            hero_a = hero_n4;
        }

    }

    void actualy()
    {
        if (alive == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hero_a;
        }
    }
}
