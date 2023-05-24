using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Id;
    public string Name;
    public Role Role;

    public RoleEnum GetRoleType(Player listener)
    {
        var listenerRole = listener.Role.Type;
        if (listenerRole == RoleEnum.Percival)
        {
            // �p�[�V���@���̓}�[����������������
            // �������A�����K�i���}�[�����Ɍ�����
            if (Role.Type == RoleEnum.Merlin || Role.Type == RoleEnum.Morgana ) return RoleEnum.Merlin;
        }
        return RoleEnum.Unknown;
    }
    public CampEnum GetRoleCamp(Player listener)
    {
        var listenerRole = listener.Role.Type;
        if (listenerRole == RoleEnum.Merlin)
        {
            // �}�[�����̓��[�h���b�h�ƃI�x���������������Ȃ�
            if (Role.Type == RoleEnum.Mordred || Role.Type == RoleEnum.Oberon) return CampEnum.Unknown;
            // �}�[�����͐Ԑw�c������������
            if (Role.Camp == CampEnum.Red) return Role.Camp;
        }
        else if (listenerRole == RoleEnum.Percival)
        {
            // �p�[�V���@���̓}�[����������������
            // �������A�����K�i���}�[�����Ɍ�����
            if (Role.Type == RoleEnum.Merlin || Role.Type == RoleEnum.Morgana) return CampEnum.Blue;
        }
        return CampEnum.Unknown;
    }

    public void VoteAction()
    {
        // �v���C���[�̓��[��������������
    }

    public void SelectTeam(List<int> team)
    {
        // �`�[���̑I����������������
    }

    public void DoMission(bool missionResult)
    {
        // �~�b�V�����̎��s��������������
    }
}
