using Task.Communication.Enums;

namespace Task.Communication.Requests;
public class RequestRegisterTaskJson
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public Priority Priority { get; set; }
	public DateTime DeadLine { get; set; }
	public Status Status { get; set; }
}
