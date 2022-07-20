using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class NewHistory : MonoBehaviour
{
    [SerializeField] public Text historyText;
    [SerializeField] public GameObject TitleCanvas;
    [SerializeField] public GameObject ClickToDispleyText;
    [SerializeField] public GameObject PrehistoryCanvas;
    [SerializeField] public GameObject ClickToDispleyHistoryText;
    [SerializeField] public GameObject StopHistoryButton;
    public GameObject audioTitle;
    private double count = 0.0;
    private string history;
    private float timer = 0.0f;
    private float timer2 = 0.0f;
    private float interval = 2.0f;
    private bool stopHistory = false;
    private bool clickToDisplay = true;
    public void Start()
    {
        audioTitle.SetActive(true);
    }
    public void OnClickHistory() //������� � �������� ������ �� ����� �������
    {
        History();
        Update();
        clickToDisplay = false;
        stopHistory = true;
    }
    public void OnClickStopHistory() //���������� �������� ������
    {
        stopHistory = false;
    }
    void Update()
    {
        if (clickToDisplay) //������ 2 ������� ������� ������� ������ �� �����, ������� �����
        {
            timer += Time.deltaTime;
            if (timer >= interval)
            {
                ClickToDispleyText.SetActive(true);
            }
        }
        else if (clickToDisplay == false) //������ 2 ������� ������� ������� ������ �� �����, ����� �������
        {
            timer2 += Time.deltaTime;
            if (timer2 >= interval)
            {
                ClickToDispleyHistoryText.SetActive(true);
            }
        }
        if (stopHistory) //���������� ���������� ����� ������
        {
            if (count < 750)
            {
                historyText.text = history.Substring(0, Convert.ToInt32(count));
                count += 0.5;
            }
            else
            {
                StopHistoryButton.SetActive(false);
            }
        }
        else if (stopHistory == false) //��� ������� ����� ������� ���������
        {
            historyText.text = history;
        }
    }
    void History() //����� ������
    {
       history = "������� �����! " +
            "\n \t���� ����� ����� ����, � ����� ����� ����� ����, � �� ����� ����� ���������. ���� � ��������� ��������� ��� ���� �����." +
            "�� �������� �������, �������������, ������� � ��������.���� ����� ����� ��������. " +
            "\n \t� ��� ���������, �� ������, ����� ����� ���� ������� ������� �������, � ��� �������� �������� ����� ������ � �������. � ��, ������ � ��� � ����� � �������� ���� �������!" +
            "\n \t�� ����� ���� ����� ����� �����, � ����� ��� �� ������ ��������. ������� ����� ���� ��� �� ���������� ����� �����. ��� �������������, ����� ������� �� ������� � ��������." +
            "���������, ���� ����� ����� ��������. ������� ���, � ����� �� �����, �� ����������  ���������." +
            "\n \t�� \"������ �������\" � �� ��������� ����� ���������!!!";
    }
}