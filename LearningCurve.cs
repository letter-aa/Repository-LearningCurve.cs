using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    //the variables that show up in the inspector
    private int CurrentAge = 10;
    public int AddedAge = 1;

    public float Pi = 3.14f; //dont forget to add "f" on every float number
    public string FirstName = "Shohjahon"; //always add double quotation marks for strings
    public bool IsAuthor = true; //booleans are always only true or false

    // Start is called before the first frame update
    void Start()
    {
        AgeAdder();
        Debug.Log($"This is an example of an interpolated string. For example, I can directly call out this variable using only this format; {FirstName}");
    }

    // Update is called once per frame, btw we are using this later
    void Update()
    {
        
    }

    void AgeAdder()
    {
        Debug.Log(CurrentAge + AddedAge);
        //or
        print(CurrentAge + AddedAge);
    }

    void ExtraMentions()
    {
        /*This is an implicit conversion. "Implicit conversions take place automatically,
        usually when a smaller value will fit into another variable type without any rounding."*/
        int RandomInt = 7;
        float MyFloat = RandomInt;

        Debug.Log(RandomInt);
        Debug.Log(MyFloat);


        /*This is an example of an Explicit conversion. "Explicit conversions are needed when there 
          is a risk of losing a variable's information during the conversion."*/
        int ThisIsAnExplicitConversion = (int)3.14;
        Debug.Log(ThisIsAnExplicitConversion);
    }

}
