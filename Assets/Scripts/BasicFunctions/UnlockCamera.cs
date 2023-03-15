using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCamera : MonoBehaviour
{
    public void Unlock()
    {
        CameraControl.locked = false;
    }
}
