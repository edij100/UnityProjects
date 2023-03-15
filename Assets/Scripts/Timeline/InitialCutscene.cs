using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class InitialCutscene : MonoBehaviour
{
    public PlayableDirector playableDirector;
    void Start()
    {
        playableDirector.Play();
        CameraControl.locked = true;
    }
}
