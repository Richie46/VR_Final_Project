using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    CharacterController cc;


    void Start()
    {
        cc = GetComponent<CharacterController>();
    }



    // Update is called once per frame
    void Update()
    {
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().volume = Random.Range(0.8f, 1);
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.1f);
            GetComponent<AudioSource>().panStereo = Random.Range(-0.8f, 0.8f);
            GetComponent<AudioSource>().Play();
        }
    }
}
