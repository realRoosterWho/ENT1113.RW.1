using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps_SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource footstepSound;

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            footstepSound.enabled = true;
        }
        else
        {
            footstepSound.enabled = false;
        }


    }
}
