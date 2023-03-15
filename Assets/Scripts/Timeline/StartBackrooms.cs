using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StartBackrooms : MonoBehaviour
{
    [SerializeField] PlayableDirector backrooms;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            backrooms.Play();
            CameraControl.locked = true;
        }
        
    }
}
