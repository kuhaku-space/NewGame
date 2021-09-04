using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu]
public class CommandSO : ScriptableObject
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    //void Update()
    //{

    //}

    //”コマンド”という実態のないものを一つのデータの集まりとして扱う。
    //Scriptable
    public new string name;

    //実行
    public virtual void Execute(Battler user,Battler target)
    {

        //    Battler a=new Battler("okura",10);
        //target.hp -= at;
        //Debug.Log($"{user.name}の攻撃:{target.name}に{at}のダメージ:残りHP{target.hp}");
    }


}
