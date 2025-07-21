using Microsoft.AspNetCore.Mvc;
using toDoList.Models;
using toDoList.Data;

[ApiController]
[Route ("Todo/")]
public class ToDo : ControllerBase
{
    private readonly AppDb tasks;
    public ToDo(AppDb task){
        tasks = task;
    }

    [HttpGet]
    public IActionResult GetList(){
       return Ok(tasks.Lists.ToList()); 
    }
    [HttpPost]
    public IActionResult AddList([FromBody] List task){
        tasks.Lists.Add(task);
        tasks.SaveChanges();

        return Ok(tasks);
    }
}