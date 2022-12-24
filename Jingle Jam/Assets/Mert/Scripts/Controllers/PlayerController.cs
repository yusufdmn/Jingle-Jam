using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Player player;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void MovePlayer(float rotation)
    {
        player.transform.Translate(new Vector3(player.speed * rotation, player.transform.position.y,
            player.transform.position.z));
    }

    public void ArrangeRotation(float rotation)
    {
        if (rotation<0)
        {
            if (!player.isLookingLeft)
            {
                player.GetComponent<SpriteRenderer>().flipX = true;
                player.isLookingLeft = true;
            }
        }

        if (rotation >0)
        {
            if (player.isLookingLeft)
            {
                player.GetComponent<SpriteRenderer>().flipX = false;
                player.isLookingLeft = false;
            }
        }
    }
}
