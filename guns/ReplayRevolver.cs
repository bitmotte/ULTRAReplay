using System.Collections;
using ULTRAKILL;
using UnityEngine;

namespace ULTRAReplay;

class ReplayRevolver : MonoBehaviour
{
    private GameObject model;
    private MeshFilter mesh;
    private LineRenderer beam;

    void Awake()
    {
        transform.position = new(1, 1, 1);
        
        model = new();
        model.transform.SetParent(transform);
        model.AddComponent<MeshRenderer>();
        mesh = model.AddComponent<MeshFilter>();
        mesh.mesh = MeshMaker.CreateCubeMesh();

        model.transform.localScale = new Vector3(.2f, .2f, .5f);

        beam = gameObject.AddComponent<LineRenderer>();
        beam.startColor = Color.blue;
        beam.startWidth = .1f;
        beam.endColor = new(100, 100, 255);
        beam.endWidth = .1f;

        beam.enabled = false;
    }

    public void ShootPrimary()
    {
        beam.enabled = true;
        beam.SetPosition(0, ReplayManager.cameraPivot.transform.position);
        Ray ray = new(transform.position, ReplayManager.cameraPivot.transform.forward * 100);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        beam.SetPosition(1, hit.point);

        StartCoroutine(ShowBeam());
    }
    
    private IEnumerator ShowBeam()
    {
        yield return new WaitForSeconds(.5f);
        beam.enabled = false;
    }
}