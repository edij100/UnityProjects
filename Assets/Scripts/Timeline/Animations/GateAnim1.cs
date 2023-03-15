using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GateAnim1 : MonoBehaviour
{
    [HideInInspector] static public bool gate1Open = false;
    [SerializeField] private PlayableDirector gate1;


    void Update()
    {
        if (gate1Open)
        {
            GateAnim01();
        }
    }
    public void GateAnim01()
    {
        gate1.Play();
    }
}
