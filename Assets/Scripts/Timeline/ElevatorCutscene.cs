using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ElevatorCutscene : MonoBehaviour
{
    [SerializeField] private PlayableDirector playableDirector;
    [SerializeField] private LayerMask button;
    [SerializeField] private Camera cam;
    [SerializeField] private float range;
    [SerializeField] private GameObject doorE;
    private void Update()
    {
        Ray pickupRay = new Ray(cam.transform.position, cam.transform.forward);

        if (Input.GetKeyDown(KeyCode.E))
        {

            if (Physics.Raycast(pickupRay, out RaycastHit info, range, button))
            {
                Play();
                CameraControl.locked = true;
            }
        }

        if(Physics.Raycast(pickupRay, out RaycastHit hit, range, button))
        {
            doorE.SetActive(true);
        }
        else
        {
            doorE.SetActive(false);
        }
    }
    
    public void Play()
    {
        playableDirector.Play();
    }
}
