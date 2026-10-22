namespace Practice
{
    internal class Document
    {
        private string _text;

        public Document(string text)
        {
            _text = text;
        }

        public virtual void Print()
        {
            Console.WriteLine(_text);
        }
    }


    internal class Report : Document
    {
        private int _reportID;

        public Report(string text, int reportID) : base(text)
        {
            _reportID = reportID;
        }

        public void Print()
        {
            Console.WriteLine($"Report ID: {_reportID}");
        }
    }


    internal class Invoice : Document
    {
        private int _invoiceNumber;
        private int _invoiceDate;

        public Invoice(string text, int invoiceNumber, int invoiceDate) : base(text)
        {
            _invoiceNumber = invoiceNumber;
            _invoiceDate = invoiceDate;
        }

        public override void Print()
        {
            if (_invoiceDate == 0)
            {
                throw new ArgumentException("Invoice Date cannot be 0.");
            }
            else if (_invoiceDate <= 0)
            {
                throw new ArgumentException("Invoice Date cannot be 0 or less.");
            }
            else
            {
                Console.WriteLine($"Invoice Number: {_invoiceNumber}");
                Console.WriteLine($"Invoice Date: {_invoiceDate}");
            }
        }
    }
}