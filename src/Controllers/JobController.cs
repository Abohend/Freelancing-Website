﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Models.Dto.Job;
using src.Repository;
using System.Security.Claims;

namespace src.Controllers
{
	[Authorize(Roles = "Freelancer")]
	[Route("api/[controller]")]
	[ApiController]
	public class JobController : ControllerBase
	{
		private readonly JobRepository _jobRepo;
		private readonly ProjectRepository _projectRepo;

		#region Helpers
		private string GetId()
		{
			return User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
		}
		#endregion

		public JobController(JobRepository jobRepository, ProjectRepository projectRepository)
		{
			this._jobRepo = jobRepository;
			this._projectRepo = projectRepository;
		}

		// GET: api/<JobController>
		// returns all the jobs for the project that freelancer take
		[HttpGet("{projectId:int}")]
		public IActionResult Get(int projectId)
		{
			// make sure the authorized user is the owner of the project
			var project = _projectRepo.Read(projectId);
			if (project == null)
			{
				return NotFound(new Response(404, ["Invalid project Id"]));
			}
			else if (_projectRepo.ReadProjectTaker(projectId) != GetId())
			{
				return BadRequest(new Response(401, ["Not authorized to Get jobs from this project."]));
			}

			var jobs = _jobRepo.ReadAll(projectId);
			return Ok(new Response(200, jobs));
		}

		// POST api/<JobController>
		[HttpPost("{projectId}")]
		public IActionResult Post(int projectId, [FromBody] List<CreateJobDto> JobsDto)
		{
			// make sure the authorized user is the owner of the project
			var project = _projectRepo.Read(projectId);
			if (project == null)
			{
				return NotFound(new Response(404, ["Invalid project Id"]));
			}
			else if (_projectRepo.ReadProjectTaker(projectId) != GetId())
			{
				return BadRequest(new Response(401, ["Not authorized to add jobs to this project."]));
			}

			_jobRepo.Create(projectId, JobsDto);
			return Ok(new Response(201, JobsDto));
		}

		// DELETE api/<JobController>/5
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			// only allowed for freelancer who created it and must sure that no freelancer is assigned to it
			var job = _jobRepo.Read(id);
			if (_projectRepo.ReadProjectTaker(job.ProjectId) != GetId())
			{
				return BadRequest(new Response(401, ["Invalid Job Id"]));
			}
			else if (job.FreelancerId != null)
			{
				return BadRequest(new Response(401, ["Not authorized to delete jobs that is already assigned to freelancers"]));

			}

			var result = _jobRepo.Delete(id);
			if (result)
			{
				return Ok(new Response(200));
			}
			return BadRequest(new Response(400, ["Something went wrong!"]));
		}
	}
}
