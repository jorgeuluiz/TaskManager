using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.TaskManager.GetAll;

public class GetAllTaskManagerUseCase
{
    public ResponseAllTaskManagerJson Execute()
    {
        return new ResponseAllTaskManagerJson
        {
            Pets = new List<ResponseShortTaskManagerJson>
            {
                new ResponseShortTaskManagerJson
                {
                    Id = 1,
                    Name = "Cooco",
                    Priority = Communication.Enums.PriorityType.Baixa,
                    Status = Communication.Enums.StatusType.EmAndamento,
                    Deadline = DateTime.Now.AddDays(30)
                }
            }
        };
    }
}
