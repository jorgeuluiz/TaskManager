using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.TaskManager.Register;

public class RegisterTaskManagerUseCase
{
    public ResponseRegisterTaskManagerJson Execute(RequestTaskManagerJson request)
    {
        return new ResponseRegisterTaskManagerJson
        {
            Id = 7,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            Status = request.Status,
            Deadline = request.Deadline
        };
    }
}
