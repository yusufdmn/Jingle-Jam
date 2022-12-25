using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Player player;
    
    public void MovePlayer(float rotation)
    {
        player.transform.Translate(new Vector3(player.speed * rotation, 0, 0));
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

    public float GetPlayerDistanceToObject(GameObject targetObject)
    {
        return Mathf.Abs(player.transform.position.x - targetObject.transform.position.x);
    }
}
