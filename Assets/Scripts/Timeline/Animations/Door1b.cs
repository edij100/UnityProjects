using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Door1b : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private LayerMask layer;
    private float range = 10;
    [SerializeField] private GameObject doorE;
    [HideInInspector] static public bool open = false;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip clip;
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        if (Input.GetKey(KeyCode.E))
        {
            if (Physics.Raycast(ray, out RaycastHit hitInfo, range, layer))
            {
                open = true;
                source.PlayOneShot(clip);
            }
        }
        if (Physics.Raycast(ray, out RaycastHit hitInfo2, range, layer) && open == false)
        {
            doorE.SetActive(true);
        }
        else
        {
            doorE.SetActive(false);
        }
    }
}
