namespace OOP
{
    public class ConsolePrinter : Printer
    {
        public override void Print(Message message)
        {
            Console.WriteLine(message.Text);
        }
    }
}
