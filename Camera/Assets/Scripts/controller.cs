//Bayazit Karaman
//Hendrix College

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private float speed;
    public Rigidbody rbCap;
    private bool start;
    private float timeleft = 15.0f;
    private int point = 70;
    private bool gmOver = false;
    public TextMesh textPoint;
    public TextMesh textTime;
    public TextMesh textWin;
    public TextMesh textLost;

    void Start()
    {
        speed = 8f;
        start=false;
        textPoint.text = "Points: 70";
        textTime.text = "Time: 15:00";
    }

    void GameOver()
    {
        gmOver = true;
        transform.position = new Vector3(-0.2f, 0.82f ,- 51.79f);
    }

    void Win()
    {
        textWin.transform.position = new Vector3(-9.6f, 5.52f, -51.79f);
    }

    void Lost()
    {
        textPoint.text = "Points: 0";
        textTime.text = "Time: 00:00";
        textLost.transform.position = new Vector3(-9.6f, 5.52f, -51.79f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "cubes")
        {
            point = point - 10;
            textPoint.text = "Points: " + point.ToString();
            Destroy(collision.gameObject);
        }
        else if(collision.collider.name == "Wall3")
        {
            Win();
            GameOver();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && !start && !gmOver)
        {
            start = true;
        }
        else if (start && !gmOver)
        {
            timeleft = timeleft - Time.deltaTime;
            textTime.text = "Time: " + timeleft.ToString();
            if (timeleft > 0)
            {
                transform.Translate((speed * Input.GetAxis("Horizontal") * Time.deltaTime), 0f, (speed * Input.GetAxis("Vertical") * Time.deltaTime));
                if (Input.GetMouseButton(0))
                {
                    rbCap.AddForce(0, 20, 0);
                }
            }
            else
            {
                Lost();
                GameOver();
            }
        }
    }
}
