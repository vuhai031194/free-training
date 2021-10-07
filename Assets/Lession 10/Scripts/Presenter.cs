using System;
using System.Collections;
using TigerForge;
using UnityEngine;
using Random = UnityEngine.Random;

public class Presenter : MonoBehaviour
{
    private int playerIndex;
    private GameObject prefabPlayer;
    private GameObject player;

    private const string PLAYER_KEY = "KEY";
    private void Awake()
    {
        if (PlayerPrefs.HasKey(PLAYER_KEY) == false)
        {
            RandomPlayer();
        }
        else
        {
            playerIndex = PlayerPrefs.GetInt(PLAYER_KEY);
        }
    }

    private IEnumerator Start()
    {

        var request = Resources.LoadAsync<GameObject>($"Prefabs/player_{playerIndex}");

       while (!request.isDone)
       {
           yield return null;
       }

       prefabPlayer = (GameObject) request.asset;
       
       SetPlayer();
       SetPlayerState(true);
    }

    private void RandomPlayer()
    {
        playerIndex = Random.Range(1, 3);
        PlayerPrefs.SetInt(PLAYER_KEY, playerIndex);
    }

    private void OnEnable()
    {
        EventManager.StartListening(EventName.TRIGGER_PRESENTER, OnTrigger);
    }

    private void OnDisable()
    {
        EventManager.StopListening(EventName.TRIGGER_PRESENTER, OnTrigger);
    }

    private void OnTrigger()
    {
        var isActive = EventManager.GetBool(EventName.TRIGGER_PRESENTER);
        
        SetPlayerState(isActive);
    }

    private void SetPlayer()
    {
        // if (playerIndex >= playerList.Length)
        // {
        //     throw new Exception("Out of list");
        // }
        //
        // player = playerList[playerIndex];

        player = GameObject.Instantiate(prefabPlayer, transform);
        player.transform.localPosition = Vector3.zero;

    }
    
    public void SetPlayerState(bool isActive)
    {
        player.gameObject.SetActive(isActive);
    }

}
