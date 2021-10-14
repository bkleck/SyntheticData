
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Perception.Randomization.Parameters;
using UnityEngine.Perception.Randomization.Randomizers;

[Serializable]
[AddRandomizerMenu("Perception/Placement Randomizer")]
public class PlacementRandomizer : Randomizer
{
    public FloatParameter Scale;
    public Vector3Parameter Location;
    public Vector3Parameter Rotation;
    public GameObjectParameter prefabs;
    public BooleanParameter Chance;

    private GameObject Instance1;
    private GameObject Instance2;
    private GameObject Instance3;

    protected override void OnIterationStart()
    {
        if (Chance.Sample())
        {
            Instance1 = GameObject.Instantiate(prefabs.Sample());
            Instance1.transform.position = Location.Sample();
            Instance1.transform.rotation = Quaternion.Euler(Rotation.Sample());
            Instance1.transform.localScale = Vector3.one * Scale.Sample();
        }

        if (Chance.Sample())
        {
            Instance2 = GameObject.Instantiate(prefabs.Sample());
            Instance2.transform.position = Location.Sample();
            Instance2.transform.rotation = Quaternion.Euler(Rotation.Sample());
            Instance2.transform.localScale = Vector3.one * Scale.Sample();
        }

        if (Chance.Sample())
        {
            Instance3 = GameObject.Instantiate(prefabs.Sample());
            Instance3.transform.position = Location.Sample();
            Instance3.transform.rotation = Quaternion.Euler(Rotation.Sample());
            Instance3.transform.localScale = Vector3.one * Scale.Sample();
        }
    }

    protected override void OnIterationEnd()
    {
        GameObject.Destroy(Instance1);
        GameObject.Destroy(Instance2);
        GameObject.Destroy(Instance3);
    }
}
