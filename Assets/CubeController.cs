using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{

    //キューブの移動速度
    private float speed = -0.2f;

    //消滅位置
    private float deadLine = -10;

    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        //キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        //画面の外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //◆課題◆衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        // 地面またはキューブと衝突したら、効果音を鳴らす
        if (other.gameObject.tag == "GroudTag" || other.gameObject.tag == "CubeTag")
        {
            GetComponent<AudioSource>().volume = 1;
        }
    }

}