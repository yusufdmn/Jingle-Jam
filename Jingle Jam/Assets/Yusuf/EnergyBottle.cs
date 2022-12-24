using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBottle : MonoBehaviour
{
    float maxBottleEnergy = 100;
    public float bottleEnergy;
    [SerializeField] float reduceSpeed;

    [SerializeField] SpriteRenderer bottleEnergyFill;
    float fillAmount;

    private void Start()
    {
        bottleEnergy = maxBottleEnergy;
    }
    public void ReduceBottleEnergy()
    {
        bottleEnergy -= Time.deltaTime * reduceSpeed;
        SetEnergyFill();
    }
    public void SetEnergyFill()
    {
        fillAmount = bottleEnergy / maxBottleEnergy;
        Vector2 size = bottleEnergyFill.size;
        size.x = fillAmount;
        bottleEnergyFill.size = size;
    }
}