using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyController : MonoBehaviour
{
    [SerializeField] float maxEnergy;
    [SerializeField] float energy;
    [SerializeField] float reduceEnergySpeed;
    [SerializeField] float increaseEnergySpeed;

    [SerializeField] SpriteRenderer energyFill;
    float fillAmount;

    public bool hasPlayerEnergyFinished;

    private void Start()
    {
        energy = maxEnergy;
    }

    private void Update()
    {
        ReduceEnergy();
        SetEnergyFill();
        CheckAndLimitEnergy();
    }

    public void ReduceEnergy()
    {
        if(hasPlayerEnergyFinished == false)
            energy -= reduceEnergySpeed * Time.deltaTime;
    }

    public void IncreaseEnergy()
    {
        energy += increaseEnergySpeed * Time.deltaTime;
    }
    
    public void SetEnergyFill()
    {
        fillAmount = energy / maxEnergy;
        Vector2 size = energyFill.size;
        size.x = fillAmount;
        energyFill.size = size;
    }

    public void CheckAndLimitEnergy()
    {
        if(energy <= 0)
        {
            hasPlayerEnergyFinished = true;
        }
        else if(energy >= maxEnergy)
        {
            energy = maxEnergy;
        }
    }

}
