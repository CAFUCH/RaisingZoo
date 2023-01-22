using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "animalAttribute", menuName = "SO/animalAttribute", order = 0)]
public class AnimalAttributeSO : ScriptableObject
{
    public string areaName;
    public string animalName;
    public int priceValue;
    public Sprite gImage;
    public Sprite animal1;
    public Sprite animal2;
    public Sprite animal3;
}
