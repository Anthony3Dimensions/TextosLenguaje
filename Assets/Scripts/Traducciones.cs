using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/TranslationSO", order = 1)]

    public class TranslationSO : ScriptableObject
    {
        public string language;
              
    }

}
