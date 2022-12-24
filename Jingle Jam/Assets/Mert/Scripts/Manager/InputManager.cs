using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private Camera mainCam;
    
    
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
                Destroy(hit.collider.gameObject);
            }
            // emergy bottle
            if (hit.collider != null && hit.collider.CompareTag("EnergyBottle"))
            {
                Destroy(hit.collider.gameObject);
            }            
        }
    }
}
