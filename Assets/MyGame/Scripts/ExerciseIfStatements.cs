using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseIfStatements : MonoBehaviour
{

    public bool condition;
    public string text;
    public string text2;
    void Start()
    {
        
    }

    void Update() 
    {
        float wert = Random.Range(5f,15f);
        
        if(wert>10f)
        {
            //Debug.Log("Diese Aussage(Condition) ist richtig");
        }
        else
        {
            Debug.Log("Jetzt ist falsh");
        }


//Mit den && (und) Operator - Beide müssen richtig sein
        if(text == text2 && condition)
        {
            //Debug.Log("Text entpsricht text2");
        }
        else
        {
           // Debug.Log("Text entspricht nicht Text 2");
        }

//mit dem || (oder) Operator muss eines der bieden richtig sein
        if(text == text2 || condition)
        {
            Debug.Log("Einer der beiden Koditions ist richtig");
        }
        
    }


}
