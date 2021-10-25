
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    public enum GameState
    {
        PREPARATION,
        RUNNING,
        END
    }

    private GameState gameState { get; set; } = GameState.PREPARATION;

    private float gameTimer { get; set; } = 0;

    public float _preparationTime  = 0;

    private float preparationTime { get { return _preparationTime; } }


    private void Awake()
    {
        instance = this;




    }

    private void Start()
    {
        gameTimer = preparationTime;
    }


    private void Update()
    {
        switch (gameState)
        {
            case GameState.PREPARATION:
                gameTimer -= Time.deltaTime;
                UIMANAGER.instance.SetTimer(gameTimer);
                if(gameTimer < 0)
                {
                    gameTimer = preparationTime;
                    gameState = GameState.RUNNING;
                }

                break;

            case GameState.RUNNING:

                break;

            case GameState.END:

                break;
        }
    }
}
