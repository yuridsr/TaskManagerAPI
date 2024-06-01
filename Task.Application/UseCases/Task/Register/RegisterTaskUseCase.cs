using Task.Communication.Requests;
using Task.Communication.Responses;

namespace Task.Application.UseCases.Task.Register;
public class RegisterTaskUseCase
{
    public ResponseTaskJson Execute(RequestRegisterTaskJson request)
    {
        return new ResponseTaskJson()
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            DeadLine = request.DeadLine,
            Status = request.Status 
        };
    }
}
