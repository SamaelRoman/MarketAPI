using AutoMapper;
using DAL.Entities;
using DAL.Interfaces;
using BLL.Entities;
using BLL.Interfaces;
using fcn_CRUD_again.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace fcn_CRUD_again.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IProductService _productService;
        private IMapper _mapper;
        public ProductController(IProductService _productService, IMapper _mapper)
        {
            this._productService = _productService;
            this._mapper = _mapper;
        }

        //Create
        [HttpPost]
        public void Post([FromBody] ProductCreateViewModel product)
        {
            if(product == null)
            {
                throw new ArgumentNullException("product");
            }
            try
            {
                _productService.Add(_mapper.Map<ProductDTO>(product));
                Response.StatusCode = 201;
            }
            catch (Exception)
            {
                Response.StatusCode = 400;
            }
        }
        //Read all
        [HttpGet()]
        public IEnumerable<ProductViewModel> Get()
        {
            
            var product = _productService.Get();
            var result = _mapper.Map<IEnumerable<ProductViewModel>>(product);
            return result;
        }
        //reed all by lang
        ///Реализовать через груп бай в репощзитории!!!!
        [HttpGet("GetAllByLanguageId")]
        public IEnumerable<ProductViewModel> GetAllByLanguageId([FromQuery]int LanguageID)
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>(_productService.GetAllByLanguageId(LanguageID));
        }
        //reed all by lang and group by
        [HttpGet("GetAllProductsByGroup")]
        public IEnumerable<ProductContainerViewModel> GetAllProductsByGroup([FromQuery] int LanguageID)
        {

            return _mapper.Map<IEnumerable<ProductContainerViewModel>>(_productService.GetAllProductsByGroup(LanguageID));

        }
        /// <summary>
        /// Read all Prdoucts by category
        /// </summary>
        /// <param name="LanguageID">Id языка</param>
        /// <returns>Все продукты в определенной категории сгрупированые по bindingId</returns>
        [HttpGet("GetAllProductsByСategory")]
        public IEnumerable<ProductContainerViewModel> GetAllProductsByСategory([FromQuery] int CategoryId)
        {
            return _mapper.Map<IEnumerable<ProductContainerViewModel>>(_productService.GetAllProductsByСategory(CategoryId));

        }
        //Read ID
        [HttpGet("{ID}")]
        public ProductCreateViewModel Get(string ID)
        {
            if (ID == null)
            {
                throw new ArgumentNullException("id");
            }
            var result = _mapper.Map<ProductCreateViewModel>(_productService.Get(new Guid(ID)));

            if (result == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            else
            {               
                return result;
            }
        }
        //Update
        [HttpPut]
        public void Put([FromBody] ProductCreateViewModel ProductToUpdate)
        {
            if (ProductToUpdate == null) {
                throw new ArgumentNullException("ProductToUpdate");
            }
            if (ModelState.IsValid) {

               _productService.Edit(_mapper.Map<ProductDTO>(ProductToUpdate));
                Response.StatusCode = 204;
            }
            else
            {
                Response.StatusCode = 400;
            }

        }
        //Delete
        [HttpDelete("{ID}")]
        public void Delete(string ID)
        {
            if (ID == null)
            {
                throw new ArgumentNullException("id");
            }

            try
            {
               _productService.Delete(new Guid(ID));
            }
            finally
            {
                Response.StatusCode = 204;
            }
        }
    }
}
