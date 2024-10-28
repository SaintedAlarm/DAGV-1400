using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTriggerEventBehaviour1 : MonoBehaviour
{
    public UnityEvent triggerEvent;
    
    private void OnTriggerEnter(Collider other)
        {
            triggerEvent.Invoke();
            }
}
