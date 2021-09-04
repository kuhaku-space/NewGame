using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AttackCommandSO : CommandSO
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    //void Update()
    //{

    //}

    [SerializeField] int at;

    //CommandSOのExecuteを上書きして実行する。
    //overrideすることで関数を多様化できる。
    public override void Execute(Battler user, Battler target)
    {
        target.hp -= at;
        Debug.Log($"{user.name}の攻撃:{target.name}に{at}のダメージ:残りHP{target.hp}");
    }

}
