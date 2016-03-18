namespace OrgChart
{
    internal interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}

