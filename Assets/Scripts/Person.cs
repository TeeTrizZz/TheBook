﻿using System.Collections.Generic;
using UnityEngine;
using System.Collections;

/// <summary>
/// This datatype represents a Person in the game
/// </summary>
public class Person {

    /// <summary>
    /// The town where the person lives. It influences in what the person believes in.
    /// </summary>
    private string HomeTown { get; set; }


    /// <summary>
    /// Defines how easy it is to control this person. This value is set when a new Person is created and wont't change.
    /// 100 % is completele controllable 0 % is not controllable at all (indipendent)
    /// </summary>
    private float Controllable { get; set; }

    /// <summary>
    /// Defines how violent the personi is in general. This value is set when a new Person is created and wont't change.
    /// 100 % is very agressive, 0 % not agressive at all
    /// </summary>
    private float Violent { get; set; }


    /// <summary>
    /// Defines how happe this person is. This value is influenced by the profets behavior and rules.
    /// A happy person is easier to handel, while unhappi / dissatisfied person is more likely to revolt / turn ageints the prophet
    /// </summary>
    private float Happines { get; set; }

    private List<Rule> BelieveList; 

    /// <summary>
    /// Constructor
    /// </summary>
    public Person(string hometown)
    {
        this.HomeTown = hometown;
        this.Controllable = InitControllableViolent();
        this.Violent = InitControllableViolent();
        this.Happines = 70; // 70% Happy as std
        this.InitBeliveList();
       
    }

    /// <summary>
    /// Creates a random number for the default character traits that don't change during the game
    /// </summary>
    private float InitControllableViolent()
    {
        return Random.Range(0, 100);
    }

    private void InitBeliveList()
    {
        //get belives for the persons hometown 
        //pick randomly 3 of them (with a weight)
    }

    /// <summary>
    /// Updates the mood of the person refering to the rules of "The Book"
    /// </summary>
    public void UpdateMood()
    {
        //when there is an update in "The Book" -> chek how it is relating to the BelieveList  -> Happiness--, Happines++ ore neutral
        foreach (var belive in BelieveList)
        {
            //look it up and change values
        }
    }

    
    

}
