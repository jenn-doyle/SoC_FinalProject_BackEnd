﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

[ApiController]
[Route("[controller]")]
public class HomeworkController : ControllerBase
{
    private readonly IHomework<Homework> _homeworkRepository;

    public HomeworkController(IHomework<Homework> homeworkRepository)
    {
        _homeworkRepository = homeworkRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var homework = await _homeworkRepository.GetAll();
            return Ok(homework);
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }

    [HttpPost]
    public async void Insert([FromBody] Homework homework)
    {
        try
        {
            _homeworkRepository.Insert(homework);
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
            Console.WriteLine(error.StackTrace);
        }
    }

    [HttpPut("{id}")]
    public async void Update(long id, [FromBody] Child child)
    {
        try
        {
            _homeworkRepository.Update(id, child.Id, child.Image, child.Comment, child.Annotation);
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
            Console.WriteLine(error.StackTrace);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetHomework(long id)
    {
        try
        {
            var getHomeowrk = await _homeworkRepository.GetOne(id);
            return Ok(getHomeowrk);
        }
        catch (Exception)
        {
            //handle exception
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteHomework(long id)
    {
        await _homeworkRepository.Delete(id);
        return Ok();
    }

}