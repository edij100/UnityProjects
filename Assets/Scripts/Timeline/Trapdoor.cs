using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Trapdoor : MonoBehaviour
{
    [SerializeField] LayerMask layer;
    [SerializeField] Camera cam;
    float range = 10;
    [SerializeField] PlayableDirector trapdoor;
    [SerializeField] GameObject e;
    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);

        if (Input.GetKey(KeyCode.E))
        {
            if(Physics.Raycast(ray, out RaycastHit hitInfo, range, layer))
            {
                trapdoor.Play();
            }
        }
        if (Physics.Raycast(ray, out RaycastHit hitInfo2, range, layer))
        {
            e.SetActive(true);
        }
        else
        {
            e.SetActive(false);
        }
    }
}
