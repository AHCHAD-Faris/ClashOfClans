using System;

namespace ClashOfClans.Core.Exceptions
{
    public class InvalidQuantityException : Exception
    {
        public InvalidQuantityException()
            : base("ARGHHHHH !!! We told you we do not like computations.Provide us the exact quantities")
        {
        }
    }
}
