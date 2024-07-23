using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.TaskManager.GetById;

public class GetTaskManagerByIdUseCase
{
    public ResponseTaskManagerJson Execute(int id)
    {
        return new ResponseTaskManagerJson
        {
            Id = id,
            Name = "Solicitação urgente",
            Description = "entregar tudo que pode para deploy em PRD",
            Priority = Communication.Enums.PriorityType.Alta,
            Status = Communication.Enums.StatusType.EmAndamento,
            Deadline = DateTime.Now.AddDays(1)
        };
    }
}
