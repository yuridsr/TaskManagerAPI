using Task.Communication.Responses;
using Task.Communication.Enums;

namespace Task.Application.UseCases.Task.GetAll;
public class GetAllTasksUseCase
{
	public ResponseGetAllTasksJson Execute()
	{
		return new ResponseGetAllTasksJson()
		{
			Tasks = new List<ResponseTaskJson>
			{
				new ResponseTaskJson()
				{
					Id = 1,
					Name = "YURI",
					Description = "TAREFA1",
					DeadLine = new DateTime(2024, 06, 01),
					Priority = Priority.Low,
					Status = Status.Waiting
				},
				new ResponseTaskJson()
				{
					Id = 2,
					Name = "Sebastiao",
					Description = "TAREFA2",
					DeadLine = new DateTime(2025, 06, 01),
					Priority = Priority.Medium,
					Status = Status.Completed
				}
			}
		};
	}
}
