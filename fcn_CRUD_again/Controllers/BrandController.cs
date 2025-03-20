using AutoMapper;
using BLL.Entities;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using fcn_CRUD_again.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fcn_CRUD_again.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandController : Controller
    {
        private IBrandService _brandService;
        private IMapper _mapper;
        public BrandController(IBrandService brandService, IMapper _mapper)
        {
            this._brandService = brandService;
            this._mapper = _mapper;
        }


        //Create
        [HttpPost]
        public void Post([FromBody] BrandViewModel brand)
        {
            if (brand == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                _brandService.Add(_mapper.Map<BrandDTO>(brand));

                Response.StatusCode = 201;
            }
            catch (Exception)
            {
                Response.StatusCode = 400;
            }
        }
        //Read
        [HttpGet]
        public IEnumerable<BrandViewModel> Get()
        {
            return _mapper.Map<IEnumerable<BrandViewModel>>(_brandService.Get());
        }
        //Read ID
        [HttpGet("{ID}")]
        public BrandViewModel Get(int ID)
        {
            var result = _brandService.Get(ID);
            if (result == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            else
            {
                return _mapper.Map<BrandViewModel>(result);
            }
        }
        //Update
        [HttpPut]
        public void Put([FromBody] BrandViewModel ProductToUpdate)
        {
            if (ProductToUpdate == null)
            {
                throw new ArgumentNullException("ProductToUpdate");
            }
            if (ModelState.IsValid)
            {
                _brandService.Edit(_mapper.Map<BrandDTO>(ProductToUpdate));

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
            _brandService.Delete(ID);
            Response.StatusCode = 204;
        }
    }
}

