using System;
using System.Web.Mvc;
using WebFunction3D.Mappers;
using WebFunction3D.Model;
using WebFunction3D.Notifications;
using WebFunction3D.ViewModels;
using WebFunction3D_core.FunctionNew;
using WebFunction3D_core.FunctionNew.Graph3D.Templates;
using WebFunction3D_core.FunctionNew.Highcharts.Templates;

namespace WebFunction3D.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IFunctionDataFacade _dataFacade;
        private readonly IMapper _mapper;

        public HomeController(IFunctionDataFacade dataFacade, IMapper mapper)
        {
            _dataFacade = dataFacade;
            _mapper = mapper;
        }

        //GET: Home/Index

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //POST: Home/Index

        [HttpPost]
        public ActionResult Index(Function function)
        {
            return View(function);
        }

        //GET: Home/TreeDFunction

        [HttpGet]
        public ActionResult TreeDFunction()
        {
            return View();
        }

        //POST: Home/TreeDFunction

        [HttpPost]
        public ActionResult TreeDFunction(TreeDFunctionViewModel model)
        {
            return View(model);
        }

        //GET: Home/Graph3D

        [HttpGet]
        public ActionResult Graph3D()
        {
            return View(new Graph3DViewModel());
        }

        //POST: Home/Graph3D

        [HttpPost]
        public ActionResult Graph3D(Graph3DViewModel model)
        {
            var template = (Graph3DTemplate)_mapper.Map(model, typeof (Graph3DViewModel), typeof (Graph3DTemplate));
            var source = _dataFacade.GetFunction(template).Source;
            return Json(source, JsonRequestBehavior.AllowGet);
        }

        //GET: Home/Spline2D
        [HttpGet]
        public ActionResult Spline2D()
        {
            return View();
        }

        //POST: Home/Spline2D
        [HttpPost]
        public ActionResult Spline2D(string data)
        {
            try
            {
                var template = new SplineTemplate {Function = data, XStep = "0.5"};
                var source = _dataFacade.GetFunction(template).Source;
                return Json(source, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                var alert = new Alert
                {
                    message = ex.Message,
                    type = AlertStyles.Danger
                };
                return Json(new { error = true, alert = alert }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Image()
        {
            try
            {
                return File((byte[]) Session["ResultByte"],"image/" + Session["terminal"]);
            }
            catch
            {
                return null;
            }
        }
    }
}