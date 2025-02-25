﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.DBClasses;
using Entities.DTOClasses.ReturnResultsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract.Repositories;

namespace Business.Concrete
{
    public class CatalogAlbumServiceManager : ICatalogAlbumService
    {
        private readonly ICatalogAlbumDal _catalogAlbumDal;

        public CatalogAlbumServiceManager(ICatalogAlbumDal catalogAlbumDal)
        {
            _catalogAlbumDal = catalogAlbumDal;
        }

        public async Task<IResult> Add(CatalogAlbum catalogAlbum)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Delete(CatalogAlbum catalogAlbum)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<List<CatalogAlbum>>> GetByCatalogId(long catalogId)
        {
            throw new NotImplementedException();
        }

    }
}
