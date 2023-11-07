using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpelareOlikaAnim : MonoBehaviour
{


    Animator johannesAnimator;


    // Start is called before the first frame update
    void Start()
    {

        johannesAnimator = GetComponent<Animator>();

        johannesAnimator.SetBool("Walk", false);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {              
            johannesAnimator.SetBool("Walk", true);
        }
       if (Input.GetKeyDown("a"))
        {
            johannesAnimator.SetBool("Walk", true);
        }
       
        if (Input.GetKeyDown("s"))
        {
            johannesAnimator.SetBool("Walk", true);
        }
       
        if (Input.GetKeyDown("d"))
        {
            johannesAnimator.SetBool("Walk", true);
        }
        
        if (Input.GetKeyUp("w"))
        {
            johannesAnimator.SetBool("Walk", false);
        }
        if (Input.GetKeyUp("a"))
        {
            johannesAnimator.SetBool("Walk", false);
        }
        if (Input.GetKeyUp("s"))
        {
            johannesAnimator.SetBool("Walk", false);
        }
        if (Input.GetKeyUp("d"))
        {
            johannesAnimator.SetBool("Walk", false);
        }
    }
}
