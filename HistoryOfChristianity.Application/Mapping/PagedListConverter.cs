using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryOfChristianity.Application.Mapping;

//Download the X.PagedList library
//public class Converter<TSource, TDestination> : ITypeConverter<IPagedList<TSource>, PagedViewModel<TDestination>>
//{
//    public PagedViewModel<TDestination> Convert(IPagedList<TSource> source, PagedViewModel<TDestination> destination, ResolutionContext context)
//    {
//        return new PagedViewModel<TDestination>()
//        {
//            FirstItemOnPage = source.FirstItemOnPage,
//            HasNextPage = source.HasNextPage,
//            HasPreviousPage = source.HasPreviousPage,
//            IsFirstPage = source.IsFirstPage,
//            IsLastPage = source.IsLastPage,
//            LastItemOnPage = source.LastItemOnPage,
//            PageCount = source.PageCount,
//            PageNumber = source.PageNumber,
//            PageSize = source.PageSize,
//            TotalItemCount = source.TotalItemCount,
//            Subset = context.Mapper.Map<IEnumerable<TSource>, IEnumerable<TDestination>>(source) //User mapper to go from "foo" to "bar"
//        };
//    }
//}


//public class ConverterIPagedList<TSource, TDestination> : ITypeConverter<PagedViewModel<TSource>, PagedList<TDestination>>
//{
//    public PagedList<TDestination> Convert(PagedViewModel<TSource> source, PagedList<TDestination> destination, ResolutionContext context)
//    {
//        throw new NotImplementedException();
//    }
//}