using System.Collections.Generic;
using UnityEngine;

namespace ULTRAReplay.Master.Data;

public class ReplayData(List<int> initIntegers,
                        List<float> initFloats,
                        List<Vector3> initVector3s,
                        List<string> initStrings)
{
    public List<int> integers = initIntegers;
    public List<float> floats = initFloats;
    public List<Vector3> vector3s = initVector3s;
    public List<string> strings = initStrings;
}
