namespace BorderControl
{
    interface IIdentifiable
    {
        string Id { get; }

        bool ValidateId(string lastDigitsValid);
    }
}
