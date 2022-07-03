using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer01Goal;

    private void OnTriggerEnter2D(Collider2D other) {
        if ("l")
        {
            if (!isPlayer01Goal)
            {
                Debug.Log("Player 1 Scored");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player01Scored();
            }
            else
            {
                Debug.Log("Player 2 Scored");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player02Scored();
            }
        }
    }
}
