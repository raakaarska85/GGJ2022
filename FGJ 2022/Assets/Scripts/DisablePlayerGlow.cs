using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePlayerGlow : MonoBehaviour
{
    public float minDistance;
    float distance;
    public Transform player1;
    public Transform player2;

    public GameObject player1Glow;
    public GameObject player2Glow;
    GameManager gameManager;
    // Start is called before the first frame update

    void Start()
    {
        gameManager = this.gameObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player1.position, player2.position);
        if (distance < minDistance && gameManager.playerDown == null)
        {
            player1Glow.SetActive(false);
            player2Glow.SetActive(false);
        }
        if (distance >= minDistance && gameManager.playerDown == null)
        {
            player1Glow.SetActive(true);
            player2Glow.SetActive(true);
        }

        if (!player1.gameObject.active)
        {
            player1Glow.SetActive(false);
        }
        if (!player2.gameObject.active)
        {
            player2Glow.SetActive(false);
        }
    }
}
