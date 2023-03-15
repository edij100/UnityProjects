using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class House3ToBroadway : MonoBehaviour
{
    [SerializeField] private Camera cam;
    private float range = 10f;
    [SerializeField] private LayerMask layer;
    [SerializeField] GameObject doorE;

    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);

        if (Input.GetKey(KeyCode.E))
        {
            if (Physics.Raycast(ray, out RaycastHit hitInfo, range, layer))
            {
                SceneManager.LoadScene(10);
            }
        }

        if (Physics.Raycast(ray, out RaycastHit info, range, layer))
        {
            doorE.SetActive(true);
        }
        else
        {
            doorE.SetActive(false);
        }
    }
}
