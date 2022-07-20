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
    public void OnClickHistory() //переход с главного экрана на экран истории
    {
        History();
        Update();
        clickToDisplay = false;
        stopHistory = true;
    }
    public void OnClickStopHistory() //мгновенное открытие письма
    {
        stopHistory = false;
    }
    void Update()
    {
        if (clickToDisplay) //спустя 2 секунды выходит надпись нажать на экран, главный экран
        {
            timer += Time.deltaTime;
            if (timer >= interval)
            {
                ClickToDispleyText.SetActive(true);
            }
        }
        else if (clickToDisplay == false) //спустя 2 секунды выходит надпись нажать на экран, экран истории
        {
            timer2 += Time.deltaTime;
            if (timer2 >= interval)
            {
                ClickToDispleyHistoryText.SetActive(true);
            }
        }
        if (stopHistory) //постепенно печатающий текст письма
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
        else if (stopHistory == false) //при нажатии текст выходит полностью
        {
            historyText.text = history;
        }
    }
    void History() //текст письма
    {
       history = "Дорогой Санта! " +
            "\n \tМеня зовут Гарри Лайм, а моего друга зовут Марв, и мы очень любим Рождество. Ведь в Рождество сбываются все наши мечты." +
            "Мы получаем технику, драгоценности, игрушки и сладости.Марв очень любит сладости. " +
            "\n \tВ это Рождество, мы желаем, чтобы планы всех жителей Милуоки сбылись, и они полетели навещать своих родных и близких. А мы, придем к ним в гости и исполним свои желания!" +
            "\n \tМы будем себя очень плохо вести, и никто нам не сможет помешать. Остался всего один дом до исполнения нашей мечты. Дом Маккалистеров, самый богатый на подарки и сладости." +
            "Повторюсь, Марв очень любит сладости. Ограбим его, и уйдем на покой, до следующего  Рождества." +
            "\n \tМы \"Мокрые бандиты\" и мы чертовски любим рождество!!!";
    }
}