using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public enum GameState
	{
        Start,
        Playing,
        Won,
        LostALife,
        LostAllLives
	}
    public static int lives = 3;
    public static int score = 0;
    public static int blocksLeft = 20;
    public static GameState CurrentGameState = GameState.Start;
    public static BallScript Ball;
    private GameObject[] blocks;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
