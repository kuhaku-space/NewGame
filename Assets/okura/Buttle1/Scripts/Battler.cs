using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battler : MonoBehaviour
{

    // Start is called before the first frame update
    //   void Start()
    //  {
    //     
    //}

    // Update is called once per frame
    //   void Update()
    //   {
    //       
    //   }



    //技の実装
    //技は独立したクラスで管理する。
    //ScriptableObjectで管理する
    //技の種類を増やすのは「継承」を使う。

    //以下、"Battler"が共通して持っているデータ、及び処理を列挙する。

    //HPを持っている
    public new string name;
    public int hp;

    //実行するコマンド(selectCommandはどの選択されたコマンドを表す変数。)
    //だからselectedCommandのほうがいいとおもう。
    //targetは技の相手を表す変数。

    public CommandSO selectCommand;
    public Battler target;
    //持ってる技
    //commandsというのは技のリストを表す変数。
    //多分CommandSO[]は、”CommandSOという型の変数を要素に持つ配列”という型だとおもう。
    public CommandSO[] commands;

    




    //コンストラクタはMonobahaviourが使用を禁止している。
    //public Battler(string initname,int inithp)
    //{
    //    name = initname; hp = inithp;
    //}

    



}
