using AutoMapper;
using BLL.Entities;
using BLL.Interfaces;
using BLL.Services;
using fcn_CRUD_again.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fcn_CRUD_again.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;
        private IMapper _mapper;
        public CategoryController(ICategoryService _categoryService, IMapper _mapper)
        {
            this._categoryService = _categoryService;
            this._mapper = _mapper;
        }
        //Create
        [HttpPost]
        public void Post([FromBody] CategoryViewModel category)
        {
            if (category == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                _categoryService.Add(_mapper.Map<CategoryDTO>(category));

                Response.StatusCode = 201;
            }
            catch (Exception)
            {
                Response.StatusCode = 400;
            }
        }
        //Read
        [HttpGet]
        public IEnumerable<CategoryViewModel> Get()
        {
            return _mapper.Map<IEnumerable<CategoryViewModel>>(_categoryService.Get());
        }
        //Read ID
        [HttpGet("{ID}")]
        public CategoryViewModel Get(int ID)
        {
            var result = _categoryService.Get(ID);
            if (result == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            else
            {
                return _mapper.Map<CategoryViewModel>(result);
            }
        }
        //reed all by lang
        ///Реализовать через груп бай в репощзитории!!!!
        [HttpGet("GetAllByLanguageId")]
        public IEnumerable<CategoryViewModel> GetAllByLanguageId([FromQuery] int LanguageID)
        {
            return _mapper.Map<IEnumerable<CategoryViewModel>>(_categoryService.GetAllByLanguageId(LanguageID));
        }
        //Update
        [HttpPut]
        public void Put([FromBody] CategoryViewModel Category)
        {
            if (Category == null)
            {
                throw new ArgumentNullException("CategoryToUpdate");
            }
            if (ModelState.IsValid)
            {
                _categoryService.Edit(_mapper.Map<CategoryDTO>(Category));

                Response.StatusCode = 200;
            }
            else
            {
                Response.StatusCode = 400;
            }

        }
        //Delete
        [HttpDelete("{ID}")]
        public void Delete(int ID)
        {
            _categoryService.Delete(ID);
            Response.StatusCode = 204;
        }

    }
}
