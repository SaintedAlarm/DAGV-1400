using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single Variable/SimpleFloatData")]
public class SimpleFloatData : ScriptalbeObject
{
   public float value;
   
   public void UpdateValue(float amount)
    {
        valus += amount;
    }

   public void SetValue(float amount)
    {
        value = amount;
    }
}
