using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.TaskManager.Delete;
using TaskManager.Application.UseCases.TaskManager.GetAll;
using TaskManager.Application.UseCases.TaskManager.GetById;
using TaskManager.Application.UseCases.TaskManager.Register;
using TaskManager.Application.UseCases.TaskManager.Update;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskManagerController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTaskManagerJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTaskManagerJson request)
    {
        var response = new RegisterTaskManagerUseCase().Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update(
        [FromRoute] int id,
        [FromBody] RequestTaskManagerJson request)
    {
        new UpdateTaskManagerUseCase().Execute(id, request);

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTaskManagerJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var response = new GetAllTaskManagerUseCase().Execute();

        if (response.Pets.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskManagerJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById(int id)
    {
        var response = new GetTaskManagerByIdUseCase().Execute(id);

        if (response is not null)
        {
            return Ok(response);
        }

        return BadRequest();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskManagerJson), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        new DeleteTaskManagerByIdUseCase().Execute(id);

        return NoContent();
    }

}
