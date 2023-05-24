using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MIssion : MonoBehaviour
{
    // �Q���l��
    public int NumOfParticipants;
    // �N���A�ɕK�v�Ȏ^���[
    public int RequiredVotesForClear;
    // �Q����
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
