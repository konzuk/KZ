using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Main.Tables.Accounting.Account;

namespace Main.Tables.Accounting.Journal
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
