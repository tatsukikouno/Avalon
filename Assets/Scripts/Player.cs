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
            // パーシヴァルはマーリンを見分けられる
            // ただし、モルガナもマーリンに見える
            if (Role.Type == RoleEnum.Merlin || Role.Type == RoleEnum.Morgana ) return RoleEnum.Merlin;
        }
        return RoleEnum.Unknown;
    }
    public CampEnum GetRoleCamp(Player listener)
    {
        var listenerRole = listener.Role.Type;
        if (listenerRole == RoleEnum.Merlin)
        {
            // マーリンはモードレッドとオベロンを見分けられない
            if (Role.Type == RoleEnum.Mordred || Role.Type == RoleEnum.Oberon) return CampEnum.Unknown;
            // マーリンは赤陣営を見分けられる
            if (Role.Camp == CampEnum.Red) return Role.Camp;
        }
        else if (listenerRole == RoleEnum.Percival)
        {
            // パーシヴァルはマーリンを見分けられる
            // ただし、モルガナもマーリンに見える
            if (Role.Type == RoleEnum.Merlin || Role.Type == RoleEnum.Morgana) return CampEnum.Blue;
        }
        return CampEnum.Unknown;
    }

    public void VoteAction()
    {
        // プレイヤーの投票処理を実装する
    }

    public void SelectTeam(List<int> team)
    {
        // チームの選択処理を実装する
    }

    public void DoMission(bool missionResult)
    {
        // ミッションの実行処理を実装する
    }
}
