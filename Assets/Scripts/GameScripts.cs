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
        gameText.text = "Нас заметили и этот кто-то включил сигнализацию." +
            "Мы должны проникнуть в дом, отключить сигнализацию и поймать свидетеля! " +
            "Важно!!! Если Пин превысит 9 или будет меньше 0 - нам не сбежать!";
        GoToStart();
        pin.SetActive(false);
    }
    public void GamepersonMarv()
    {
        nameText.text = "Марв:";
        Marv.SetActive(true);
        Garry.SetActive(false);
    }
    public void GamepersonGarry()
    {
        nameText.text = "Гарри:";
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
    public void WindowClick() //кнопка окна
    {
        switch (window)
        {
            case 0:
                gameText.text = "Марв попытался пролезть через окно и угодил в ловушку. Кто-то разбросал игрушечные машинки" +
                "прям у окна, Марв подскользнулся, ударился затылком о подоконник. Дверь в комнате была закрыта и Марву пришлось выйти на улицу.";
                break;
            case 1:
                gameText.text = "Марв попробовал влезть в окно комнаты, но кто-то оставил на полу хорошо замаскированную доску с гвоздем.. Марв на улице... без ботинок";
                break;
            case 2:
                gameText.text = "Марва ничего не остановит!!! Как вы уже смогли понять, Марв не из самых умных людей";
                break;
            case 3:
                gameText.text = "Прекрати отправлять Марва на верную смерть!";
                break;
        }
        window++;
        pin1 -= 1;
        pin2 -= 2;
        pin3 -= 2;
        GoToStart();
    }
    public void BackHomeClick() //кнопка обхода дома
    {
        switch (backHome)
        {
            case 0:
                gameText.text = "Марв первый отправился вокруг дома. И попытался пройти через подвал. Лестница была скользкой, а пол был болючий.";
                break;
            case 1:
                gameText.text = "Гарри увидел запасную дверь сзади дома. Вглядываясь в дверное окошко, чтобы разглядеть ловушки, бдительность в районе паха была ослабленна" +
                    "маленький дьяволенок поджидал его с воздукой... БАХ..";
                break;
            case 2:
                gameText.text = "Слушая крики Гарри, Марв ничего не нашел лучше, чем засунуть голову в дверцу для животных... БАХ... ";
                break;
            case 3:
                gameText.text = "Побитые, разбитые, сожженые, продолжаете ходить вокруг и искать уязвимости в этой Адской цитадели.";
                break;
            case 4:
                gameText.text = "Надежда оставила это место. Взгляд потух. Времени все меньшею. Сил бороться уже нет...";
                break;
            case 5:
                gameText.text = "Соберись! Пока нас не поймали шанс всегда есть!";
                break;
            case 6:
                gameText.text = "Выбив заднюю дверь. Герои проникли в дом. На удивление ловушек не оказалось. Услышав топот ног на 2 этаже,герои бросились к лестнице. БАМ! " +
                    "Банка краски, прилетела Марву в лицо. БАМ! И Гарри досталась своя банка краски!";
                break;
        }
        backHome++;
        pin1 -= 1;
        pin2 -= 1;
        pin3 -= 1;
        GoToStart();
    }
    public void DoorClick() //Кнопка двери
    {
        switch (door)
        {
            case 0:
                gameText.text = "Гарри попытался открыть дверь за ручку. Но что это? Почему так горячо? А-А-А-А. Кто-то раскалил дверную ручку. " +
            "Теперь у Гарри на всегда остался шрам на руке в виде буквы \" М \". М-М-МАККАЛЕСТЕРЫ!!! ";
                break;
            case 1:
                gameText.text = "Со второго раза Гарри приоткрыл дверь! Остерегаясь ловушки, сначала он засунул голову. Не заметив паяльной лампы и веревки" +
                    "активирующей её, Гарри толкнул дверь плечом.. И на всю жизнь остался лысым!";
                break;
            case 2:
                gameText.text = "Чертов малец! Только попадись нам!!!";
                break;
            case 3:
                gameText.text = "Я его убью!!!";
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