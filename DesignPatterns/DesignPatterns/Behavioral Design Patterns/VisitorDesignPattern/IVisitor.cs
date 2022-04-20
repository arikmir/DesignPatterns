#region All Rights Reserved

// DesignPatterns
// Canaria Technologies 2022

#endregion

namespace DesignPatterns.Behavioral_Design_Patterns.VisitorDesignPattern
{
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}