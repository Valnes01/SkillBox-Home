using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class Home5 : MonoBehaviour
{
    void Start()
    {

    }

    public void SumEvenNums() //1
    {
        int sum = 0;
        int min = 7;
        int max = 21;
        for (; min < max+1; min++)
        {
            if (min % 2 == 0)
                sum += min;
            else
                continue;
        }
        Debug.Log($"����� ������ ����� � ��������� �� 7 �� 21 ������������ ����� {sum}");
    } 

    public void SumArrNums() //2
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int sumArray=0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sumArray += array[i];
            }
        }
        Debug.Log($"����� ������ ����� � �������� �������  (81, 22, 13, 54, 10, 34, 15, 26, 71, 68) ����� {sumArray}");
    }

    public void OnFirstOccurrence() //3
    {
        int[] array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int num1 = 343;
        int num2 = 55;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num1)
            {
                Debug.Log($"������ ������� ��������� ����� {num1} � ������  (81, 22, 13, 34, 10, 34, 15, 26, 71, 68) ����� {i}");
                break;
            }
            else if (i == array.Length-1 && array[i] != num1)
            {
                Debug.Log($"������ ������� ��������� ����� {num1} � ������  (81, 22, 13, 34, 10, 34, 15, 26, 71, 68) ����� -1 ");
                break;
            }
        }
        for (int j = 0; j< array.Length; j++)
        {
            if (array[j] == num2)
            {
                Debug.Log($"������ ������� ��������� ����� {num2} � ������  (81, 22, 13, 34, 10, 34, 15, 26, 71, 68) ����� {j}");
                break;
            }
            else if ((j == array.Length-1) && (array[j] != num2))
            {
                Debug.Log($"������ ������� ��������� ����� {num2} � ������  (81, 22, 13, 34, 10, 34, 15, 26, 71, 68) ����� -1 ");
                break;
            }
        }
    }

    public void OnSelectionSort() //4
    {
        int temp;
        int [] arrey = new int [10];
        Random rnd = new Random();
        Debug.Log("�������� ������");
        for (int i = 0; i < arrey.Length; i++)
        {
            arrey[i] = rnd.Next(-10, 11);
            Debug.Log($"{arrey[i]}");
        }
        Debug.Log("��������� ����������");
        for (int i = 0; i < arrey.Length; i++)
        {
            for (int j = 0; j < arrey.Length-i-1; j++)
            {
                if (arrey[j] > arrey[j + 1])
                {
                    temp = arrey[j];
                    arrey[j] = arrey[j + 1];
                    arrey[j + 1] = temp;
                }
            }
        }
        foreach(int num in arrey)
        {
            Debug.Log($"{num}");
        }
    }
}