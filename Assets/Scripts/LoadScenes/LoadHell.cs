using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadHell : MonoBehaviour
{
    public void Load()
    {
        SceneManager.LoadScene(2);
        CameraControl.locked = false;
    }
    
}
