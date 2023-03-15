using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BroadwayToHouse1 : MonoBehaviour
{
    [SerializeField] private Camera cam;
    private float range = 10;
    [SerializeField] private LayerMask layer;
    [SerializeField] private GameObject e;

    private void Update()
    {
        Ray Ray = new Ray(cam.transform.position, cam.transform.forward);

        if (Input.GetKey(KeyCode.E))
        {
            if (Physics.Raycast(Ray, out RaycastHit info, range, layer))
            {
                SceneManager.LoadScene(5);
            }
        }

        if(Physics.Raycast(Ray, out RaycastHit hitInfo, range, layer))
        {
            e.SetActive(true);
        }
        else
        {
            e.SetActive(false);
        }
    }
}
