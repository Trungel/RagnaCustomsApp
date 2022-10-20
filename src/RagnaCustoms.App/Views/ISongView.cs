﻿using System.Collections.Generic;
using RagnaCustoms.Models;
using RagnaCustoms.Presenters;

namespace RagnaCustoms.Views
{
    public interface ISongView : IView
    {
        SongPresenter Presenter { set; }
        IEnumerable<SongSearchModel> Songs { get; set; }

    }
}