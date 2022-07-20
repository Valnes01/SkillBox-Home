using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    [SerializeField] public Text garryText;
    [SerializeField] public Text marvText;
    public GameObject startGame;


    private int numGarryText=0;
    private string garry = "����! ��� ��.. ��� - ������� � ������ �� ���, � �� � ���!";
    private int numMarvText=0;
    private string marv = "�����, � ��� ���� ��������?";

    public void ClickMarvDialogue() //����� ������� �����
    {
        if (numMarvText<=10)
        {
            if (numGarryText >= 3 && numMarvText >= 3)
            {
                startGame.SetActive(true);
            }
            switch (numMarvText)
            {
                case 0:
                    marvText.text = "����� ���������?";
                    break;
                case 1:
                    marvText.text = "�. �����. �������.";
                    break;
                case 2:
                    marvText.text = "��� � ���� �� ���.";
                    break;
                case 3:
                    marvText.text = "����� �� ��������, ����� ������?";
                    break;
                case 4:
                    marvText.text = "�? ���, ����� �� ������� ������.";
                    break;
                case 5:
                    marvText.text = "� �� ������.";
                    break;
                case 6:
                    marvText.text = "� ���� ���� �������.. ������, �������, ������!";
                    break;
                case 7:
                    marvText.text = "�������!";
                    break;
                case 8:
                    marvText.text = "���... ��� ... ���!";
                    break;
                case 9:
                    marvText.text = "����������!";
                    break;
                case 10:
                    marvText.text = "� � ���� � ����� ����!";
                    break;
            }
        }
        else
        {
            numMarvText =3;
            marvText.text = "����� �� ��������, ����� ������?";
        }
        numMarvText++;
    }

    public void ClickGarryDialogue() //����� ������� �����
    {
        if (numGarryText <= 10)
        {
            switch (numGarryText)
            {
                case 0:
                    garryText.text = "�����! ��� ���� ������� ������ ��� ��������..!";
                    break;
                case 1:
                    garryText.text = "���������, ������, ����� ��������������� � ���� �������.";
                    break;
                case 2:
                    garryText.text = "��� �� �� �����, ������?";
                    break;
                case 3:
                    garryText.text = "�� �������, �������� ����������, ������ ����� ������� �����, ���� ������ ���!";
                    break;
                case 4:
                    garryText.text = "���� �� �� �����???";
                    break;
                case 5:
                    garryText.text = "��� � ����� ���� �� ����� ��������?";
                    break;
                case 6:
                    garryText.text = "����� ������ �������?";
                    break;
                case 7:
                    garryText.text = "������!";
                    break;
                case 8:
                    garryText.text = "������!";
                    break;
                case 9:
                    garryText.text = "�������!";
                    break;
                case 10:
                    garryText.text = "����� ��� ����������? � ���� ���� ��� ������ �����������!";
                    break;
            }
        }
        else
        {
            numGarryText = 3;
            garryText.text = "�� �������, �������� ����������, ������ ����� ������� �����, ���� ������ ���!";
        }
        numGarryText++;
    }

    public void ClickNewGame() //���������� ����
    {
        garryText.text = garry;
        marvText.text = marv;
        numGarryText = 0;
        numMarvText = 0;
        startGame.SetActive(false);
    }
}