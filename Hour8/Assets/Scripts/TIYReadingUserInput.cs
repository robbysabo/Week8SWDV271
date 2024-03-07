using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIYReadingUserInput : MonoBehaviour
{
    private void Update()
    {
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");
        if (hVal != 0)
            print("Horizontal movement selected: " + hVal);
        if (vVal != 0)
            print("Vertical movement selected: " + vVal);
    }
}
