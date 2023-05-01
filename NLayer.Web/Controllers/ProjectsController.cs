using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NLayer.Core.DTOs;
using NLayer.Web.Services;

namespace NLayer.Web.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly PersonalApiService _personalApiService;
        private readonly ProjectApiService _projectApiService;

        public ProjectsController(ProjectApiService projectApiService, PersonalApiService personalApiService)
        {
            _projectApiService = projectApiService;
            _personalApiService = personalApiService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _projectApiService.GetAllAsync());
        }

        public async Task<IActionResult> Save()
        {
            var approvalStatus = await _projectApiService.GetAllApprovalStatusAsync();
            ViewBag.ApprovalStatus = new SelectList(approvalStatus, "Id", "Name");
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProjectDto projectDto)
        {
            if (ModelState.IsValid)
            {
                await _projectApiService.SaveAsync(projectDto);
                return RedirectToAction(nameof(Index));
            }

            var approvalStatus = await _projectApiService.GetAllApprovalStatusAsync();
            ViewBag.ApprovalStatus = new SelectList(approvalStatus, "Id", "Name");
            return View();
        }


        //[ServiceFilter(typeof(NotFoundFilter<Personal>))]
        public async Task<IActionResult> Update(Guid id)
        {
            var project = await _projectApiService.GetByIdAsync(id);
            var projectsDto = await _projectApiService.GetAllAsync();
            ViewBag.project = new SelectList(projectsDto, "Id", "Name", project.Id);
            return View(project);

        }
        [HttpPost]
        public async Task<IActionResult> Update(ProjectDto projectDto)
        {
            if (ModelState.IsValid)
            {
                await _projectApiService.UpdateAsync(projectDto);
                return RedirectToAction(nameof(Index));
            }
            var projectsDto = await _projectApiService.GetAllAsync();
            ViewBag.project = new SelectList(projectsDto, "Id", "Name", projectDto.Id);
            return View(projectDto);
        }


        public async Task<IActionResult> Remove(Guid id)
        {
            await _projectApiService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
