namespace OOP
{
    public class FilePrinter : Printer
    {
        private string _filePath;
        public FilePrinter(string filePath)
        {
            _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
        }

        public override void Print(Message message)
        {
            using (var streamWriter = new StreamWriter(File.Open(_filePath, FileMode.Append, FileAccess.Write)))
            {
                streamWriter.WriteLine(message.Text);
                streamWriter.Flush();
            }
        }
    }
}
