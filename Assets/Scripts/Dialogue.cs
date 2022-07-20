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
    private string garry = "Марв! Вот он.. Дом - путевка в отпуск на год, а то и два!";
    private int numMarvText=0;
    private string marv = "Гарри, а там есть сладости?";

    public void ClickMarvDialogue() //смена диалога Марва
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
                    marvText.text = "Много сладостей?";
                    break;
                case 1:
                    marvText.text = "Я. Люблю. Игрушки.";
                    break;
                case 2:
                    marvText.text = "Тот у кого их нет.";
                    break;
                case 3:
                    marvText.text = "Может по старинке, через подвал?";
                    break;
                case 4:
                    marvText.text = "Я? Жду, когда ты пойдешь вперед.";
                    break;
                case 5:
                    marvText.text = "Я не против.";
                    break;
                case 6:
                    marvText.text = "У меня идея получше.. Камень, ножницы, бумага!";
                    break;
                case 7:
                    marvText.text = "Ножницы!";
                    break;
                case 8:
                    marvText.text = "Раз... Два ... Три!";
                    break;
                case 9:
                    marvText.text = "Монтировка!";
                    break;
                case 10:
                    marvText.text = "А у меня в руках есть!";
                    break;
            }
        }
        else
        {
            numMarvText =3;
            marvText.text = "Может по старинке, через подвал?";
        }
        numMarvText++;
    }

    public void ClickGarryDialogue() //смена диалога Гарри
    {
        if (numGarryText <= 10)
        {
            switch (numGarryText)
            {
                case 0:
                    garryText.text = "Идиот! Там есть намного больше чем сладости..!";
                    break;
                case 1:
                    garryText.text = "Украшения, золото, новый видеомагнитофон и куча игрушек.";
                    break;
                case 2:
                    garryText.text = "Кто их не любит, болван?";
                    break;
                case 3:
                    garryText.text = "Не умничай, доставай мантировку, пойдем через главную дверь, дома никого нет!";
                    break;
                case 4:
                    garryText.text = "Чего же ты ждешь???";
                    break;
                case 5:
                    garryText.text = "Так и будем друг на друга смотреть?";
                    break;
                case 6:
                    garryText.text = "Давай бросим монетку?";
                    break;
                case 7:
                    garryText.text = "Камень!";
                    break;
                case 8:
                    garryText.text = "Бумага!";
                    break;
                case 9:
                    garryText.text = "Ножницы!";
                    break;
                case 10:
                    garryText.text = "Какая еще монтировка? В этой игре нет такого инструмента!";
                    break;
            }
        }
        else
        {
            numGarryText = 3;
            garryText.text = "Не умничай, доставай мантировку, пойдем через главную дверь, дома никого нет!";
        }
        numGarryText++;
    }

    public void ClickNewGame() //перезапуск игры
    {
        garryText.text = garry;
        marvText.text = marv;
        numGarryText = 0;
        numMarvText = 0;
        startGame.SetActive(false);
    }
}