using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.U2D;

/// <summary>
/// 場所に合った画像を壁に貼る
/// </summary>
public class Wall_Sprite_Changer : MonoBehaviour {
    /// <summary>
    /// 床画像をまとめたもの
    /// </summary>
    [SerializeField]
    SpriteAtlas Wall_atlas;
    /// <summary>
    /// いくつのものをまとめたかを格納
    /// </summary>
    int sprite_count;
    /// <summary>
    /// まとめた画像の１つずつを格納
    /// </summary>
    Sprite[] sprite_array;

    void Start () {
        Wall_atlas = Resources.Load<SpriteAtlas>("Dungeon\\Walls_Atlas");
        sprite_count = Wall_atlas.spriteCount;
        sprite_array = new Sprite[sprite_count];
        Wall_atlas.GetSprites(sprite_array);
        var enemy_status = gameObject.GetComponent<Enemy_Controller>().enemy_status;
        var actor_manager = Actor_Manager.Instance;
    }

    /// <summary>
    /// 画像をセット
    /// </summary>
    /// <param name="type">spritesの要素数</param>
    void Set_Sprite(int type) {
        SpriteRenderer sprite_renderer = gameObject.GetComponent<SpriteRenderer>();
        sprite_renderer.sprite = sprite_array[type];
    }
}
