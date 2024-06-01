using Task.Communication.Enums;
using Task.Communication.Responses;

namespace Task.Application.UseCases.Task.GetById;
public class GetTaskByIdUseCase
{
	public ResponseTaskJson Execute(int id)
	{
		return new ResponseTaskJson
		{
			Id = id,
			Name = "YURI",
			Description = "TAREFA1",
			DeadLine = new DateTime(2024, 06, 01),
			Priority = Priority.Low,
			Status = Status.Waiting
		};
	}
}
