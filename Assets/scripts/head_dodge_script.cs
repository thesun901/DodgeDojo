using UnityEngine;
using System.Collections;

public class head_dodge_script : MonoBehaviour {

    public moving plr;
    public int dodgeing;

    public GameObject arspawn1;
    public GameObject arspawn2;
    public GameObject ninjaSpawn;
    public GameObject swordSpawn;
    public GameObject stunSpawn;
    public GameObject fireSpawn;

    public arrow_spawner Script_ArrowSpawn;
    public arrow_spawner Script_ArrowSpawn2;
    public sword_spawn Script_SignSpawn;
    public magic_feel Script_MagicSpawn;
    public spawner_fire Script_fireSpawn;
    public ninja Script_ShurikenSpawn;

    public arrow Arrow1;
    public arrow2 Arrow2;
    public shuriken Shur;
    public fire_ball fireBall;

    public float head_timer;
    public float lvl_timer;
    public int lvl;
    public int randomer;

   

    void Start()
    {
        Script_ArrowSpawn.range = 4;
        Script_ArrowSpawn2.range = 4;
        arspawn1.active = false; arspawn2.active = false; ninjaSpawn.active = false;
        swordSpawn.active = false; stunSpawn.active = false; fireSpawn.active = false;
        Time.timeScale = 0;
        lvl_timer = 18;
        AudioListener.volume = PlayerPrefs.GetFloat("Volume");
    }

    void Update()
    {
        

        head_timer += Time.deltaTime;

            level();   

    }

    void level()
    {
        lvl_timer += Time.deltaTime;
        if(lvl_timer > 20)
        {
            lvl_timer = 0;
            randomer = Random.Range(1, 4);
            lvl++;
        }

        if(lvl == 1 || lvl == 2)
        {
            if(randomer == 1)
            {
                arspawn1.active = true; arspawn2.active = true; ninjaSpawn.active = false;
                swordSpawn.active = false; stunSpawn.active = true; fireSpawn.active = false;
                Arrow1.speed = 16; Arrow2.speed = 16;
            }

            if (randomer == 2)
            {
                arspawn1.active = true; arspawn2.active = true; ninjaSpawn.active = true;
                swordSpawn.active = false; stunSpawn.active = false; fireSpawn.active = false;
                Arrow1.speed = 13; Arrow2.speed = 13;
                Script_ShurikenSpawn.range = 3;
            }

            if (randomer == 3)
            {
                arspawn1.active = true; arspawn2.active = true; ninjaSpawn.active = true;
                swordSpawn.active = true; stunSpawn.active = false; fireSpawn.active = false;
                Script_SignSpawn.rand_sword = 7;
                Shur.speed = 12;
                Arrow1.speed = 13; Arrow2.speed = 13;
                Script_ShurikenSpawn.range = 4;
            }

            if (randomer == 4)
            {
                arspawn1.active = false; arspawn2.active = false; ninjaSpawn.active = true;
                swordSpawn.active = true; stunSpawn.active = false; fireSpawn.active = false;
                Script_SignSpawn.rand_sword = 5;
                Shur.speed = 14;
                Script_ShurikenSpawn.range = 4;
            }
        }

        if (lvl == 3)
        {
            if (randomer == 1)
            {
                arspawn1.active = false; arspawn2.active = false; ninjaSpawn.active = false;
                swordSpawn.active = false; stunSpawn.active = false; fireSpawn.active = true;
            }

            if (randomer == 2)
            {
                arspawn1.active = false; arspawn2.active = false; ninjaSpawn.active = true;
                swordSpawn.active = false; stunSpawn.active = true; fireSpawn.active = false;
                Script_MagicSpawn.range = 2;
                Script_ShurikenSpawn.range = 3;
            }

            if (randomer == 3)
            {
                arspawn1.active = false; arspawn2.active = false; ninjaSpawn.active = false;
                swordSpawn.active = true; stunSpawn.active = false; fireSpawn.active = false;
                Script_SignSpawn.rand_sword = 3;
            }

            if (randomer == 4)
            {
                arspawn1.active = true; arspawn2.active = true; ninjaSpawn.active = false;
                swordSpawn.active = true; stunSpawn.active = false; fireSpawn.active = false;
                Script_SignSpawn.rand_sword = 5;
                Arrow1.speed = 20; Arrow2.speed = 20;

            }
        }

        if (lvl == 4)
        {
            if (randomer == 1)
            {
                arspawn1.active = true; arspawn2.active = true; ninjaSpawn.active = false;
                swordSpawn.active = true; stunSpawn.active = true; fireSpawn.active = false;
                Script_SignSpawn.rand_sword = 4;
                Arrow1.speed = 20; Arrow2.speed = 20;
                Script_MagicSpawn.range = 3;
            }

            if (randomer == 2)
            {
                arspawn1.active = false; arspawn2.active = false; ninjaSpawn.active = true;
                swordSpawn.active = false; stunSpawn.active = false; fireSpawn.active = false;
                Shur.speed = 18;
                Script_ShurikenSpawn.range = 2;
            }

            if (randomer == 3)
            {
                arspawn1.active = false; arspawn2.active = false; ninjaSpawn.active = true;
                swordSpawn.active = false; stunSpawn.active = true; fireSpawn.active = false;
                Script_ShurikenSpawn.range = 3;
                Shur.speed = 13;
                Script_MagicSpawn.range = 2;
            }

            if (randomer == 4)
            {
                arspawn1.active = true; arspawn2.active = true; ninjaSpawn.active = false;
                swordSpawn.active = true; stunSpawn.active = true; fireSpawn.active = false;
                Shur.speed = 13;
                Script_ShurikenSpawn.range = 3;
                Script_SignSpawn.rand_sword = 4;
                Arrow1.speed = 22; Arrow2.speed = 13;

            }
        }

        if (lvl == 5 || lvl == 6)
        {
            if (randomer == 1)
            {
                arspawn1.active = false; arspawn2.active = false; ninjaSpawn.active = false;
                swordSpawn.active = true; stunSpawn.active = false; fireSpawn.active = true;
                Script_SignSpawn.rand_sword = 4;
            }

            if (randomer == 2)
            {
                arspawn1.active = true; arspawn2.active = true; ninjaSpawn.active = true;
                swordSpawn.active = false; stunSpawn.active = true; fireSpawn.active = false;
                Script_ArrowSpawn.range = 2;
                Script_ArrowSpawn2.range = 2;
                Arrow1.speed = 19; Arrow2.speed = 19;
            }

            if (randomer == 3)
            {
                arspawn1.active = true; arspawn2.active = true; ninjaSpawn.active = true;
                swordSpawn.active = false; stunSpawn.active = false; fireSpawn.active = false;
                Arrow1.speed = 20; Arrow2.speed = 20;
                Script_ArrowSpawn.range = 2;
                Script_ArrowSpawn2.range = 2;
                Script_ShurikenSpawn.range = 5;
            }

            if (randomer == 4)
            {
                arspawn1.active = false; arspawn2.active = false; ninjaSpawn.active = true;
                swordSpawn.active = true; stunSpawn.active = false; fireSpawn.active = true;
                Script_ShurikenSpawn.range = 4;
                
            }
        }

        if (lvl >= 7)
        {
            if (randomer == 1)
            {
                arspawn1.active = true; arspawn2.active = true; ninjaSpawn.active = true;
                swordSpawn.active = true; stunSpawn.active = false; fireSpawn.active = false;
                Arrow1.speed = Random.Range(14, 28);
                Arrow2.speed = Random.Range(14, 28);
                Script_ArrowSpawn.range = Random.Range(1,4);
                Script_ArrowSpawn2.range = 3;
                Script_SignSpawn.rand_sword = Random.Range(1, 12);
                Script_ShurikenSpawn.range = 8;
            }

            if (randomer == 2)
            {
                arspawn1.active = true; arspawn2.active = false; ninjaSpawn.active = true;
                swordSpawn.active = false; stunSpawn.active = true; fireSpawn.active = false;
                Script_ArrowSpawn.range = 1;
                Script_ArrowSpawn.range = 1;
                Arrow1.speed = 11; Arrow2.speed = 11;

                Script_ShurikenSpawn.range = 5;
                Shur.speed = 21;
            }

            if (randomer == 3)
            {
                arspawn1.active = true; arspawn2.active = true; ninjaSpawn.active = true;
                swordSpawn.active = true; stunSpawn.active = true; fireSpawn.active = false;
                Script_ArrowSpawn.range = 3;
                Script_ArrowSpawn.range = 3;
                Arrow1.speed = 15; Arrow2.speed = 15;

                Script_ShurikenSpawn.range = 5;
                Shur.speed = 13;

                Script_MagicSpawn.range = 5;
            }

            if (randomer == 4)
            {
                randomer = 3;
            }
        }
    }




    
}
