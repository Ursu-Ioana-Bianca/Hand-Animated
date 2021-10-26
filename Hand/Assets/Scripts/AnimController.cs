using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public GameObject hand;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("1key")) // apasare tasta w pentru a incepe prima animatie
        {
            hand.GetComponent<Animator>().Play("Armature|ArmatureAction");
        }

        if (Input.GetButtonDown("2key"))  // apasare tasta s pentru a incepe a doua animatie
        {
            hand.GetComponent<Animator>().Play("Armature|ArmatureAction_001");
        }
    }
}
