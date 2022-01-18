﻿using Entities.DBClasses;
using Entities.DTOClasses.ReturnResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAlbumService
    {
        Task<IDataResult<List<Album>>> GetAll();
        Task<IDataResult<List<Album>>> GetAlbumListByTitleAndArtistName(string title, string artistName);
        Task<IDataResult<Album>> GetById(int albumId);
        Task<IResult> Delete(Album album);
        Task<IResult> Update(Album album);
        Task<IResult> Add(Album album);
    }
}
