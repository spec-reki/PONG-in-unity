using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("Ball")]
    public GameObject ball;

    [Header("Player 01")]
    public GameObject player01Paddle;
    public GameObject player01Goal;

    [Header("Player 02")]
    public GameObject player02Paddle;
    public GameObject player02Goal;

    [Header("Score UI")]
    public GameObject Player01Text;
    public GameObject Player02Text;

    private int Player01Score;
    private int Player02Score;

   


 public void Player01Scored()
    {
        Player01Score++;
       
    }

    public void Player02Scored()
    {
        Player01Score++;

    }


}
