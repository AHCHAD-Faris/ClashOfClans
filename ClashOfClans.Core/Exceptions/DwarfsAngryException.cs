using System;

namespace ClashOfClans.Core.Exceptions
{
    public class DwarfsAngryException : Exception
    {
        public DwarfsAngryException()
            : base("You must be joking, we can not work so cheap !!!!")
        {
        }
    }
}
