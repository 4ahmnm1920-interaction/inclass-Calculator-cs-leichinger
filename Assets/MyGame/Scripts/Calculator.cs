using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField ipf_number1;
    public InputField ipf_number2;
    public Text result;
    public Button btn_add;
    public Button btn_sub;
    public Button btn_multiply;
    public Button btn_divide;
    public Button btn_pythagoras;
    public Text text_operator;


    public void OnAddBtnClick()
    {
        AddNumbersOnClick();
        text_operator.text = "+";
    }

    public void OnSubBtnClick()
    {
        SubNumbersOnClick();
        text_operator.text = "-";
    }

    public void OnMultiplyBtnClick()
    {
        MultiplyNumbersOnClick();
        text_operator.text = "*";
    }

    public void OnDivideBtnClick()
    {
        DivideNumbersOnClick();
        text_operator.text = ":";
    }

    public void OnPythagorasBtnClick()
    {
        var PythagorasResult = PythagorasNumbersOnClick();
        text_operator.text = "pythagoras";
        result.text = PythagorasResult.ToString();
    }

    public void AddNumbersOnClick()
    {
        float number1 = float.Parse(ipf_number1.text);
        float number2 = float.Parse(ipf_number2.text);
        float addResult = number1 + number2;
        result.text = addResult.ToString();
    }

    public void SubNumbersOnClick()
    {
        float number1 = float.Parse(ipf_number1.text);
        float number2 = float.Parse(ipf_number2.text);
        float addResult = number1 - number2;
        result.text = addResult.ToString();
    }

    public void MultiplyNumbersOnClick()
    {
        float number1 = float.Parse(ipf_number1.text);
        float number2 = float.Parse(ipf_number2.text);
        float addResult = number1 * number2;
        result.text = addResult.ToString();
    }

    public void DivideNumbersOnClick()
    {
        float number1 = float.Parse(ipf_number1.text);
        float number2 = float.Parse(ipf_number2.text);
        float addResult = number1 / number2;
        result.text = addResult.ToString();
    }

    public float PythagorasNumbersOnClick()
    {
        float number1 = float.Parse(ipf_number1.text);
        float number2 = float.Parse(ipf_number2.text);
        float aSquare = number1 * number1;
        float bSquare = number2 * number2;
        float squareResult = aSquare + bSquare;
        float addResult = Mathf.Sqrt(squareResult);
        return addResult;
    }
}
