using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // プレイヤーのリスト
    private List<Player> players = new List<Player>();
    // プレイヤーのリスト
    private int playersCount = 0;

    private void Start()
    {
        StartGame();
    }
    
    // ゲーム開始
    private void StartGame()
    {
    }

    public void AddPlayer()
    {
    }

    // ミッション開始
    private void StartMission()
    {
    }
    
    // 投票
    private void Vote(bool vote)
    {
    }
    
    // チームの選択処理を実装する
    private void SelectTeamMember(List<int> team)
    {
    }
    
    // ミッション
    private void Mission(List<int> missionTeam, List<bool> missionResults)
    {
    }
    
    // ゲーム終了
    private void EndGame()
    {
    }
    
    // アサシンの正体を公開する処理を実装する
    private void RevealAssassin(int guess)
    {
    }
}