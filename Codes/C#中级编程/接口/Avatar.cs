using UnityEngine;
using System.Collections;

public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
{
    //IKillable 接口的必需方法
    public void Kill()
    {
        //执行一些有趣操作
    }

    //IDamageable 接口的必需方法
    public void Damage(float damageTaken)
    {
        //执行一些有趣操作
    }
}
