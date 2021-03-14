using System;

namespace HelloDILibrary
{
    public class Salutation : ISalutation
    {
        private const string ExclaimMessage = "Hello DI!";
        private readonly IMessageWriter writer;
        public Salutation(IMessageWriter writer)
        {
            if (writer == null)
                throw new ArgumentNullException("writer");
            this.writer = writer;
        }
        public void Exclaim()
        {
            writer.Write(ExclaimMessage);
        }
    }
}
