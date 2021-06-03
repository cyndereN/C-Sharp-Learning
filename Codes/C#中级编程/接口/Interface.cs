using UnityEngine;
using System.Collections;

//这是只有一个必需方法的基本
//接口。
public interface IKillable
{
    void Kill();
}

//这是一个通用接口，其中 T 是
//将由实现类提供的数据类型的
//占位符。
public interface IDamageable<T>
{
    void Damage(T damageTaken);
}