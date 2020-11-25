using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public interface IGameController
{
    List<Brick> bricks { get; set; }
    List<Paddle> paddles { get; set; }
    int numberOfPaddlesLeft { get; set; }
    int numberOfBricks { get; set; }
    Account account { get; set; }
    void Awake();
    void CreatePaddleList();
    void LoosePaddle();
    void SpawnNewPaddle();
    void Update();
}

public class GameController : MonoBehaviour, IGameController
{
    public List<Brick> bricks { get; set; }
    public List<Paddle> paddles { get; set; }
    public int numberOfPaddlesLeft { get; set; }
    public int numberOfBricks { get; set; }
    [SerializeField]
    private GameObject paddlePrefab;
    public Account account { get; set; }
    [SerializeField]
    private Text balanceText;
    [SerializeField]
    private Text paddlesText;
    public void Awake()
    {
        account = new Account();
        account.AddFunds(PlayerPrefs.GetInt("Account Balance"));
        Cursor.visible = false;

        numberOfPaddlesLeft = 5;

        bricks = new List<Brick>();
        paddles = new List<Paddle>();

        CreatePaddleList();
        SpawnNewPaddle();
    }

    public void Update()
    {
        balanceText.text = account.Balance.ToString() + "€";
        paddlesText.text = numberOfPaddlesLeft.ToString();
    }
    public void SpawnNewPaddle()
    {
        GameObject firstPaddle = Instantiate(paddlePrefab, paddles[numberOfPaddlesLeft - 1].Position, Quaternion.identity, transform);
        firstPaddle.GetComponent<SpriteRenderer>().color = paddles[numberOfPaddlesLeft - 1].Color;
    }
    public void CreatePaddleList()
    {
        for (int i = 0; i < numberOfPaddlesLeft; i++)
        {
            Paddle paddle = new Paddle();
            paddles.Add(paddle);

            if (i == numberOfPaddlesLeft - 1)
            {
                paddle.IsActive = true;
            }
        }
    }
    public void LoosePaddle()
    {
        paddles.RemoveAt(paddles.Count - 1);
        numberOfPaddlesLeft--;
    }
}
