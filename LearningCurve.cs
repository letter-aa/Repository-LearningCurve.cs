using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    //the variables that show up in the inspector
    private int CurrentAge = 10;
    public int AddedAge = 1;

    public float Pi = 3.14f; //Don't forget to add "f" at the beginning of every float number.
    public string FirstName = "Shohjahon"; //Always add double quotation marks for strings, obviously.
    public bool IsAuthor = true; //Booleans are ALWAYS true or false.

    // Start is called before the first frame update.
    void Start()
    {
        AgeAdder();
        //just add a dollar sign, $, to any Debug.Log(), or print(), or Console.WriteLine() then boom baby it's an interpolated string
        Debug.Log($"This is an example of an interpolated string. For example, I can directly call out this variable using only this format; {FirstName}");

        Operators();

        Debug.Log("Choose a character...");//you know
        bool beanos = true;//variable
        if (beanos == true)//checking if character has been chosen or not
        {
            int CharacterAge = 200;//character's age
            GenerateCharacter("Scrooge", CharacterAge);
                       //character's name //character's age/level
        }
        
    }

    // Update is called once per frame, but we are using this later.
    void Update()
    {

    }

    void AgeAdder()
    {
        Debug.Log(CurrentAge + AddedAge); //(I would use Debug.Log() personally because it looks more formal roflol)
        //or
        print(CurrentAge + AddedAge);
    }

    private void ExtraMentions()
    {
        int Health = 100; //This is the wrong name, because it is not detailed enough to understand.
        int MaxPlayerHealth = 100; //Now this is correct because, it IS detailed enough to understand.
                                   //(btw if every word's beginning is upper case in a variable name, its called Pascal format)

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

        //The operators example(s)/information has been trasported to the method called "Operators".

        /*There are three types of variable scope;
        Global (which can be accessed throught the whole game), 
        Class or member (which is only accessible through the class), 
        and Local (which is only accessed through the block of code that it's in).*/

        /*There are three types of access modifiers;
        Public (which is avalible to any script without rescriction),
        Private (This s only avalible in the class they're created in (which is called the containing class). FACT: Any variable without an access modifier defaults to private.),
        Protected (Accessible from their containing class or types derived from it.),
        Internal (Only available in the current assembly.)*/

        /*Method blueprint:
        accessModifier returnType UniqueName(parameterType parameterName)
        {
            method body
        }*/

        //calling methods: UniqueName(); or UniqueName(parameterVariable);
    }

    void Operators()
    {
        /*"Operators basically represent arithmetic (represents basic math functions, ex. +, -, *, / ) ,
        assignment (peforms math and represent basic math functions together on a given value), 
        relational, 
        and logical functionality.
        (relational AND logical operators evaluate conditions between multiple values, ex. greater than (>(=)), less than (<(=)) , and equal to (=(=)) )." */

        //Also an important thing to note, is that "C# operators follow the conventional order of operations, which is; 1. Parentheses, 2. Exponents, 3. Multiplication, 4. Division, 5. Addition, 6.Subtraction.

        //If you wanted to multiply a variable (ONLY NUMBERS, SUCH AS INTEGERS, FLOATS, DOUBLES, ETC.), you'd do it in this format;
        int yeetus_deletus = 32;
        yeetus_deletus = yeetus_deletus * 2;
        Debug.Log(yeetus_deletus);

        //Or you could do it this way;
        int yeetus_deletus1 = 32;
        yeetus_deletus1 *= 2;

        //You can even add STRINGS! (but you can't subtract them, divide them, multiply them, etc.) Here's how;
        string FullName = "Shohjahon" + " Jalilov";
        Debug.Log(FullName);

        //Cool, right? I know!
    }

                          //parameter1 //parameter2
    void GenerateCharacter(string name, int level)
    {
                                                 //variable called 
                                                   //for  variable called
                                                   //name   for
                                    //name     //age      //age/level
        Debug.LogFormat("Character: {0}, Age: {1}", name, level);
    }
}
