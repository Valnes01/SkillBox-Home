using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] public InputField numComparer1;
    [SerializeField] public InputField numComparer2;
    [SerializeField] private Text resultComparer;
    int numCom1;
    int numCom2;
    private void Start()
    {

    }
    private void onConvertNum() //����� ��� ����������� �������� �����, �� ������ � �����
    {
        numCom1 = Convert.ToInt32(numComparer1.text);
        numCom2 = Convert.ToInt32(numComparer2.text);
    }
    public void readText()
    {
        onConvertNum();
        if (numCom1 > numCom2)
        {
            resultComparer.text = $"����� {numCom1} ������ {numCom2}";
        }
        else if (numCom1 < numCom2)
        {
            resultComparer.text = $"����� {numCom1} ������ {numCom2}";
        }
        else if (numCom1 == numCom2)
        {
            resultComparer.text = "����� �����";
        }
    }
}