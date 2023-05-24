using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role : MonoBehaviour
{
    public RoleEnum Type;
    public CampEnum Camp;
}

public enum RoleEnum
{
    Unknown,
    Merlin,
    Assassin,
    Percival,
    Morgana,
    Mordred,
    Oberon,
    LoyalServant,
    MinionOfMordred
}

public enum CampEnum
{
    Unknown,
    Red,
    Blue
}