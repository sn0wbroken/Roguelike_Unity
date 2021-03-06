﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// アクターの基底クラス
/// </summary>
public class Actor : MonoBehaviour {
    /// <summary>
    /// 現在の座標の足元にあるもの
    /// </summary>
    int feet;
    public int Feet { get; set; }
    /// <summary>
    /// 死亡判定 trueで死亡
    /// </summary>
    int exist;
    public bool Exist { get; set; }

    /// <summary>
    /// 自分のいる座標
    /// </summary>
    public Vector2Int position;

    /// <summary>
    /// 自分の初期座標を設定
    /// </summary>
    /// <param name="width">スポーン座標</param>
    /// <param name="height"><スポーン座標/param>
    public virtual void Set_Initialize_Position(int width, int height) { }

    /// <summary>
    /// transform.positionに合わせる
    /// </summary>
    /// <param name="new_position"></param>
    public virtual void Set_Position(Vector2Int new_position) { }

    /// <summary>
    /// 現在のポジションを取得する
    /// </summary>
    /// <returns></returns>
    public virtual Vector2Int GetPosition() { return position; }

    /// <summary>
    /// 足元にあるものを設定する
    /// </summary>
    /// <param name="layer_number"></param>
    public virtual void Set_Feet(int layer_number) { }
}
