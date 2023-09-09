namespace Experiments.WrapperTypes;

/// <summary>
/// Example of how we can abstract away primitive string values in favor of more domain-centric concepts.
/// This example assumes we're modelling a small set of possible mutually exclusive states, similar to what we'd do with an enum.
/// </summary>
public struct WorkItemStatus 
{
    private readonly string status;

    public WorkItemStatus(string status)
    {
        if (string.IsNullOrWhiteSpace(status))
        {
            throw new ArgumentNullException(nameof(status));
        }
        // TODO: Additional validation to restrict input values to a known space? 

        this.status = status;
    }

    // TODO: Would we need constants for these string values?
    public static readonly WorkItemStatus Ready = "ready";
    public static readonly WorkItemStatus InProgress = "inprogress";
    public static readonly WorkItemStatus Completed = "completed";
    public static readonly WorkItemStatus Unknown = "unknown";

    public static implicit operator string(WorkItemStatus value) => value.status;
    public static implicit operator WorkItemStatus(string value) => new WorkItemStatus(value); 
}
