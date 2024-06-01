using Microsoft.AspNetCore.Mvc;
using Task.Application.UseCases.Task.DeleteById;
using Task.Application.UseCases.Task.GetAll;
using Task.Application.UseCases.Task.GetById;
using Task.Application.UseCases.Task.Register;
using Task.Application.UseCases.Task.Update;
using Task.Communication.Requests;
using Task.Communication.Responses;

namespace Task.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{

	[HttpPost]
	[Route("Create")]
	[ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status201Created)]
	[ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
	public IActionResult Create([FromBody] RequestRegisterTaskJson request)
	{
		var useCase = new RegisterTaskUseCase() { };

		var response = useCase.Execute(request);

		return Created(string.Empty, response);
	}

	[HttpGet]
	[Route("Get")]
	[ProducesResponseType(typeof(ResponseGetAllTasksJson), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
	public IActionResult GetAll()
	{
		var useCase = new GetAllTasksUseCase() { };
		var response = useCase.Execute();

		if (response.Tasks.Any())
		{
			return Ok(response);
		}
		return NoContent();
	}

	[HttpGet]
	[Route("Get/{id}")]
	[ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
	[ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
	public IActionResult GetById([FromRoute] int id)
	{
		return Ok(new GetTaskByIdUseCase() { }.Execute(id));
	}

	[HttpPut]
	[Route("Update/{id}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
	public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateTaskJson request)
	{
		var useCase = new UpdateTaskUseCase();

		useCase.Execute(id, request);

		return NoContent();
	}

	[HttpDelete]
	[Route("Delete/{id}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
	public IActionResult Delete([FromRoute] int id)
	{
		var useCase = new DeleteTaskByIdUseCase();

		useCase.Execute(id);

		return NoContent();
	}
}