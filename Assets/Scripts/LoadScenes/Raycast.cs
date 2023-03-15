using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Raycast : MonoBehaviour
{
    [SerializeField] private LayerMask layer;
    [SerializeField] private Camera cam;
    [SerializeField] private float range;
    [SerializeField] private LayerMask door;
    [SerializeField] private GameObject doorE;

    

    void Update()
    {
        Ray pickupRay = new Ray(cam.transform.position, cam.transform.forward);

        if (Input.GetKeyDown(KeyCode.E))
        {
            if(Physics.Raycast(pickupRay, out RaycastHit info, range, door))
            {
                SceneManager.LoadScene(2);
            }
        }

        if(Physics.Raycast(pickupRay, out RaycastHit hitInfo, range, door))
        {
            doorE.SetActive(true);
        }
        else
        {
            doorE.SetActive(false);
        }
    }
}
