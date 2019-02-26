using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //Add this for NavMeshAgent

public class Controller : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent meshAgent;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //Pressed primary button
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                meshAgent.SetDestination(hit.point);
            }
        }
    }
}
