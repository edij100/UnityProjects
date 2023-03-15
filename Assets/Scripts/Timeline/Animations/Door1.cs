using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    private Animator door;
    [SerializeField] private AudioSource doorOpenSource;
    [SerializeField] private AudioClip doorOpenClip;

    private void Start()
    {
        door = GetComponent<Animator>();
    }

    void Update()
    {
        if (Door1b.open)
        {
            Open();
        }
    }
    void Open()
    {
        door.Play("OpenDoor");
    }
}
