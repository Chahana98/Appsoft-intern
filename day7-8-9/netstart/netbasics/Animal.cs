class Animal{
    internal string name;
    internal string type;
    internal string scientificname;
    internal int weight;
    internal int age; 
    internal void PrintDetails(){
    Console.WriteLine($"{name} {type} {scientificname} {weight} {age}");
}
}