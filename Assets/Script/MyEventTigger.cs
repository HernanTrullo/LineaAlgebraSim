using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MyEventTigger : MonoBehaviour
{
    // Start is called before the first frame update
    public event Action OnMyEvent;

    public void TriggerMyEvent()
    {
        if (OnMyEvent != null)
        {
            OnMyEvent();
        }
    }
}
