using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class HealCommandSO : CommandSO
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    //void Update()
    //{

    //}

    //変数の多様化
    [SerializeField] int healPoint;

    //CommandSOのExecuteを上書きして実行する。
    //overrideすることで関数を多様化できる。
    public override void Execute(Battler user, Battler target)
    {
        target.hp += healPoint;
        Debug.Log($"{user.name}の回復:{target.name}を{healPoint}回復:残りHP{target.hp}");
    }
}
