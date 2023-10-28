


//klassi loomine . võimaldab salvestada vahemälusse nii string kui int tüüpi muutujaid. myDog - on kastike kuhu salvestub nii string kui int.

using System;

Console.WriteLine("Name your Dog:");
string myDogName =Console.ReadLine();
Dog myDog = new Dog(myDogName);



Dog neighboursDog = new Dog("Good Girl");



// teise kastikese nimi siis neighboursDog. Dog ja Dog on klass ehk kastikese struktuuri kirjeldus. Aga myDog ja neighboursDog need on objektid.
//objektidel võib olla üks ja sama kirjeldus , aga neil erinevad kastikesed. Kirjeldatud ühte moodi aga vahemälus on kaks erinevat kastikest ehk kaks erinevat koera. 

Console.WriteLine($" My Dogs Name is {myDog.Name}");
Console.WriteLine($" My Dogs neigbours Dog Name is {neighboursDog.Name}");

myDog.Reaname("Bad Boy");


while (myDog.LevelofHapiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();

class Dog
{
    private string _name; // väli, private sõnaga kaitstud 
    private int _levelofHapiness;


    // classi KONSTRUKTOR
    public Dog(string name) 
    
    { 
        _name = name;
        _levelofHapiness = 0;
    
    }  // kasutaja nimetab ise koera nime 

    //getter - üks osa klassi kirjeldusest. 

    public string Name
    { 
        get { return _name; } 
    }   

    public int LevelofHapiness
    {
        get { return _levelofHapiness; }
    }

    public void Reaname(string newName)
    { 
        
       _name = newName;
        Console.WriteLine($"The Dog has been renamed to{newName}:");
    
    }    

    public void Bark()
    {
        Console.WriteLine("Woof-woof");
        _levelofHapiness++; 

            }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
            
            }
}
