using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // �v���C���[�̃��X�g
    private List<Player> players = new List<Player>();
    // �v���C���[�̃��X�g
    private int playersCount = 0;

    private void Start()
    {
        StartGame();
    }
    
    // �Q�[���J�n
    private void StartGame()
    {
    }

    public void AddPlayer()
    {
    }

    // �~�b�V�����J�n
    private void StartMission()
    {
    }
    
    // ���[
    private void Vote(bool vote)
    {
    }
    
    // �`�[���̑I����������������
    private void SelectTeamMember(List<int> team)
    {
    }
    
    // �~�b�V����
    private void Mission(List<int> missionTeam, List<bool> missionResults)
    {
    }
    
    // �Q�[���I��
    private void EndGame()
    {
    }
    
    // �A�T�V���̐��̂����J���鏈������������
    private void RevealAssassin(int guess)
    {
    }
}