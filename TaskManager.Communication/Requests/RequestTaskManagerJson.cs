using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Requests;

public class RequestTaskManagerJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityType Priority { get; set; }
    public StatusType Status { get; set; }
    public DateTime Deadline {  get; set; }

}