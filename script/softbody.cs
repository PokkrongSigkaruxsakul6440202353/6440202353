using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;


public class softbody : MonoBehaviour
{
    #region constant
    private const float splineoffset = 0.5f;
    #endregion
    #region Fields
    [SerializeField]
    public SpriteShapeController SpriteShape;
    [SerializeField]
    public Transform[] points;
    #endregion

    #region MonoBehaviour Callbacks
    private void Awake()
    {
        updateverticle();
    }
    private void Update()
    {
        updateverticle();
    }
    #endregion

    #region privateMethods
    private void updateverticle()
    {
        for(int i = 0; i < points.Length-1;i++) 
        { 
            Vector2 _vertex = points[i].localPosition;
            Vector2 _towardscenter = (Vector2.zero - _vertex).normalized;

            float _colliderRadius = points[i].gameObject.GetComponent<CircleCollider2D>().radius;
            try
            {
                SpriteShape.spline.SetPosition(i, (_vertex - _towardscenter*_colliderRadius));
            }
            catch
            {
                Debug.Log("too close");
                SpriteShape.spline.SetPosition(i, (_vertex - _towardscenter *(_colliderRadius + splineoffset) ) );
            }

            Vector2 _lt = SpriteShape.spline.GetLeftTangent(i);
            Vector2 _newrt = Vector2.Perpendicular(_towardscenter) * _lt.magnitude;
            Vector2 _newlt = Vector2.zero - _newrt;

            SpriteShape.spline.SetRightTangent(i, _newrt);
            SpriteShape.spline.SetLeftTangent(i, _newlt);
        }
    }
    #endregion
}
