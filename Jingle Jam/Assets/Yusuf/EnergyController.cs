using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyController : MonoBehaviour
{
    [SerializeField] float maxEnergy;
    [SerializeField] float energy;
    [SerializeField] float reduceSpeed;

    private void Update()
    {
        ReduceEnergy();
    }

    public void ReduceEnergy()
    {
        energy -= reduceSpeed * Time.deltaTime;
    }

    public void IncreaseEnergy(float additionalEnergy)
    {
        energy += reduceSpeed;
    }


}
