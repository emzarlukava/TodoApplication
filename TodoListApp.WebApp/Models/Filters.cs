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

    public bool HasCategory => this.CategoryId.ToLower() != "all";

    public bool HasDue => this.Due.ToLower() != "all";

    public bool HasStatus => this.StatusId.ToLower() != "all";

    public bool IsPast => this.Due.ToLower() == "past";

    public bool IsFuture => this.Due.ToLower() == "future";

    public bool IsToday => this.Due.ToLower() == "today";
}
