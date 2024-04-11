namespace TodoListApp.WebApp.Models;

public class FiltersTodo
{
    public FiltersTodo(string filterstring)
    {
        this.FilterString = filterstring ?? "all-all-all";
        string[] filters = this.FilterString.Split('-');
        this.CategoryId = filters[0];
        this.Due = filters[1];
        this.StatusId = filters[2];
    }

    public static Dictionary<string, string> DueFilterValues =>
        new Dictionary<string, string>
        {
            { "future", "Future" },
            { "past", "Past" },
            { "today", "Today" },
        };

    public string FilterString { get; }

    public string CategoryId { get; }

    public string Due { get; }

    public string StatusId { get; }

    public bool HasCategory => !this.CategoryId.Equals("all", StringComparison.OrdinalIgnoreCase);

    public bool HasDue => !this.Due.Equals("all", StringComparison.OrdinalIgnoreCase);

    public bool HasStatus => !this.StatusId.Equals("all", StringComparison.OrdinalIgnoreCase);

    public bool IsPast => this.Due.Equals("past", StringComparison.OrdinalIgnoreCase);

    public bool IsFuture => this.Due.Equals("future", StringComparison.OrdinalIgnoreCase);

    public bool IsToday => this.Due.Equals("today", StringComparison.OrdinalIgnoreCase);
}
