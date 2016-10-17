﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankoProject.Models;
using BankoProject.ViewModels;
using Caliburn.Micro;

namespace BankoProject.Tools
{
  class Saver
  {
    private BingoEvent _event;
    private bool _init;
    private readonly ILog _log = LogManager.GetLog(typeof(MainWindowViewModel));

    public bool Init
    {
      get
      {
        return _init;
      }

      set
      {
        _init = value;
      }
    }
    public Saver(BingoEvent eEvent)
    {
      _event = eEvent;
    }

    private void Initialize()
    {



      Init = true;
    }

    public void SaveSession()
    {
      _log.Error(new Exception("NOT IMPLEMENTED"));
    }
  }

}
