using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using IndiqMe.Api.Filters;
using IndiqMe.Api.ViewModels;
using IndiqMe.Domain.Common;
using IndiqMe.Service.Generic;
using System;
using System.Linq.Expressions;

namespace IndiqMe.Api.Controllers
{
    public class BaseController<T> : BaseController<T, T, T>
        where T : BaseEntity
    {
        public BaseController(IBaseService<T> service) : base(service) { }
    }

    public class BaseController<T, R> : BaseController<T, R, T>
        where T : BaseEntity
        where R : BaseViewModel
    {
        public BaseController(IBaseService<T> service) : base(service) { }
    }

    [GetClaimsFilter]
    [EnableCors("AllowAllHeaders")]
    public class BaseController<T, R, A> : Controller
        where T : BaseEntity
        where R : IIdProperty
        where A : class
    {
        protected readonly IBaseService<T> _service;
        private Expression<Func<T, object>> _defaultOrder = x => x.Id;
        protected bool HasRequestViewModel { get { return typeof(R) != typeof(T); } }

        public BaseController(IBaseService<T> service)
        {
            _service = service;
        }
        protected void SetDefault(Expression<Func<T, object>> defaultOrder)
        {
            _defaultOrder = defaultOrder;
        }

        [HttpGet()]
        public virtual PagedList<T> GetAll() => Paged(1, 15);

        [HttpGet("{page}/{items}")]
        public virtual PagedList<T> Paged(int page, int items) => _service.Get(x => true, _defaultOrder, page, items);

        [HttpGet("{id}")]
        public T GetById(string id) => _service.Find(new Guid(id));

        
    }
}
