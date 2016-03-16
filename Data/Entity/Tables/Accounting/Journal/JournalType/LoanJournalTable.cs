namespace Entity.Tables.Accounting.Journal.JournalType
{
    public class LoanJournalTable : JournalTable
    {
        //Field
        public string InterestFrequency { get; set; }
        public string InstallmentFrequency { get; set; }
        public double InterestRate { get; set; }
        public double Installment { get; set; }
        public string InterestMethod { get; set; }
        //FK


        //C-FK


    }
}
