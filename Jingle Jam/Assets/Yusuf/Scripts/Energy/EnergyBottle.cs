using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBottle : MonoBehaviour
{
    float maxBottleEnergy = 100;
    public float bottleEnergy;
    [SerializeField] private float reduceSpeed;

    [SerializeField] SpriteRenderer bottleEnergyFill;
    float fillAmount;
    private bool hasBottleFinished;

    private void Start()
    {
        bottleEnergy = maxBottleEnergy;
    }
    public void ReduceBottleEnergy()
    {
        if (hasBottleFinished == false)
        {
            bottleEnergy -= Time.deltaTime * reduceSpeed;
            SetEnergyFill();
            CheckEnergyLimit();
        }
    }
    public void SetEnergyFill()
    {
        fillAmount = bottleEnergy / maxBottleEnergy;
        Vector2 size = bottleEnergyFill.size;
        size.x = fillAmount;
        bottleEnergyFill.size = size;
    }

    public void CheckEnergyLimit()
    {
        if (bottleEnergy <= 0)
            hasBottleFinished = true;
    }

}