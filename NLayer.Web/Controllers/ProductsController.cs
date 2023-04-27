using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;
using NLayer.Web.Services;

namespace NLayer.Web.Controllers
{
    public class PersonalsController : Controller
    {
        private readonly PersonalApiService _personalApiService;
        private readonly ProjectApiService _projectApiService;

        public PersonalsController(ProjectApiService projectApiService, PersonalApiService personalApiService)
        {
            _projectApiService = projectApiService;
            _personalApiService = personalApiService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _personalApiService.GetPersonalsWithProjectsAsync());
        }

        public async Task<IActionResult> Save()
        {
            var productsDto = await _projectApiService.GetAllAsync();
            ViewBag.products = new SelectList(productsDto, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(PersonalDto personalDto)
        {
            if (ModelState.IsValid)
            {
                await _personalApiService.SaveAsync(personalDto);
                return RedirectToAction(nameof(Index));
            }

            var projectsDto = await _projectApiService.GetAllAsync();
            ViewBag.products = new SelectList(projectsDto, "Id", "Name");
            return View();
        }


        //[ServiceFilter(typeof(NotFoundFilter<Personal>))]
        public async Task<IActionResult> Update(int id)
        {
            var personal = await _personalApiService.GetByIdAsync(id);
            var projectsDto = await _projectApiService.GetAllAsync();
            ViewBag.products = new SelectList(projectsDto, "Id", "Name", personal.Id);
            return View(personal);

        }
        [HttpPost]
        public async Task<IActionResult> Update(PersonalDto personalDto)
        {
            if (ModelState.IsValid)
            {
                await _personalApiService.UpdateAsync(personalDto);
                return RedirectToAction(nameof(Index));
            }
            var projectsDto = await _projectApiService.GetAllAsync();
            ViewBag.products = new SelectList(projectsDto, "Id", "Name", personalDto.Id);
            return View(personalDto);
        }


        public async Task<IActionResult> Remove(int id)
        {
            await _personalApiService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
