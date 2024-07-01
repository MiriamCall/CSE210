class Police : Person
{
    private string _weapons;
    
    public Police(string weapons, string firstName, string lastName, int age, int weight) : base(firstName, lastName, age, weight)
    {
        _weapons = weapons;
        this._firstName = "bubba";
    }

    public string PoliceInformation()
    {
        return $"{_weapons}, {PersonInformation()}";
    }
}