using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class CreateOnTap : MonoBehaviour
{
    public GameObject prefabObj;
    GameObject createdObj;
    ARRaycastManager _raymanager;
    Vector2 touchPoint = new Vector2();
    List<ARRaycastHit> hits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    private void Awake()
    {
        _raymanager = GetComponent<ARRaycastManager>();

    }
    void Start()
    {
        
    }

    bool GetPos(out Vector2 touchPoint)
    {
        if (Input.touchCount > 0)
        {
            touchPoint = Input.GetTouch(0).position;
            return true;
        }
        touchPoint = default;
        return false;
    }
    // Update is called once per frame
    void Update()
    {
        if(!GetPos(out Vector2 touchPoint))
        {
            return;
        }

        if (_raymanager.Raycast(touchPoint, hits, TrackableType.Planes))
        {
            var hitPose = hits[0].pose;
            if (createdObj == null)
            {
               createdObj =  Instantiate(prefabObj, hitPose.position, hitPose.rotation);
            }
            else
            {
                createdObj.transform.position = hitPose.position;
            }
           
        }
    }

  

}
