using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardHolderManager : MonoBehaviour
{
    [Header("Card Holder Parameters")]
    [SerializeField] private Transform _cardHolderPosition;
    [SerializeField] private GameObject _card;
    [SerializeField] private Card[] _cardSO;
    private int _cardsAmmount;
    public GameObject resourseCounter;

    [Header("Card Parameters")]
    [SerializeField] private GameObject[] _plantedCards;
    private int _cost;
    private Sprite _icon;

    void Start()
    {
        _cardsAmmount = _cardSO.Length;
        _plantedCards = new GameObject[_cardsAmmount];

        for (int i = 0; i < _cardsAmmount; i++)
            CreateCard(i);
    }

    private void CreateCard(int i)
    {
        var card = Instantiate(_card, _cardHolderPosition);
        CardManager cardManager = card.GetComponent<CardManager>();

        cardManager.CardSO = _cardSO[i];

        _plantedCards[i] = card;

        _icon = _cardSO[i].icon;
        _cost = _cardSO[i].cost;

        card.transform.GetChild(0).GetComponent<Image>().sprite = _icon;
        card.GetComponentInChildren<Text>().text = _cost.ToString();
        card.GetComponent<CardManager>().resourseCounter = resourseCounter; 
    }
}

