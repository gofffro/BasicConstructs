using System.Collections.Generic;
using UnityEngine;

public class NewEmptyCSharpScript : MonoBehaviour 
{
  int[] numbersArrray = new int[] { 1, 2, 3 };
  List<int> evenNumbersArray = new List<int>() { 2, 4, 6 };
  Dictionary<int, string> anotherNumbers = new Dictionary<int, string>()
  {
    {1, "one"},
    {2, "two"},
    {3, "three"},
    {4, "four"}
  };
  int someIntValue = 5;
  string nameProject = "BasicConstructs";
  float someFloatValue = 3.14f;
  bool earthIsRound = true;

  void Start()
  {
    Debug.Log("Четные числа до 6: ");
    for (int indexList = 0; indexList < evenNumbersArray.Count; ++indexList)
    {
      Debug.Log(evenNumbersArray[indexList]);
    }
    Debug.Log($"Земля круглая? - {earthIsRound}");
  }
 }
