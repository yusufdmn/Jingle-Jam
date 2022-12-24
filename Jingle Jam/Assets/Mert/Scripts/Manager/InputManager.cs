using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private Camera mainCam;
    [SerializeField] private float maxDistanceToCollectable;
    [SerializeField] private float maxDistanceToEnergyBottle;

    [SerializeField] EnergyController energyController;
    void Update()
    {
        
        // Movement
        float xAxis = Input.GetAxis("Horizontal");
        xAxis *= Time.deltaTime;
        if (xAxis != 0)
        {
            playerController.MovePlayer(xAxis);
            playerController.ArrangeRotation(xAxis);
        }
        // Interact
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(mainCam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            
            // collectable
            if (hit.collider != null && hit.collider.CompareTag("Collectable"))
            {
                float distance = playerController.GetPlayerDistanceToObject(hit.collider.gameObject);
                if (distance < maxDistanceToCollectable)
                {
                    Destroy(hit.collider.gameObject);
                }
            }
            // emergy bottle
            if (hit.collider != null && hit.collider.CompareTag("EnergyBottle"))
            {
                float distance = playerController.GetPlayerDistanceToObject(hit.collider.gameObject);
                if (distance < maxDistanceToEnergyBottle)
                {
                    //Destroy(hit.collider.gameObject);
                    hit.collider.GetComponent<EnergyBottle>().ReduceBottleEnergy();
                    energyController.IncreaseEnergy();
                }
            }            
        }
    }
}
