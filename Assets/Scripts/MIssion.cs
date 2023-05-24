using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MIssion : MonoBehaviour
{
    // 参加人数
    public int NumOfParticipants;
    // クリアに必要な賛成票
    public int RequiredVotesForClear;
    // 参加者
    public List<Player> PlayerList;

    public void MIssionInitialize(int numOfParticipants, int requiredVotesForClear)
    {
        NumOfParticipants = numOfParticipants;
        RequiredVotesForClear = requiredVotesForClear;
    }
    public void MIssionStart(List<Player> players)
    {
        foreach (Player p in players) 
        {
            p.VoteAction();
        }
    }
}
