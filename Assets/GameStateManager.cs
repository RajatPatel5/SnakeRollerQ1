//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System;

//public enum State
//{
//    Splash,
//    MainMenu,
//    Gameplay,
//    GameOver
//}
//public class GameStateManager : MonoBehaviour
//{
//    public GameStateManager inst;
//    public Action<State> StateChange;
//    //public delegate void statedelegate();
//    //public statedelegate statedelegatefun;
//    //public List<State> statelist;

//    private void Awake()
//    {
//        inst = this;
//    }
//    public State currentState;

//    public void OnGameStateChange(State states)
//    {
//        currentState = states;
//        StateChange?.Invoke(currentState);
//    }


//}

