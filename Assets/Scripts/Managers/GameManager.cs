using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState currentState;
    // Start is called before the first frame update
    void Awake()
    {
        
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsGamePlay(){
        return currentState == GameState.Gameplay;
    }

    public void ChangeGameState(GameState newState){

        currentState = newState;
    }
}
