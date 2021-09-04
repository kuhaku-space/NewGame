using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowBattleMenuCommand : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    //void Update()
    //{

    //}

    //SelectableTextが選択されたら、カーソルの移動をする。
    [SerializeField] Transform arrow = default;

    //SelectableTextにMoveArrowTo関数の登録を行う。
    [SerializeField]
    List<SelectableText> selectableTexts = new List<SelectableText>();

    void SetMoveArrowFunction()
    {
        foreach(SelectableText selectableText in selectableTexts)
        {
            selectableText.OnselectAction = MoveArrowTo;

        }
    }


    //テスト用
    public void Start()
    {
        SetMoveArrowFunction();
    }


    //カーソルの移動は、親を変更する。

    public void MoveArrowTo(Transform parent)
    {
        Debug.Log("カーソル移動");

        arrow.SetParent(parent);

        //if (Input.GetKey(KeyCode.Space))
        //{

            //Debug.Log($"コマンドは{transform}に決定された");
        //}
    }

    public void decideCommand()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"コマンドは{gameObject}に決定された");
        }
    }

    

}
