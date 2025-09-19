using System;

namespace phase2
{
    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException() : base("The specified record was not found.")
        {
        }

    }
}