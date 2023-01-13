using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{

    public virtual void OnComplete()
    {
        Destroy(gameObject);
    }

    public void MoveY(float finalPosY = -6f, float velocity = 5f, float delay = 0f)
    {
        LeanTween.moveY(gameObject, finalPosY, velocity)
            .setDelay(delay)
            .setOnComplete(() =>
            {
                LeanTween.cancel(gameObject);
                OnComplete();
            });
    }

    public void MoveX(float finalPosX = -6f, float velocity = 5f, float delay = 0f)
    {
        LeanTween.moveX(gameObject, finalPosX, velocity)
            .setDelay(delay);
    }

}
