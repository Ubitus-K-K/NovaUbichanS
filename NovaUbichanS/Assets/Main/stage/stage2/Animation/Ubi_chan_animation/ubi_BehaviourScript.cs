using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ubi_BehaviourScript : MonoBehaviour
{
    private Animator UbiAnimator;

    // Start is called before the first frame update
    void Start()
    {
        UbiAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(UbiAnimator != null)
        {
            if(Input.GetKeyDown(KeyCode.Keypad1))
            {
                UbiAnimator.SetTrigger("Ubi_idle");
            }
            
            if(Input.GetKeyDown(KeyCode.Keypad2))
            {
                UbiAnimator.SetTrigger("Ubi_happy");
            }

            if(Input.GetKeyDown(KeyCode.Keypad3))
            {
                UbiAnimator.SetTrigger("Ubi_angry");
            }

            if(Input.GetKeyDown(KeyCode.Keypad4))
            {
                UbiAnimator.SetTrigger("Ubi_sad");
            }

            if(Input.GetKeyDown(KeyCode.Keypad5))
            {
                UbiAnimator.SetTrigger("Ubi_neutral");
            }

            if(Input.GetKeyDown(KeyCode.Keypad6))
            {
                UbiAnimator.SetTrigger("Ubi_photo");
            }

            if(Input.GetKeyDown(KeyCode.Keypad7))
            {
                UbiAnimator.SetTrigger("Ubi_relax");
            }

            if(Input.GetKeyDown(KeyCode.Keypad8))
            {
                UbiAnimator.SetTrigger("Ubi_dance");
            }
        }
    }
}
