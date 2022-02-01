using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioClip[] clipbtn;
    public AudioSource[] btnsound;

    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 0; i < btnsound.Length; i++)
        {
            btnsound[i].clip = clipbtn[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
