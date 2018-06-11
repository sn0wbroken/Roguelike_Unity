using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.U2D;

/// <summary>
/// 地形に合わせた画像を床に貼る
/// </summary>
public class Tile_Sprite_Changer : MonoBehaviour {
    /// <summary>
    /// 床画像をまとめたもの
    /// </summary>
    [SerializeField]
    SpriteAtlas Tile_atlas;
    /// <summary>
    /// いくつのものをまとめたかを格納
    /// </summary>
    int sprite_count;
    /// <summary>
    /// まとめた画像の１つずつを格納
    /// </summary>
    Sprite[] sprite_array;


    void Start() {
        Tile_atlas = Resources.Load<SpriteAtlas>("Dungeon\\Tiles_Atlas");
        sprite_count = Tile_atlas.spriteCount;
        sprite_array = new Sprite[sprite_count];
        Tile_atlas.GetSprites(sprite_array);
        var enemy_status = gameObject.GetComponent<Enemy_Controller>().enemy_status;
        var actor_manager = Actor_Manager.Instance;
    }

    /// <summary>
    /// 画像をセット
    /// </summary>
    /// <param name="type">spritesの要素数</param>
    void Set_Sprite(int type) {
        var sprite_renderer = gameObject.GetComponent<SpriteRenderer>();
        sprite_renderer.sprite = sprite_array[type];
    }
}
