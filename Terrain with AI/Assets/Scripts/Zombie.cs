//Bayazit Karaman
//Hendrix College

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{

    public float health = 60f;
    public float walkRange = 15f;
    public float attackRange = 2f;
    public float distance;
    public int die = 0;
    public float speed;
    public Vector3 position;

    public Animator anim;
    public GameObject fps;
    public GameObject zom;
    public GameObject enemy;

    public void Start()
    {
        anim = zom.GetComponent<Animator>();
        speed = 0.02f;

        //for(int i =0; i<4; i++)
        //{
        //    position = new Vector3(Random.Range(1f, 1000f), 0.89f, Random.Range(1f, 1000f));
        //    Instantiate(enemy, position, Quaternion.identity);
        //}
    }

    public void Update()
    {
        if(die==1)
        {
            //Do not call any animation
        }
        else
        {
            distance = Vector3.Distance(transform.position, fps.transform.position);

            if (distance < attackRange)
            {
                transform.LookAt(fps.transform);
                anim.Play("attack");
            }
            else if (distance < walkRange)
            {
                transform.LookAt(fps.transform);
                transform.position = Vector3.MoveTowards(transform.position, fps.transform.position, speed);
                anim.Play("walk");
            }
        }   
    }

    public void Damage(float amount)
    {
        health = health - amount;

        if (health <= 0f)
        {
            anim.Play("fallingback");
            die = 1;
        }
    }

}
