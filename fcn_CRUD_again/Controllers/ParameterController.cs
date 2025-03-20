using AutoMapper;
using BLL.Entities;
using BLL.Interfaces;
using fcn_CRUD_again.Models;
using Microsoft.AspNetCore.Mvc;

namespace fcn_CRUD_again.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParameterController : Controller
    {
        //private IParameterService _parameterService;
        //private IMapper _mapper;
        //public ParameterController(IParameterService _parameterService, IMapper _mapper)
        //{
        //    this._parameterService = _parameterService;
        //    this._mapper = _mapper;
        //}
        ////create
        //[HttpPost]
        //public void Post([FromBody] CurrencyViewModel currency)
        //{
        //    if (currency == null)
        //    {
        //        throw new ArgumentNullException();
        //    }
        //    try
        //    {
        //        //_currencyService.Add(_mapper.Map<CurrencyDTO>(currency));

        //        Response.StatusCode = 201;
        //    }
        //    catch (Exception)
        //    {
        //        Response.StatusCode = 400;
        //    }
        //}
        ////Read
        //[HttpGet]
        //public IEnumerable<CurrencyViewModel> Get()
        //{
        //    return _mapper.Map<IEnumerable<CurrencyViewModel>>(_currencyService.Get());
        //}
        ////Read ID
        //[HttpGet("{ID}")]
        //public CurrencyViewModel Get(int ID)
        //{
        //    var result = _currencyService.Get(ID);
        //    if (result == null)
        //    {
        //        Response.StatusCode = 404;
        //        return null;
        //    }
        //    else
        //    {
        //        return _mapper.Map<CurrencyViewModel>(result);
        //    }
        //}
        ////Update
        //[HttpPut]
        //public void Put([FromBody] CurrencyViewModel Category)
        //{
        //    if (Category == null)
        //    {
        //        throw new ArgumentNullException("CategoryToUpdate");
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        _currencyService.Edit(_mapper.Map<CurrencyDTO>(Category));

        //        Response.StatusCode = 200;
        //    }
        //    else
        //    {
        //        Response.StatusCode = 400;
        //    }

        //}
        ////Delete
        //[HttpDelete("{ID}")]
        //public void Delete(int ID)
        //{
        //    _currencyService.Delete(ID);
        //    Response.StatusCode = 204;
        //}
    }
}
