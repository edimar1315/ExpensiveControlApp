using ExpensiveControlApp.Models.Expensives;

namespace ExpensiveControlApp.DTOs
{
    public class ListExpensiveDTO
    {
        public ListExpensiveDTO()
        {
            StartDate = DateTime.UtcNow.AddDays(-7);
            EnDate = DateTime.UtcNow.AddDays(3);
            Items = new List<Expensive>();
        }


        public DateTime StartDate { get; set; }

        public DateTime EnDate { get; set; }

        public List<Expensive> Items { get; set; }
    }
}
