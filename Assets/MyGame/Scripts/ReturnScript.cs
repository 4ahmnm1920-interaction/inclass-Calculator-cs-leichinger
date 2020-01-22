using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnScript : MonoBehaviour
{ 
    public float number1;
    public float number2;
    void Start()
    {
        keinReturn();
        var intReturnValue = intReturn();
        var floatReturnValue = floatReturn();
        var stringReturnValue = stringReturn();
        Debug.Log(intReturnValue);
        Debug.Log(floatReturnValue);
        Debug.Log(stringReturnValue);
    }
    public void keinReturn()
        {
            Debug.Log("Kein Return Value");
        }

        public int intReturn()
        {
            int intR = 3+4;
            return intR;
        }

        public float floatReturn()
        {
            float floatR = 2.5f + 3.7f;
            return floatR;
        }

        public string stringReturn()
        {
            string stringR = "HeyHo";
            return stringR;
        }
    void Update()
    {
        Debug.Log(Random.Range(number1, number2) + Random.Range(number1, number2));
    }
}
