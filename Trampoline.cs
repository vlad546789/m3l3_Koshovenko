using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider Other)
    {
        Other.GetComponent<Jump>().jumpStrength = 10;
    }

    void OnTriggerExit(Collider Other)
    {
        Other.GetComponent<Jump>().jumpStrength = 2;
    }
}
