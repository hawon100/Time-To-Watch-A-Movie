using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Manager Data", menuName = "Scriptable Object/Manager Data", order = int.MaxValue)]
public class StageManager : ScriptableObject
{
    [SerializeField] public StageUnLock[] stage;
    [SerializeField] public string[] stageNames;
    [SerializeField] public bool[] isDead;
}
