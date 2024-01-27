using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Comp2139_labs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Comp2139_labs.Controllers
{
    public class ProjectController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var projects = new List<Project>()
            {
                new Project { ProjectId = 1, Name = "Project 1", Description = "This is my first project" }

            };

            return View(projects);
        }

      
        [HttpGet]
        public IActionResult Details(int id)
            {
            var project = new Project { ProjectId = id, Name = "Project " + id, Description = "Details of project" + id };
                return View();
            }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project project)
        {
            return RedirectToAction("Index");
        }

    }
        }
    