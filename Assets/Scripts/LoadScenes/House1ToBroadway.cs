using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class House1ToBroadway : MonoBehaviour
{
    [SerializeField] private Camera cam;
    private float range = 10;
    [SerializeField] private LayerMask layer;
    [SerializeField] private GameObject e;

    private void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);

        if (Input.GetKey(KeyCode.E))
        {
            if (Physics.Raycast(ray, out RaycastHit hitInfo, range, layer))
            {
                SceneManager.LoadScene(8);
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
