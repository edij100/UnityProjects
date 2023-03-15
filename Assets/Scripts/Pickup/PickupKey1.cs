using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKey1 : MonoBehaviour
{
    [SerializeField] private LayerMask layer;
    [SerializeField] private Camera cam;
    [SerializeField] private float range;
    [SerializeField] private GameObject key;
    [SerializeField] private LayerMask layer2;
    [SerializeField] private GameObject e;
    [SerializeField] private GameObject doorE;
    bool hasKey = false;
    bool open = false;

    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);

        if (Input.GetKey(KeyCode.E))
        {
            

            if (Physics.Raycast(ray, out RaycastHit hitInfo, range, layer))
            {
                key.SetActive(false);
                hasKey = true;
            }
            if (Physics.Raycast(ray, out RaycastHit hitInfo2, range, layer2))
            {
                if (hasKey)
                {
                    GateAnim1.gate1Open = true;
                    open = true;
                }
            }
        }

        if(Physics.Raycast(ray, out RaycastHit hitInfo3, range, layer))
        {
            e.SetActive(true);
        }
        else
        {
            e.SetActive(false);
        }

        if (Physics.Raycast(ray, out RaycastHit hitInfo4, range, layer2))
        {
            if (hasKey && open == false)
            {
                doorE.SetActive(true);
            }
        }
        else
        {
            doorE.SetActive(false);
        }
    }
}
