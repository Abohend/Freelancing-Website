﻿using AutoMapper;
using src.Data;
using src.Models;
using src.Models.Dto.Job;

namespace src.Repository
{
	public class JobRepository
	{
		private readonly Context _context;
		private readonly IMapper _mapper;

		public JobRepository(Context context, IMapper mapper)
        {
			this._context = context;
			this._mapper = mapper;
		}

		public void Create(int projectId,List<CreateJobDto> JobsDto)
		{
			var jobs = _mapper.Map<List<Job>>(JobsDto);
			foreach (var job in jobs)
			{
				job.ProjectId = projectId;
				_context.Add(job);
			}
			_context.SaveChanges();
		}

		public ReadJobDto Read(int id)
		{
			var job = _context.Jobs.Find(id);
			return _mapper.Map<ReadJobDto>(job);
		}
		public List<ReadJobDto>? ReadAll(int projectId)
		{
			var jobs = _context.Jobs.Where(j => j.ProjectId == projectId).ToList();
			return _mapper.Map<List<ReadJobDto>?>(jobs);
		}
		public List<ReadJobDto>? ReadAll(string freelancerId)
		{
			var jobs = _context.Jobs.Where(j => j.FreelancerId == freelancerId).ToList();
			return _mapper.Map<List<ReadJobDto>?>(jobs);
		}

		public bool Delete(int id)
		{
			var job = _context.Jobs.Find(id);
			if (job != null)
			{
				_context.Remove(job);
				_context.SaveChanges();
				return true;
			}
			return false;
		}
    }
}