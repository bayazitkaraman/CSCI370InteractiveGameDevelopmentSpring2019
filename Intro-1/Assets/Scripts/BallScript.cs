using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody rbBall;

    // Start is called before the first frame update
    void Start()
    {
        //You can change gravity feature whenever it starts
        //rbBall.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rbBall.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
