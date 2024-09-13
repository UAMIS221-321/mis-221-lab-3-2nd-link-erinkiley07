using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

string enjoymentLevel = GetEnjoymentLevel();
string stadium= GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium ,game);



static string GetEnjoymentLevel(){
    Console.WriteLine("what enjoyment level would you like");
    return Console.ReadLine().ToLower();
}

static string GetStadiumRecommendation(string enjoymentLevel){
    if(enjoymentLevel == "boring"){
        return "Neyland staduim";

    }
    else if( enjoymentLevel == "average"){
        return "jordan hare staduim";
    }

    else if( enjoymentLevel == "fun"){
        return "tiger staduim";
    }

    else if ( enjoymentLevel == "epic"){
        return "saban field at bryant denny staduim";
    }
    else{
        return "invalid anwer";

    }
    
   

}

static string GetGameRecommendation(string stadium){
if(stadium == "Neyland staduim"){
    return "vs Kent State";
}
else if(stadium == "jordan hare staduim"){
    return "vs kentucky";
}
else if( stadium == "tiget stadium"){
    return "vs. alabama";
}
else if (stadium == "saban field at bryant denny staduim"){
    return " vs auburn";
}
else{
    return" invalid answer";
}
}

static void DisplayStadiumDetails(string stadium , string game){
    Console.WriteLine($"You should to this {stadium} for this {game}");


}



