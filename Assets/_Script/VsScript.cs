using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VsScript : MonoBehaviour
{
    [SerializeField] float Speed;
    float Xinput;
    float Yinput;
    void Start()
    {
        
    }

    void Update()
    {
        Xinput = Input.GetAxis("Horizontal")*Time.deltaTime;
        Yinput = Input.GetAxis("Vertical")*Time.deltaTime;
        transform.Translate(Xinput*Speed, Yinput * Speed, 0);
    }
}
