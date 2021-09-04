using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//'class'も型。これはクラスを宣言する型
public class BattleManager : MonoBehaviour
{
    //フェーズの管理
    //コルーチンでループ
    //戦闘キャラクターを作る

    [SerializeField] Battler player = default;
    [SerializeField] Battler enemy = default;

    //型のなかには値型、配列型、クラス型などがあり、
    //int型は値型、string型は配列型、"Battler型"はクラス型。
    //[SerializeField]とか、plivate とかpublicなどはアクセス修飾子

    //enumは列挙型。これは列挙子を定義する型。
    enum Phase
    {
        StartPhase,
        ChooseCommandPhase,
        ExecutePhase,
        Result,
        End,
    }

    //宣言文。型、クラス、列挙子などは変数の定義に使える。
    Phase phase;
    

    // Start is called before the first frame update
    void Start()
    {
        phase = Phase.StartPhase;
        //ピリオドは一般に「なんとかの中の」みたいな意味。
        StartCoroutine(Battle());
    }

    //これは関数の定義。IEnumeratorは
    IEnumerator Battle()
    {
        
        while(phase != Phase.End)
        {
            yield return null;
            Debug.Log(phase);
            switch (phase)
            {
                case Phase.StartPhase:
                    phase = Phase.ChooseCommandPhase;
                    break;

                case Phase.ChooseCommandPhase:
                    //技選択をしたら次のフェーズにいく
                    //new WaitUntil(() => ここがtrueになるまで待機する)
                    //Debug.Log("new WaitUntil 前");
                    yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
                    
                    //Debug.Log("new WaitUntil 後");
                    //技選択

                    player.selectCommand = player.commands[1];
                    player.target = player;
                    enemy.selectCommand = player.commands[0];
                    enemy.target = player;

                    
                    phase = Phase.ExecutePhase;
                    break;

                case Phase.ExecutePhase:
                    player.selectCommand.Execute(player,player.target);
                    enemy.selectCommand.Execute(enemy,enemy.target);
                    //どちらかが死亡したら
                    if(player.hp<=0 || enemy.hp <= 0)
                    {
                        phase = Phase.Result;
                    }
                    else
                    {
                        phase = Phase.ChooseCommandPhase;
                    }
                    
                    break;
                case Phase.Result:
                    phase = Phase.End;

                    break;
                case Phase.End:
                    break;

            }
        }
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
