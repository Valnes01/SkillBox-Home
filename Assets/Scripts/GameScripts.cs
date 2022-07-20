using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameScripts : MonoBehaviour
{
    [SerializeField] public Text timerText; 
    [SerializeField] public Text lockNumber1;
    [SerializeField] public Text lockNumber2;
    [SerializeField] public Text lockNumber3;
    [SerializeField] public Text gameText;
    [SerializeField] public Text nameText;
    public GameObject audioDialogue;
    public GameObject audioWin;
    public GameObject audioLoss;
    public GameObject pin;
    public GameObject goGame;
    public GameObject winGame;
    public GameObject lossGame;
    public GameObject Garry;
    public GameObject Marv;
    float timer;
    int pin1;
    int pin2;
    int pin3;
    int window;
    int door;
    int backHome;
    int sum;
    bool timerOn = false;
    public void NewGame()
    {
        timer = 60.0f;
        pin1 = 9;
        pin2 = 6;
        pin3 = 5;
        window = 0;
        door = 0;
        backHome = 0;
        timerOn = true;
        gameText.text = "��� �������� � ���� ���-�� ������� ������������." +
            "�� ������ ���������� � ���, ��������� ������������ � ������� ���������! " +
            "�����!!! ���� ��� �������� 9 ��� ����� ������ 0 - ��� �� �������!";
        GoToStart();
        pin.SetActive(false);
    }
    public void GamepersonMarv()
    {
        nameText.text = "����:";
        Marv.SetActive(true);
        Garry.SetActive(false);
    }
    public void GamepersonGarry()
    {
        nameText.text = "�����:";
        Garry.SetActive(true);
        Marv.SetActive(false);
    }
    public void GoToStart()
    {
        if (pin1 == 1 && pin2 == 2 && pin3 == 3)
        {
            WinGame();
        }
        sum = window + door + backHome;
        if (pin1 <= 9 && pin1 >= 0 && pin2 <= 9 && pin2 >= 0 && pin3 <= 9 && pin3 >= 0)
        {
            lockNumber1.text = pin1.ToString();
            lockNumber2.text = pin2.ToString();
            lockNumber3.text = pin3.ToString();
            if(sum>=3)
            {
                pin.SetActive(true);
            }
        }
        else
        {
            LossGame();
        }
    }
    public void WindowClick() //������ ����
    {
        switch (window)
        {
            case 0:
                gameText.text = "���� ��������� �������� ����� ���� � ������ � �������. ���-�� ��������� ���������� �������" +
                "���� � ����, ���� ��������������, �������� �������� � ����������. ����� � ������� ���� ������� � ����� �������� ����� �� �����.";
                break;
            case 1:
                gameText.text = "���� ���������� ������ � ���� �������, �� ���-�� ������� �� ���� ������ ��������������� ����� � �������.. ���� �� �����... ��� �������";
                break;
            case 2:
                gameText.text = "����� ������ �� ���������!!! ��� �� ��� ������ ������, ���� �� �� ����� ����� �����";
                break;
            case 3:
                gameText.text = "�������� ���������� ����� �� ������ ������!";
                break;
        }
        window++;
        pin1 -= 1;
        pin2 -= 2;
        pin3 -= 2;
        GoToStart();
    }
    public void BackHomeClick() //������ ������ ����
    {
        switch (backHome)
        {
            case 0:
                gameText.text = "���� ������ ���������� ������ ����. � ��������� ������ ����� ������. �������� ���� ���������, � ��� ��� �������.";
                break;
            case 1:
                gameText.text = "����� ������ �������� ����� ����� ����. ����������� � ������� ������, ����� ���������� �������, ������������ � ������ ���� ���� ����������" +
                    "��������� ���������� �������� ��� � ��������... ���..";
                break;
            case 2:
                gameText.text = "������ ����� �����, ���� ������ �� ����� �����, ��� �������� ������ � ������ ��� ��������... ���... ";
                break;
            case 3:
                gameText.text = "�������, ��������, ��������, ����������� ������ ������ � ������ ���������� � ���� ������ ��������.";
                break;
            case 4:
                gameText.text = "������� �������� ��� �����. ������ �����. ������� ��� �������. ��� �������� ��� ���...";
                break;
            case 5:
                gameText.text = "��������! ���� ��� �� ������� ���� ������ ����!";
                break;
            case 6:
                gameText.text = "����� ������ �����. ����� �������� � ���. �� ��������� ������� �� ���������. ������� ����� ��� �� 2 �����,����� ��������� � ��������. ���! " +
                    "����� ������, ��������� ����� � ����. ���! � ����� ��������� ���� ����� ������!";
                break;
        }
        backHome++;
        pin1 -= 1;
        pin2 -= 1;
        pin3 -= 1;
        GoToStart();
    }
    public void DoorClick() //������ �����
    {
        switch (door)
        {
            case 0:
                gameText.text = "����� ��������� ������� ����� �� �����. �� ��� ���? ������ ��� ������? �-�-�-�. ���-�� �������� ������� �����. " +
            "������ � ����� �� ������ ������� ���� �� ���� � ���� ����� \" � \". �-�-������������!!! ";
                break;
            case 1:
                gameText.text = "�� ������� ���� ����� ��������� �����! ����������� �������, ������� �� ������� ������. �� ������� �������� ����� � �������" +
                    "������������ �, ����� ������� ����� ������.. � �� ��� ����� ������� �����!";
                break;
            case 2:
                gameText.text = "������ �����! ������ �������� ���!!!";
                break;
            case 3:
                gameText.text = "� ��� ����!!!";
                break;
        }
        door++;
        pin1 -= 2;
        pin2 += 1;
        pin3 += 2;
        GoToStart();
    }
    void LossGame()
    {
        goGame.SetActive(false);
        lossGame.SetActive(true);
        timerOn = false;
        audioLoss.SetActive(true);
        audioDialogue.SetActive(false);
    }
    void WinGame()
    {
        goGame.SetActive(false);
        winGame.SetActive(true);
        timerOn = false;
        audioWin.SetActive(true);
        audioDialogue.SetActive(false);
    }
    void Update()
    {
        if (timerOn)
        {
            timer -= Time.deltaTime;
            if (timer > 0 && timer <= 60)
            {
                timerText.text = Mathf.Round(timer).ToString();
            }
            else
            {
                LossGame();
            }
        }
    }
}