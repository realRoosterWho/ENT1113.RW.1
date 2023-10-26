using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ThirdPersonMovement : MonoBehaviour

{
    public CharacterController controller;
    public float gravity = 9.81f;
    public float jumpHeight = 3f;
    public Transform cam;
    public float speed = 6f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    
    public AudioClip footstepSound;
    public AudioClip backgroundMusic;
    public AudioMixerGroup mixer;
    
    // Start is called before the first frame update
    void Start()
    {
        //播放bgm
        SoundManager.Instance.PlayMusic(backgroundMusic);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); 
        float vertical = Input.GetAxisRaw("Vertical");
        
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
   
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward.normalized;
            controller.Move(moveDir * speed * Time.deltaTime);
        }
        
                
        Vector3 gravityVector = Vector3.down * gravity * Time.deltaTime;
        controller.Move(gravityVector);
        
        //footsteps
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            SoundManager.Instance.EnableSFX(footstepSound, mixer);
        }
        else
        {
            SoundManager.Instance.DisableSFX();
        }


        
        
    }
}
