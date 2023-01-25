using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "animalAttribute", menuName = "SO/animalAttribute", order = 0)]
public class AnimalAttributeSO : ScriptableObject
{
    public string areaName; //지역 이름
    public string animalName; //동물 이름
    public Sprite gImage; //구역 사진
    public int priceGValue; //구역 가격
    public Sprite animal1; //동물 1 사진
    public int priceA1Value; //동물 1 가격
    public Sprite animal2; //동물 2 사진
    public int priceA2Value; //동물 2 가격
    public Sprite animal3; //동물 3 사진
    public int priceA3Value; //동물 3 가격
    public int animalL = 0;
}
