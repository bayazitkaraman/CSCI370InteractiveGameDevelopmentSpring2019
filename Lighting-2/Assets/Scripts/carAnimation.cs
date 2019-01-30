//Dr. Bayazit Karaman
//Hendrix College

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carAnimation : MonoBehaviour
{
    public GameObject HeadLights, BackLights, InteriorLight, leftDoor, rightDoor;

    public Light spotLeft, spotRight, pointLeft, pointRight;

    bool brightLight = false; //bright light
    bool leftDoorFlag = false;
    bool rightDoorFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        HeadLights.SetActive(false);
        BackLights.SetActive(false);
        InteriorLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //open left door
            //open interior light
            if (leftDoorFlag == false)
            {
                leftDoor.transform.Rotate(0f, 45f, 0f);
                InteriorLight.SetActive(true);
                leftDoorFlag = true;
            }
            else
            {
                leftDoor.transform.Rotate(0f, -45f, 0f);
                InteriorLight.SetActive(false);
                leftDoorFlag = false;
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //open right door
            //call interior light function

            if (rightDoorFlag == false)
            {
                rightDoor.transform.Rotate(0f, -45f, 0f);
                InteriorLight.SetActive(true);
                rightDoorFlag = true;
            }
            else
            {
                rightDoor.transform.Rotate(0f, 45f, 0f);
                InteriorLight.SetActive(false);
                rightDoorFlag = false;
            } 
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //open headlights
            bool heLight = HeadLights.activeSelf;
            if (heLight)
            {
                HeadLights.SetActive(false);
            }
            else
            {
                HeadLights.SetActive(true);
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            bool breLight = BackLights.activeSelf;
            if (breLight)
            {
                BackLights.SetActive(false);
            }
            else
            {
                BackLights.SetActive(true);
            }
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            //open bright lights
            bool heLight = HeadLights.activeSelf;
            if (heLight)
            {
                if (brightLight)
                {
                    spotLeft.intensity = 1;
                    spotRight.intensity = 1;
                    brightLight = false;
                }
                else
                {
                    spotLeft.intensity = 10;
                    spotRight.intensity = 10;
                    brightLight = true;
                }
            }

        }
    }
}
