using System;

namespace MovieFestival;

public class Genre
{
    string Name = "Test";

    public string GetData(){
        return Name[0].ToString() + Name[Name.Last()].ToString();
    }
}
