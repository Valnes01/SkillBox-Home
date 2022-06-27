using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculator : MonoBehaviour
{
    [SerializeField] private InputField numOne;
    [SerializeField] private InputField numTwo;
    [SerializeField] private Text resultCal;
    public int numb1;
    public int numb2;
    void Start()
    {
        resultCal.text = "Результат";
    }
    private void onConvertNum()
    {
        numb1 = Convert.ToInt32(numOne.text);
        numb2 = Convert.ToInt32(numTwo.text);
    }
    public void onChecClicedSum()
    {
        onConvertNum();
        int sum = numb1 + numb2;
        resultCal.text = $"{numb1} + {numb2} = {sum.ToString()}";
    }
    public void onChecClicedDiff()
    {
        onConvertNum();
        int diff = numb1 - numb2;
        resultCal.text = $"{numb1} - {numb2} = {diff.ToString()}";
    }
    public void onChecClicedMult()
    {
        onConvertNum();
        int mult = numb1 * numb2;
        resultCal.text = $"{numb1} * {numb2} = {mult.ToString()}";
    }
    public void onChecClicedDiv()
    {
        onConvertNum();
        double div = Convert.ToDouble(numb1) / Convert.ToDouble(numb2);
        resultCal.text = $"{numb1} / {numb2} = {div.ToString("##.##")}";
    }
}
