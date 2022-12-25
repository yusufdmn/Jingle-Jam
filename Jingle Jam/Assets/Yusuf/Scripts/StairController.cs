using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StairController : MonoBehaviour
{
    Vector2 downstairsPosition;
    Vector2 upstairsPosition;

    [SerializeField] Transform downstairs;
    [SerializeField] Transform upstairs;

    [SerializeField] Transform player;

    [SerializeField] float speed;
    floor currentFloor;

    enum floor
    {
        downstairs = 0,
        upstairs = 1
    }

    private void Start()
    {
        downstairsPosition = downstairs.position;
        upstairsPosition = upstairs.position;
    }

    private void MoveToUpstairs()
    {
        player.DOMove(downstairsPosition, speed * Time.deltaTime).OnComplete(() =>
        {
            currentFloor = floor.upstairs;
            player.DOMove(upstairsPosition, speed * Time.deltaTime);
        }); 
    }
    private void MoveToDownstairs()
    {
        player.DOMove(upstairsPosition, speed * Time.deltaTime).OnComplete(() => 
        {
            currentFloor = floor.downstairs;
            player.DOMove(downstairsPosition, speed * Time.deltaTime);
        });
        
    }

    public void ChangeFloor()
    {
        if (currentFloor == floor.upstairs)
            MoveToDownstairs();
        else
            MoveToUpstairs();
    }

}
