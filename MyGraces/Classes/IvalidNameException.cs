namespace Classes
{
    using System;

    public class IvalidNameException : ApplicationException
    {
        public IvalidNameException(string msg, int min, int max)
            : base(msg)
        {
            this.Min = min;
            this.Max = max;
        }

        public int Min { get; set; }
        public int Max { get; set; }
    }
}
