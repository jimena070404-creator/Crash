using UnityEngine;

[CreateAssetMenu(fileName = "PlayerAnimationConfiguration", menuName = "Scriptable Objects/PlayerAnimationConfiguration")]
public class PlayerAnimationConfiguration : ScriptableObject
{
    public string idleAnimationName ="idle;";
    public string runAnimationName = "run";
    public string jumpAnimationName = "jump";
    public string fallAnimationName = "fall";
    public string landAnimationName = "land";
    public string rollAnimationName = "roll";
    public string danceAnimationName = "Dance";
}
