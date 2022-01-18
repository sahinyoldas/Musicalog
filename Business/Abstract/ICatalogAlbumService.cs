﻿using Entities.DBClasses;
using Entities.DTOClasses.ReturnResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICatalogAlbumService
    {
        Task<IDataResult<List<CatalogAlbum>>> GetAll();
        Task<IDataResult<CatalogAlbum>> GetById(int catalogAlbumStockId);
        Task<IResult> Delete(CatalogAlbum catalogAlbum);
        Task<IResult> Update(CatalogAlbum catalogAlbum);
        Task<IResult> Add(CatalogAlbum catalogAlbum);
    }
}
