using LearningSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.LearningSystem;
using BlogAndShop.Services.Services.LearningSystem;
using BlogAndShop.Services.Services.Mapper;

namespace LearningSystem.Controllers
{
    public class HomeController : Controller
    {
        #region Fields

        private readonly ILearningSiteConfigService _learningSiteConfigService;
        private readonly ICourseService _courseService;
        private readonly ILearningSystemFooterLinkService _learningSystemFooterLinkService;
        private readonly ICourseRegisterRequestService _courseRegisterRequestService;

        private int _systemId;



        #endregion
        #region Methods
        public async Task<IActionResult> Index()
        {
            var domainName = Request.Host.Value;
            _systemId = domainName.Contains("learn.darianteam.ir", StringComparison.OrdinalIgnoreCase) ? 2 :
                domainName.Contains("camp.darianteam.ir", StringComparison.OrdinalIgnoreCase) ? 1 : 2;
            var model = await _learningSiteConfigService.GetSystemInfo(_systemId);
            if (model == null) return Redirect("https://darianteam.ir");
            model.CoursesModel = await _courseService.GetAllModelBySystemId(_systemId);
            model.Links = await _learningSystemFooterLinkService.LinksModel();
            return View(model);
        }

        public async Task<JsonResult> Register(CourseRegisterRequestViewModel model)
        {
            var entity = model.ToEntity();
            await _courseRegisterRequestService.InsertAsync(entity);
            return new JsonResult("");
        }
        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public HomeController(ILearningSiteConfigService learningSiteConfigService, ICourseService courseService, ILearningSystemFooterLinkService learningSystemFooterLinkService, ICourseRegisterRequestService courseRegisterRequestService)
        {
            _learningSiteConfigService = learningSiteConfigService;
            _courseService = courseService;
            _learningSystemFooterLinkService = learningSystemFooterLinkService;
            _courseRegisterRequestService = courseRegisterRequestService;
        }
        #endregion




    }
}
