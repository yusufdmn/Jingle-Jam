using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPositionController : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform[] houses;

    Vector2[] housesXPositions;
    int exitedHouse;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        houses = new Transform[3]; 
        housesXPositions = new Vector2[3];

        exitedHouse = PlayerPrefs.GetInt("houseNo", 1);
        SetHousePositions();
        MoveToStartPosition();
    }

    private void MoveToStartPosition()
    {
        Vector2 startPosition = player.position;
        startPosition.x = housesXPositions[exitedHouse - 1].x + 3;  // 3 + exited house position
        player.position = startPosition;
    }

    private void SetHousePositions()
    {
        houses[0] = GameObject.FindGameObjectWithTag("House1").transform;
        houses[1] = GameObject.FindGameObjectWithTag("House2").transform;
        houses[2] = GameObject.FindGameObjectWithTag("House3").transform;

        for (int i = 0; i < houses.Length; i++)
        {
            housesXPositions[i] = houses[i].position;
        }
    }
}
