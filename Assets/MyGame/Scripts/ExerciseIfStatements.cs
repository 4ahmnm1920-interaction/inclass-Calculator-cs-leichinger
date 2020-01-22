using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseIfStatements : MonoBehaviour
{
    public bool condition;
    void Start()
    {
        if(condition)
        {
            Debug.Log("Diese Aussage(Condition) ist richtig");
        }
        else
        {
            Debug.Log("Jetzt ist falsh");
        }
    }
}
